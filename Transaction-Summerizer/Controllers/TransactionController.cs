using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transaction_Summerizer_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Transaction_Summerizer.Services;

namespace Transaction_Summerizer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateSummery()
        {
            return Ok("POST: Create summary (not implemented)");
        }

        [HttpGet("{id?}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DisplaySummery(int? id)
        {
            var users = _transactionService.GetAllTransactions();

            if (id == null)
            {
                return Ok(users);
            }

            var user = users.FirstOrDefault(t => t.ID == id);
            if (user == null)
                return NotFound($"User with ID {id} not found.");

            return Ok(user);
        }

        [HttpDelete]
        public IActionResult DeleteSummery()
        {
            return Ok("DELETE: Delete summary (not implemented)");
        }

        [HttpPut]
        public IActionResult UpdateSummery()
        {
            return Ok("PUT: Update summary (not implemented)");
        }
    }
}
