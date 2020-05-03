using Mfm.RailtownAi.Data.Entities;

namespace Mfm.RailtownAi.Domain.Services.UnitTests.MockProviders
{
    internal class UserAddressFormatterDomainServiceMockerProvider
    {
        public static Address MockedAddress = new Address
        {
            City = "City",
            Street = "Street",
            Suite = "Suite",
            Zipcode = "Zipcode"
        };
        public static string ExpectedFormatedMockedAddress = "Suite / Street City. Zip:Zipcode";
    }
}
