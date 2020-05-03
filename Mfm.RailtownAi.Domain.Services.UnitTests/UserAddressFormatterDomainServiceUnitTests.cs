using Mfm.RailtownAi.Domain.Services.UnitTests.MockProviders;
using Xunit;

namespace Mfm.RailtownAi.Domain.Services.UnitTests
{
    public class UserAddressFormatterDomainServiceUnitTests
    {
        [Fact]
        public void FormatAddress_Should_Return_Correct_Result()
        {
            var userAddressFormatterDomainService = new UserAddressFormatterDomainService();
            var result = userAddressFormatterDomainService.FormatAddress(UserAddressFormatterDomainServiceMockerProvider.MockedAddress);
            Assert.Equal(result, UserAddressFormatterDomainServiceMockerProvider.ExpectedFormatedMockedAddress);
        }        
    }
}