using Mfm.RailtownAi.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mfm.RailtownAi.Data.Contracts
{
    public interface IUserEntityDataAccess
    {
        Task<List<UserEntity>> GetUserEntitiies();
    }
}
