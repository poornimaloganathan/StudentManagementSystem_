using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Api.Controllers
{
    [Route("api/fruits")]
    [ApiController]
    [Authorize]
    public class FruitsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var fruits = await Task.FromResult(new string[] { "apple", "banana", "kiwi" });
            return Ok(fruits);
        }

        [HttpGet]
        [Route("test")]
        [AllowAnonymous]
        public async Task<IActionResult> Test()
        {
            var fruits = await Task.FromResult(new string[] { "apple", "banana", "kiwi" });
            return Ok(fruits);
        }
    }
}






