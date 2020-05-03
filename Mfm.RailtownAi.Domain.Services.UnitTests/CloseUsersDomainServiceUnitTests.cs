using Mfm.RailtownAi.Data.Contracts;
using Mfm.RailtownAi.Data.Entities;
using Mfm.RailtownAi.Domain.Contracts;
using Mfm.RailtownAi.Domain.Models;
using Mfm.RailtownAi.Domain.Models.Exceptions;
using Mfm.RailtownAi.Domain.Services.UnitTests.MockProviders;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Mfm.RailtownAi.Domain.Services.UnitTests
{
    public class CloseUsersDomainServiceUnitTests
    {
        private readonly Mock<IUserEntityDataAccess> _mockedUserEntityDataAccess;
        private readonly Mock<ICloseUsersGeoComparerDomainService> _mockedCloseUsersGeoComparerDomainService;
        private readonly Mock<IUserAddressFormatterDomainService> _mockedUserAddressFormatterDomainService;
        private readonly Mock<CloseUsersDomainService> _mockedCloseUsersDomainService;

        public CloseUsersDomainServiceUnitTests()
        {
            (_mockedUserEntityDataAccess, _mockedCloseUsersGeoComparerDomainService, _mockedUserAddressFormatterDomainService,
                _mockedCloseUsersDomainService) =
                CloseUsersDomainServiceMockerProvider.GetMocks();
        }

        [Fact]
        public async Task CreateTestModel_Should_Follow_LogicalFlow_On_Valid_Empty_Model()
        {
            _mockedUserEntityDataAccess.Setup(t => t.GetUserEntitiies())
                .Returns(Task.FromResult(new List<UserEntity>()));
            _mockedCloseUsersGeoComparerDomainService.Setup(t => t.GetClosestUsers(new List<UserEntity>()))
                .Returns(Task.FromResult(new UserGeoModel()));
            await _mockedCloseUsersDomainService.Object.GetClosestUsers();

            _mockedUserEntityDataAccess.Verify(t => t.GetUserEntitiies(), Times.Once);
            _mockedCloseUsersGeoComparerDomainService.Verify(t => t.GetClosestUsers(It.IsAny<List<UserEntity>>()), Times.Once);
            _mockedUserAddressFormatterDomainService.Verify(t => t.FormatAddress(It.IsAny<Address>()), Times.Never);
        }
    }
}