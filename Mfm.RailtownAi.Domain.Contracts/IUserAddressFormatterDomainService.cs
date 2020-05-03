using Mfm.RailtownAi.Data.Entities;

namespace Mfm.RailtownAi.Domain.Contracts
{
    public interface IUserAddressFormatterDomainService
    {
        string FormatAddress(Address address);
    }
}
