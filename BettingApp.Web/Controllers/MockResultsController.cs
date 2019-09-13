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
    public class MockResultsController : ControllerBase
    {
        public MockResultsController(IMockResultsRepository mockResultsRepository)
        {
            _mockResultsRepository = mockResultsRepository;
        }
        private readonly IMockResultsRepository _mockResultsRepository;

        [HttpPost("update")]
        public IActionResult UpdateResults()
        {
            var wasSuccessful = _mockResultsRepository.UpdateResults();

            if(wasSuccessful)
                return Ok();

            return Forbid();
        }
    }
}