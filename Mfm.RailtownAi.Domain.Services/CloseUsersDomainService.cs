using Mfm.RailtownAi.Data.Contracts;
using Mfm.RailtownAi.Domain.Contracts;
using Mfm.RailtownAi.Domain.Models;
using Mfm.RailtownAi.Domain.Models.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mfm.RailtownAi.Domain.Services
{
    public class CloseUsersDomainService : ICloseUsersDomainService
    {
        private readonly IUserEntityDataAccess _userEntityDataAccess;
        private readonly ICloseUsersGeoComparerDomainService _closeUsersGeoComparer;
        private readonly IUserAddressFormatterDomainService _userAddressFormatterDomainService;

        public CloseUsersDomainService(IUserEntityDataAccess userEntityDataAccess,
            ICloseUsersGeoComparerDomainService closeUsersGeoComparer,
            IUserAddressFormatterDomainService userAddressFormatterDomainService)
        {
            _userEntityDataAccess = userEntityDataAccess;
            _closeUsersGeoComparer = closeUsersGeoComparer;
            _userAddressFormatterDomainService = userAddressFormatterDomainService;
        }

        public async Task<List<UserModel>> GetClosestUsers()
        {
            var result = await _userEntityDataAccess.GetUserEntitiies();
            var closestUserGeoModel = await _closeUsersGeoComparer.GetClosestUsers(result);
            long[] closestUserGeoModelIds = { closestUserGeoModel.User1Id, closestUserGeoModel.User2Id };
            List<long> usersIds = new List<long>(closestUserGeoModelIds);
            var usersList = result.Where(u => usersIds.Contains(u.Id)).ToList();
            return usersList.Select(u => 
            { 
                return new UserModel 
                { 
                    Name = u.Name,
                    Address = _userAddressFormatterDomainService.FormatAddress(u.Address),
                    CompanyName = u.Company.Name,
                    Distance = closestUserGeoModel.Distance,
                    Phone = u.Phone
                }; 
            }).ToList();
        }
    }
}
