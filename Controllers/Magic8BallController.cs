using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallServices _magic8BallServices;
        public Magic8BallController(Magic8BallServices magic8BallServices)
        {
            _magic8BallServices = magic8BallServices;
        }
        [HttpGet]
        [Route("Magic8Ball/{input}")]
        public string MagicBallRespownse(string input)
        {
            return _magic8BallServices.Answers(input);
        }

    }
}