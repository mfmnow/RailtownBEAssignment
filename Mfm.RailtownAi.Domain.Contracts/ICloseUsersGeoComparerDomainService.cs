using Mfm.RailtownAi.Data.Entities;
using Mfm.RailtownAi.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mfm.RailtownAi.Domain.Contracts
{
    public interface ICloseUsersGeoComparerDomainService
    {
        Task<UserGeoModel> GetClosestUsers(List<UserEntity> userEntities);       
    }
}
