using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BettingApp.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        public MatchController(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }
        private readonly IMatchRepository _matchRepository;
        
        [HttpGet("{sport}/{date}")]
        public IActionResult GetMatchesBySportAndDate(string sport, string date)
        {
            return Ok(_matchRepository.GetMatchesBySportAndDate(sport,date));
        }
           
        [HttpGet("top-offer/{sport}")]
        public IActionResult GetTopOffer(string sport)
        {
            return Ok(_matchRepository.GetTopOfferBySport(sport));
        }
    }
}