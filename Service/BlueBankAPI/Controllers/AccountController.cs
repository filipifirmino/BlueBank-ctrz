using BlueBank.Domain.Core;
using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Queries.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BlueBank.Domain.BlueBankAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IHistoryRepository _historyRepository;

        public AccountController(IAccountRepository accountRepository, IHistoryRepository historyRepository)
        {
            _accountRepository = accountRepository;
            _historyRepository = historyRepository;
        }

        [HttpGet("/All")]
        public IActionResult GetAll()
        {
            var handler = new GetAllAccountQuerieHandler(_accountRepository);
            return Ok(handler.GetAll());
        }

        [HttpGet]
        [Route("/account/{Id}")]
        public IActionResult GetAccount([FromRoute] Guid id)
        {
            var handler = new GetAccountByIdQuerieHandler(_accountRepository);
            return Ok(handler.GetById(id));
        }

        [HttpGet]
        [Route("/history/{Id}")]
        public IActionResult GetHistory([FromRoute] Guid id)
        {
            var handler = new GetHistoryAccountByIdQuerieHandler(_historyRepository);
            var result = handler.GetHistory(id);

            return Ok(result);
        }
    }
}