using BlueBank.Domain.Core.Command.Transaction;
using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Requestes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionRepository _repository;
        private readonly IAccountRepository _accountRepository;

        public TransactionsController(ITransactionRepository repository, IAccountRepository accountRepository)
        {
            _repository = repository;
            _accountRepository = accountRepository;
        }
        //Deposit
        [HttpPost]
        [Route("deposit/{AccountId}/{Value}")]
        public IActionResult Deposit([FromRoute] AddTransctionDeposit request )
        {

            var Handler = new DepositCommandHandler(_repository, _accountRepository);
            var result = Handler.Deposit(request);
            return Ok(result);
        }

        //Saque
        [HttpPost]
        [Route("withdraw/{AccountId}/{Value}")]
        public IActionResult Withdraw([FromRoute] AddTransactionWhitdraw request)
        {
            var Handler = new WithdrawCommandHandler(_repository, _accountRepository);
            Handler.Withdraw(request);
           
            return Ok("Sucess");
        }

        //Transferencia
        [HttpPost]
        [Route("transfer/{AccountId}/{Value}/{AccountDestinyId}")]
        public IActionResult Transfer([FromRoute] TransactionTransferRequest request )
        {
            var Handler = new TransferCommandHandler(_repository, _accountRepository);
            Handler.Transfer(request);
            return Ok("Sucess");
        }

    }
}
