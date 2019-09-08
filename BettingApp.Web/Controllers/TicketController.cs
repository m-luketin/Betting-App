using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BettingApp.Data.Entities.Models;
using BettingApp.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BettingApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        public TicketController(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        private readonly ITicketRepository _ticketRepository;

        [HttpPost("add")]
        public IActionResult AddTicket([FromBody]JObject data)
        {
            var moneyBet = Convert.ToDouble(data["moneyBet"]);
            var totalQuota = Convert.ToDouble(data["totalQuota"]);
            var pairIdJson = data["pairIds"];
            var pairIds = pairIdJson.Select(x => (int)x).ToList();
            var wasAddSuccessful = _ticketRepository.AddTicket(moneyBet, totalQuota, pairIds);

            if(wasAddSuccessful)
                return Ok();

            return Forbid();
        }
    }
}