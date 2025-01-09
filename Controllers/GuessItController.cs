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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;
        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }
        [HttpGet]
        [Route("Easy/{GuessEasy}")]
        public string EasyGuess(string GuessEasy)
        {
            return _guessItServices.EasyGuess(GuessEasy);

        }
        [HttpGet]
        [Route("Medium/{GuessMedium}")]
        public string MediumGuess(string GuessMedium)
        {
            return _guessItServices.MediumGuess(GuessMedium);
        }
        [HttpGet]
        [Route("Hard/{GuessHard}")]
        public string HardGuess(string GuessHard)
        {
            return _guessItServices.HardGuess(GuessHard);
        }
    }
}