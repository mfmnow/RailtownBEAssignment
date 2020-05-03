using Mfm.RailtownAi.Data.Entities;
using Mfm.RailtownAi.Domain.Contracts;
using Mfm.RailtownAi.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mfm.RailtownAi.Domain.Services
{
    public class CloseUsersGeoComparerDomainService : ICloseUsersGeoComparerDomainService
    {
        private readonly IGeoDistanceCalculatorDomainService _geoDistanceCalculator;
        public CloseUsersGeoComparerDomainService(IGeoDistanceCalculatorDomainService geoDistanceCalculator) 
        {
            _geoDistanceCalculator = geoDistanceCalculator;
        }

        public Task<UserGeoModel> GetClosestUsers(List<UserEntity> userEntities)
        {
            List<UserGeoModel> list = new List<UserGeoModel>();
            userEntities.Select(
                    (u, index) =>
                    {
                        for (int i = 0; i < userEntities.Count; i++)
                        {
                            if (i > index)
                            {
                                var userEntity  = userEntities[i];
                                list.Add(new UserGeoModel
                                {
                                    User1Id = u.Id,
                                    User2Id = userEntity.Id,
                                    Distance = _geoDistanceCalculator.GetDistance(u.Address.Geo.Lat, u.Address.Geo.Lng,
                                        userEntity.Address.Geo.Lat, userEntity.Address.Geo.Lng)
                                });
                            }
                        }
                        return new object();
                    }
                ).ToList();
            var closestUsers = list.OrderByDescending(u => u.Distance).ToList();
            return Task.FromResult(closestUsers[0]);
        }
    }
}
