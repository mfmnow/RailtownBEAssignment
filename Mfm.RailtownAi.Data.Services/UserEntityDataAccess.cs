using Mfm.RailtownAi.Data.Contracts;
using Mfm.RailtownAi.Data.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Mfm.RailtownAi.Data.Services
{
    public class UserEntityDataAccess : IUserEntityDataAccess
    {
        public Task<List<UserEntity>> GetUserEntitiies()
        {
            var json = File.ReadAllText("App_Data/DataSource.json");
            return Task.FromResult(JsonConvert.DeserializeObject<List<UserEntity>>(json));
        }
    }
}
