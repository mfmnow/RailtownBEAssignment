using Mfm.RailtownAi.Data.Contracts;
using Mfm.RailtownAi.Data.Entities;
using Mfm.RailtownAi.Domain.Contracts;
using Mfm.RailtownAi.Domain.Models;
using Moq;

namespace Mfm.RailtownAi.Domain.Services.UnitTests.MockProviders
{
    internal class CloseUsersDomainServiceMockerProvider
    {
        public static (Mock<IUserEntityDataAccess>, Mock<ICloseUsersGeoComparerDomainService>, 
            Mock<IUserAddressFormatterDomainService>, Mock<CloseUsersDomainService>) GetMocks()
        {

            var mockedUserEntityDataAccess = new Mock<IUserEntityDataAccess>();
            var mockedCloseUsersGeoComparerDomainService = new Mock<ICloseUsersGeoComparerDomainService>();
            var mockedUserAddressFormatterDomainService = new Mock<IUserAddressFormatterDomainService>();
            var mockedCloseUsersDomainService = new Mock<CloseUsersDomainService>(mockedUserEntityDataAccess.Object,
                mockedCloseUsersGeoComparerDomainService.Object, mockedUserAddressFormatterDomainService.Object)
            { CallBase = true };

            return (mockedUserEntityDataAccess, mockedCloseUsersGeoComparerDomainService, mockedUserAddressFormatterDomainService,
                mockedCloseUsersDomainService);
        }
    }
}