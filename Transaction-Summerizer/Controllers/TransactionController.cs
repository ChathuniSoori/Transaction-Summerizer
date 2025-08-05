using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Transaction_Summerizer_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Transaction_Summerizer.Services;
using Transaction_Summerizer_Services.DTO;
using AutoMapper;

namespace Transaction_Summerizer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;

        public TransactionController(ITransactionService transactionService,IMapper mapper)
        {
            _transactionService = transactionService;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<UserDTO>> GetSummery()
        {
            var users = _transactionService.GetAllTransactions();

            //var usersDto = new List<UserDTO>();
            //foreach (var user in users)
            //{
            //    usersDto.Add(new UserDTO
            //    {
            //        ID = user.ID,
            //        Name = user.Name,
            //        TimeStamp = user.TimeStamp,
            //        TotalSpent = user.TotalSpent,
            //        Category = user.Category,
            //        CategoryID = user.CategoryID,
            //    });
            //}
            var mappedUsers=_mapper.Map<ICollection<UserDTO>>(users);
            return Ok(mappedUsers);
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
