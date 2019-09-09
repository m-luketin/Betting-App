using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BettingApp.Data.Enums;
using BettingApp.Domain.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BettingApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        public TransactionController(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        private readonly ITransactionRepository _transactionRepository;

        [HttpPost("add")]
        public IActionResult CreateTransaction(double balanceChange, TransactionType transactionType)
        {
            var wasCreateSuccessful = _transactionRepository.CreateTransaction(balanceChange, transactionType);

            if(wasCreateSuccessful)
                return Ok();

            return Forbid();
        }
        [HttpPost("get/{id}")]
        public IActionResult GetUserTransactions(int id)
        {
            return Ok(_transactionRepository.GetUserTransactions(id));
        }
    }
}