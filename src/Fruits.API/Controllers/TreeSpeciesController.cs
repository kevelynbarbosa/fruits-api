using Fruits.Domain.Services.Interfaces;
using Fruits.DTO.TreeSpecies.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fruits.API.Controllers
{
    [ApiController]
    [Route("api/tree-species")]
    public class TreeSpeciesController : ControllerBase
    {
        private readonly ITreeSpeciesService _treeSpeciesService;

        public TreeSpeciesController(ITreeSpeciesService treeSpeciesService)
        {
            _treeSpeciesService = treeSpeciesService;
        }

        [HttpPost("")]
        public async Task<IActionResult> InsertAsync([FromBody] TreeSpecieInsertRequest request)
        {
            var response = await _treeSpeciesService.InsertAsync(request);

            return Ok(response);
        }


        [HttpGet("")]
        public async Task<IActionResult> GetAsync()
        {
            var response = await _treeSpeciesService.GetAsync();

            return Ok(response);
        }
    }
}
