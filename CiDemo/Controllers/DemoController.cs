using Microsoft.AspNetCore.Mvc;

namespace CiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet(Name = "GetVersion")]
        public string GetVersion()
        {
            return "0.1.1.8";
        }
    }
}