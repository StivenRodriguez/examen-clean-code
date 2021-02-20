using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Roulette.Bussines.Interfaces;

namespace Roulette.Api.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class RouletteController : ControllerBase
    {
        private readonly IRouletteBussines _rouletteBusiness;

        public RouletteController(IRouletteBussines rouletteBusiness)
        {
            _rouletteBusiness = rouletteBusiness;
        }

        [Produces("application/json")]
        [HttpPost("AddRoulette")]
        public IActionResult AddRoulette()
        {
            //var response;
            //response.ResponseCode
            return StatusCode(200, null);
        }

        [Produces("application/json")]
        [HttpPost("OpenRoulette")]
        public IActionResult OpenRoulette(int idRoulette)
        {
            //var response;
            //response.ResponseCode
            return StatusCode(200, null);
        }

        [Produces("application/json", Type = typeof(Bets))]
        [HttpPost("AddBet")]
        public IActionResult AddBet()
        {
            //var response;
            //response.ResponseCode
            return StatusCode(200, null);
        }

        [Produces("application/json", Type = typeof(Bets))]
        [HttpPost("CloseBet")]
        public IActionResult CloseBet()
        {
            //var response;
            //response.ResponseCode
            return StatusCode(200, null);
        }

        [Produces("application/json")]
        [HttpGet("OpConsultarNoveadesNucleo")]
        public IActionResult ConsultarNoveadesNucleo()
        {
            //var response;
            //response.ResponseCode
            return StatusCode(200, null);
        }


    }
}