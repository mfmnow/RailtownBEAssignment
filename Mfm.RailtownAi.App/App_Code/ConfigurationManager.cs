using Mfm.RailtownAi.Data.Contracts;
using Mfm.RailtownAi.Data.Services;
using Mfm.RailtownAi.Domain.Contracts;
using Mfm.RailtownAi.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace Mfm.RailtownAi.App.App_Code
{
    public class ConfigurationManager
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            var _connectionString = configuration.GetConnectionString("DefaultConnection")
                .Replace("{AppDir}", Directory.GetCurrentDirectory());

            services.AddDbContext<TestDbContext>(options =>
            options.UseSqlServer(_connectionString));

            //ConfigureSettings(services, configuration);
            ConfigureDataServices(services);
            ConfigureDomainServices(services);
        }

        /*private static void ConfigureSettings(IServiceCollection services, IConfiguration configuration)
        {
            var config = new AppSettings();
            configuration.Bind("AppSettings", config);
            services.AddSingleton(config);
        }*/

        private static void ConfigureDataServices(IServiceCollection services)
        {
            services.AddScoped<IDbInitializer, DbInitializer>();
            services.AddScoped<ITestEntityDataAccess, TestEntityDataAccess>();
            services.AddScoped<IUserEntityDataAccess, UserEntityDataAccess>();
            services.AddScoped<ITestDbContext, TestDbContext>();            
        }

        private static void ConfigureDomainServices(IServiceCollection services)
        {
            services.AddScoped<ICloseUsersDomainService, CloseUsersDomainService>();
            services.AddScoped<ICloseUsersGeoComparerDomainService, CloseUsersGeoComparerDomainService>();
            services.AddScoped<IGeoDistanceCalculatorDomainService, GeoDistanceCalculatorDomainService>();
            services.AddScoped<IUserAddressFormatterDomainService, UserAddressFormatterDomainService>();
        }

    }
}
