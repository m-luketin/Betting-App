using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BettingApp.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BettingApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        private readonly IUserRepository _userRepository;

        [HttpGet("balance")]
        public IActionResult GetUserBalance()
        {
            return Ok(_userRepository.GetUserBalance());
        }

        [HttpPost("edit-balance")]
        public IActionResult EditUserBalance([FromBody]JObject data)
        {
            var balanceToAdd = Convert.ToDouble(data["balanceToAdd"]);
            return Ok(_userRepository.AddUserBalance(balanceToAdd));
        }
    }
}