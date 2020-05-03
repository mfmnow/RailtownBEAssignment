using Mfm.RailtownAi.Data.Contracts;
using Mfm.RailtownAi.Data.Entities;
using Mfm.RailtownAi.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;
//using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mfm.RailtownAi.Data.Services
{
    public class UserEntityDataAccess : IUserEntityDataAccess
    {
        private readonly AppSettings _appSettings;
        public UserEntityDataAccess(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public async virtual Task<List<UserEntity>> GetUserEntitiies()
        {
            /*var json = File.ReadAllText("App_Data/DataSource.json");
            return Task.FromResult(JsonConvert.DeserializeObject<List<UserEntity>>(json));*/

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(_appSettings.DataSourceURL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<UserEntity>>(responseBody);
        }
    }
}
