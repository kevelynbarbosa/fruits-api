using Fruits.Domain.Services.Interfaces;
using Fruits.DTO.Trees.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fruits.API.Controllers
{
    [ApiController]
    [Route("api/trees")]
    public class TreesController : ControllerBase
    {
        private readonly ITreesService _treesService;

        public TreesController(ITreesService treesService)
        {
            _treesService = treesService;
        }

        [HttpPost("")]
        public async Task<IActionResult> InsertAsync([FromBody] TreeInsertRequest request)
        {
            var response = await _treesService.InsertAsync(request);

            return Ok(response);
        }


        [HttpGet("")]
        public async Task<IActionResult> GetAsync()
        {
            var response = await _treesService.GetAsync();

            return Ok(response);
        }
    }
}
