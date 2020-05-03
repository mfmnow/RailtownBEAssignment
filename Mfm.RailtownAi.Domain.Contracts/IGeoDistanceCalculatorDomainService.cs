using Mfm.RailtownAi.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mfm.RailtownAi.Domain.Contracts
{
    public interface IGeoDistanceCalculatorDomainService
    {
        double GetDistance(double lat1, double lon1, double lat2, double lon2);       
    }
}
