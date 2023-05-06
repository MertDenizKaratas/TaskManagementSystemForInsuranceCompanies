using ETicaretAPI.Application.CustomAttributes;
using ETicaretAPI.Application.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class FilesController : ControllerBase
    {
        readonly IConfiguration _configuration;

        public FilesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("[action]")]

        [AuthorizeDefinition(ActionType = ActionType.Reading, Definition = "Get Storage Type", Menu = "Files")]
        public IActionResult GetBaseStorageUrl()
        {
            return Ok(new
            {
                Url = _configuration["BaseStorageUrl"]
            });
        }

    }
}
