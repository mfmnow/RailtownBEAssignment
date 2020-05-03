using Mfm.RailtownAi.Data.Entities;
using Mfm.RailtownAi.Domain.Contracts;

namespace Mfm.RailtownAi.Domain.Services
{
    public class UserAddressFormatterDomainService : IUserAddressFormatterDomainService
    {
        public string FormatAddress(Address address)
        {
            return $"{address.Suite} / {address.Street} {address.City}. Zip:{address.Zipcode}";
        }
    }
}
