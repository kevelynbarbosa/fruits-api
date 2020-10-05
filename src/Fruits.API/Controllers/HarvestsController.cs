using Fruits.Domain.Services.Interfaces;
using Fruits.DTO.Harvests.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fruits.API.Controllers
{
    [ApiController]
    [Route("api/harvests")]
    public class HarvestsController : ControllerBase
    {
        private readonly IHarvestsService _harvestsService;

        public HarvestsController(IHarvestsService harvestsService)
        {
            _harvestsService = harvestsService;
        }


        [HttpPost("")]
        public async Task<IActionResult> InsertAsync([FromBody] HarvestInsertRequest request)
        {
            var response = await _harvestsService.InsertAsync(request);

            return Ok(response);
        }


        [HttpGet("")]
        public async Task<IActionResult> GetAsync([FromQuery] HarvestFiltersRequest request)
        {
            var response = await _harvestsService.GetAsync(request);

            return Ok(response);
        }
    }
}
