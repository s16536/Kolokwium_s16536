using Kolokwium_s16536.Dtos;
using Kolokwium_s16536.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_s16536.Controllers
{
    [Route(("api/musicians"))]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        private readonly IMusiciansDbService _service;

        public MusiciansController(IMusiciansDbService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetMusician(int id)
        {
            var musician = _service.GetMusician(id);
            if (musician == null)
            {
                return NotFound();
            }
            return Ok(musician);
        }

        [HttpPost]
        public IActionResult AddMusician(AddMusicianRequestDto request)
        {
            var musician = _service.AddMusician(request);
            if (musician == null)
            {
                return BadRequest();
            }
            return Ok(musician);
        }
    }
}
