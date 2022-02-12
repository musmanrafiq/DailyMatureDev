using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DailyDev.Web.Controllers.Info
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddInfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Add([FromBody] InfoModel infoModel)
        {
            var baseModel = new ResponseModel();
            return Ok(baseModel);
        }
    }
}
