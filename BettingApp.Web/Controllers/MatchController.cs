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

        [HttpGet("future")]
        public IActionResult GetFutureMatches()
        {
            return Ok(_matchRepository.GetFutureMatches());
        }
        [HttpGet("{sport}/{date}")]
        public IActionResult GetMatchesBySportAndDate(string sport, string date)
        {
            return Ok(_matchRepository.GetMatchesBySportAndDate(sport,date));
        }
    }
}