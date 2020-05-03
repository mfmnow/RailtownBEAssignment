using Mfm.RailtownAi.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mfm.RailtownAi.Domain.Contracts
{
    public interface ICloseUsersDomainService
    {
        Task<List<UserModel>> GetClosestUsers();       
    }
}
