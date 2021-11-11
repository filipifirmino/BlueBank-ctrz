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
        //Deposit
        [HttpPost("{accountId},{value}")]
        public IActionResult Deposit([FromRoute] Guid accoutId, Double value)
        {
          return Ok("Sucess");
        }

        //Saque
        [HttpPost("{accountId},{value}")]
        public IActionResult Withdraw([FromRoute] Guid accoutId, Double value)
        {
            return Ok("Sucess");
        }

        //Transferencia
        [HttpPost("{accountId},{value},{accountDestinyId}")]
        public IActionResult Transfer([FromRoute] Guid accoutId, Guid accountDestinyId, double value )
        {
            return Ok("Sucess");
        }

        //Saldo
        [HttpGet("{accountId}")]
        public IActionResult GetBalance([FromRoute] Guid accoutId)
        {
            return Ok("Sucess");
        }

    }
}
