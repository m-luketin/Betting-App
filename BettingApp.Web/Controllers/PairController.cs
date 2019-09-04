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
    public class PairController : ControllerBase
    {
        public PairController(IPairRepository pairRepository)
        {
            _pairRepository = pairRepository;
        }
        private readonly IPairRepository _pairRepository;

        [HttpGet("future")]
        public IActionResult GetFuturePairs()
        {
            return Ok(_pairRepository.GetFuturePairs());
        }
        [HttpGet("date/{date}")]
        public IActionResult GetPairsByDate(string date)
        {
            return Ok(_pairRepository.GetPairsByDate(date));
        }
    }
}