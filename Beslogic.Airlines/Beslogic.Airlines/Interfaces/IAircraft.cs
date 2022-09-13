using Beslogic.Airlines.Models;

namespace Beslogic.Airlines.Interfaces
{
    public interface IAircraftService
    {
        public IEnumerable<Aircraft> GetAircrafts();
    }
}
