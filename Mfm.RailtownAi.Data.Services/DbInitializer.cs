using Mfm.RailtownAi.Data.Contracts;

namespace Mfm.RailtownAi.Data.Services
{
    public class DbInitializer: IDbInitializer
    {
        private readonly ITestDbContext _context;
        public DbInitializer(ITestDbContext testDbContext)
        {
            _context = testDbContext;
        }
        public void Initialize()
        {
            _context.EnsureCreated();
        }
    }
}
