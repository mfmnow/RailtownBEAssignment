using Mfm.RailtownAi.Domain.Services.UnitTests.MockProviders;
using Xunit;

namespace Mfm.RailtownAi.Domain.Services.UnitTests
{
    public class GeoDistanceCalculatorDomainServiceUnitTests
    {
        [Fact]
        public void FormatAddress_Should_Return_Correct_Result()
        {
            var geoDistanceCalculatorDomainService = new GeoDistanceCalculatorDomainService();
            var result = geoDistanceCalculatorDomainService.GetDistance(GeoDistanceCalculatorDomainServiceMockerProvider.MockedLat1,
                GeoDistanceCalculatorDomainServiceMockerProvider.MockedLng1,
                GeoDistanceCalculatorDomainServiceMockerProvider.MockedLat2,
                GeoDistanceCalculatorDomainServiceMockerProvider.MockedLng2);
            Assert.Equal(result, GeoDistanceCalculatorDomainServiceMockerProvider.ExpectedMockedDistance);
        }        
    }
}