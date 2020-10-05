using Fruits.Domain.Services.Interfaces;
using Fruits.DTO.TreeGroups.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fruits.API.Controllers
{
    [ApiController]
    [Route("api/tree-groups")]
    public class TreeGroupsController : ControllerBase
    {
        private readonly ITreeGroupsService _groupsService;

        public TreeGroupsController(ITreeGroupsService groupsService)
        {
            _groupsService = groupsService;
        }

        [HttpPost("")]
        public async Task<IActionResult> InsertAsync([FromBody] TreeGroupInsertRequest request)
        {
            var response = await _groupsService.InsertAsync(request);

            return Ok(response);
        }


        [HttpGet("")]
        public async Task<IActionResult> GetAsync()
        {
            var response = await _groupsService.GetAsync();

            return Ok(response);
        }
    }
}
