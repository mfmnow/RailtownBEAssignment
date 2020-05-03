using Mfm.RailtownAi.Data.Contracts;
using Mfm.RailtownAi.Data.Entities;
using Mfm.RailtownAi.Domain.Contracts;
using Mfm.RailtownAi.Domain.Models;
using Moq;

namespace Mfm.RailtownAi.Domain.Services.UnitTests.MockProviders
{
    internal class GeoDistanceCalculatorDomainServiceMockerProvider
    {
        public static double MockedLat1 = 29.4572;
        public static double MockedLng1 = -164.2990;
        public static double MockedLat2 = -38.2386;
        public static double MockedLng2 = 57.2232;
        public static double ExpectedMockedDistance = 9999.209892545987;        
    }
}
