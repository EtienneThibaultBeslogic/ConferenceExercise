using Beslogic.Airlines.Interfaces;
using Beslogic.Airlines.Models;

namespace Beslogic.Airlines.Services
{
    public class IWeatherForecast : IAircraftService
    {
        private Aircraft[] _aircrafts = new[] {
            new Aircraft
            {
                Id = 1,
                Model = "A380",
                Manufacturer = "Airbus"
            },
            new Aircraft
            {
                Id = 2,
                Model = "A350",
                Manufacturer = "Airbus"
            },
            new Aircraft
            {
                Id = 3,
                Model = "A220",
                Manufacturer = "Airbus"
            },
            new Aircraft
            {
                Id = 4,
                Model = "737 MAX-8",
                Manufacturer = "Boeing"
            }
        };

        public IEnumerable<Aircraft> GetAircrafts()
        {
            return _aircrafts;
        }
    }
}
