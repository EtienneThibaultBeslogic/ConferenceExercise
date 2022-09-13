using Beslogic.Airlines.Interfaces;
using Beslogic.Airlines.Models;
using Microsoft.AspNetCore.Mvc;

namespace Beslogic.Airlines.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AircraftController : ControllerBase {
        private readonly IAircraftService _aircraftService;

        public AircraftController(
            IAircraftService aircraftService
            )
        {
            _aircraftService = aircraftService;
        }

        [HttpGet(Name = "GetAircrafts")]
        public IEnumerable<Aircraft> Get()
        {
            return _aircraftService.GetAircrafts();
        }
    }
}