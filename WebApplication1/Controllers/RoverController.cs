using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoverController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok("hellow world");
        }

        [HttpPost]
        public IActionResult Post(JObject payload)
        {
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(payload["FL"]);

            return Ok(jsonString);
        }
    }
}
