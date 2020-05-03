using Mfm.RailtownAi.Data.Contracts;
using Mfm.RailtownAi.Domain.Contracts;
using Mfm.RailtownAi.Domain.Models;
using Mfm.RailtownAi.Domain.Models.Exceptions;
using Mfm.RailtownAi.Domain.Services.UnitTests.MockProviders;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Mfm.RailtownAi.Domain.Services.UnitTests
{
    public class TestModelDomainServiceUnitTests
    {
        /*private readonly Mock<ITestEntityDataAccess> _testModelDataAccess;
        private readonly Mock<TestModelDomainService> _testModelDomainService;
        private readonly Mock<ITextManagerDomainService> _textManagerDomainService;

        public TestModelDomainServiceUnitTests()
        {
            (_testModelDataAccess, _testModelDomainService, _textManagerDomainService) =
                TestModelDomainServiceMockerProvider.GetMocks();
        }

        [Fact]
        public async Task CreateTestModel_Should_Follow_LogicalFlow_On_Valid_Model()
        {
            _testModelDomainService.Setup(t => t.IsValidModel(It.IsAny<TestModel>())).Returns(true);
            await _testModelDomainService.Object.CreateTestModel(TestModelDomainServiceMockerProvider.MockedValidTestModel);

            _testModelDomainService.Verify(t => t.IsValidModel(TestModelDomainServiceMockerProvider.MockedValidTestModel), Times.Once);
            _testModelDataAccess.Verify(t => t.CreateTestEntity(It.IsAny<string>(), ""), Times.Once);
            _textManagerDomainService.Verify(t => t.ToUpper(TestModelDomainServiceMockerProvider.MockedValidTestModel.Test), Times.Once);
        }

        [Fact]
        public void CreateTestModel_Should_Follow_LogicalFlow_On_InValid_Model()
        {
            _testModelDomainService.Setup(t => t.IsValidModel(It.IsAny<TestModel>())).Returns(false);

            Assert.ThrowsAsync<InvalidTestModelException>(() => _testModelDomainService.Object.CreateTestModel(TestModelDomainServiceMockerProvider.MockedValidTestModel));

            _testModelDomainService.Verify(t => t.IsValidModel(TestModelDomainServiceMockerProvider.MockedValidTestModel), Times.Once);
            _testModelDataAccess.Verify(t => t.CreateTestEntity(It.IsAny<string>(), ""), Times.Never);
        }

        [Fact]
        public void IsValidModel_Should_Return_True_If_Model_Is_Valid()
        {
            var result = _testModelDomainService.Object.IsValidModel(TestModelDomainServiceMockerProvider.MockedValidTestModel);

            Assert.True(result);
        }

        [Fact]
        public void IsValidModel_Should_Return_False_If_Model_Is_Not_Valid()
        {
            _testModelDomainService.Reset();
            var result = _testModelDomainService.Object.IsValidModel(TestModelDomainServiceMockerProvider.MockedInvalidTestModel);

            Assert.False(result);
        }*/
    }
}