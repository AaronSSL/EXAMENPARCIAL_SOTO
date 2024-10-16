using EXAMENPARCIAL_SOTO.DOMAIN.CORE.ENTITIES;
using EXAMENPARCIAL_SOTO.DOMAIN.CORE.INTERFACES;
using Microsoft.AspNetCore.Mvc;

namespace EXAMENPARCIAL_SOTO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencyController : ControllerBase
    {
        private readonly ICompetencyRepository _competencyRepository;

        public CompetencyController(ICompetencyRepository competencyRepository)
        {
            _competencyRepository = competencyRepository;
        }

        [HttpGet()]
        public async Task<IActionResult> GetCompetency()
        {
            var compe = await _competencyRepository.GetCompetency();
            return Ok(compe);
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Competency competency)
        {
            int compId = await _competencyRepository.Insert(competency);
            return Ok(compId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Competency competency)
        {
            if (id != competency.Id) return BadRequest();
            var result = await _competencyRepository.Update(competency);
            if (!result) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _competencyRepository.Delete(id);
            if (!result) return NotFound();
            return Ok(result);
        }

    }
}
