using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace sales_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        [HttpGet("status")]
        public IActionResult ApiGetStatus()
        {
            return Ok(new
            {
                service = "Sales-Api",
                Status = "up",
                httpStatus = HttpStatusCode.OK
            });
        }
    }
}
