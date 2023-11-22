using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace primeira_api_c_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("GetDateTimeCurrent")]
        public IActionResult GetDateTime()
        {
            var obj = new
            {
                Date = DateTime.Now.ToLongDateString(),
                Time = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }
        [HttpGet("Apresentation/{name}")]
        public IActionResult ToPresent(string name)
        {
            var message = $"Hello {name}, wellcome!";
            return Ok(new {message});
        }
    }
}