using Mfm.RailtownAi.App.Controllers;
using Mfm.RailtownAi.Domain.Contracts;
using Mfm.RailtownAi.Domain.Models.Exceptions;
using Mfm.RailtownAi.App.UnitTests.MockProviders;
using Microsoft.Extensions.Logging;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Mfm.RailtownAi.App.UnitTests
{
    public class UserModelControllerUnitTests
    {
        private readonly Mock<ICloseUsersDomainService> _mockedCloseUsersDomainService;
        private readonly Mock<ILogger<UserModelController>> _mockedLogger;
        private readonly Mock<UserModelController> _userModelController;

        public UserModelControllerUnitTests()
        {
            _mockedCloseUsersDomainService = new Mock<ICloseUsersDomainService>();
            _mockedLogger = new Mock<ILogger<UserModelController>>();
            _userModelController = new Mock<UserModelController>(_mockedCloseUsersDomainService.Object, _mockedLogger.Object)
            { CallBase = true };
        }

        [Fact]
        public async Task CreateTestModel_Should_Follow_LogicalFlow_On_Valid_Model()
        {
            await _userModelController.Object.GetClosestUsers();

            _mockedCloseUsersDomainService.Verify(t => t.GetClosestUsers(), Times.Once);
        }

        [Fact]
        public async Task CreateTestModel_Should_Return_Right_Model_On_Error ()
        {
            _mockedCloseUsersDomainService.Setup(t => t.GetClosestUsers()).Throws(
                new InvalidTestModelException(UserModelControllerMockerProvider.MockedErrorMessage)
                );
            var result = await _userModelController.Object.GetClosestUsers();

            Assert.False(result.Success);
            Assert.Equal(result.ErrorMessage, UserModelControllerMockerProvider.MockedErrorMessage);
            _mockedCloseUsersDomainService.Verify(t => t.GetClosestUsers(), Times.Once);
        }
    }
}