using BlueBank.Domain.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBank.Domain.BlueBankAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public List<Client> GetAll()
        {
            // metodo para acessar o BD e obter a lista de clientes
            return new List<Client> { }; //formatar caso não esteja;          
        }

        [HttpGet("{Id}")]
        public  IActionResult GetClient([FromRoute]Guid Id)
        {
            // metodo para acessar o BD e obter a lista de clientes
            return Ok(new Client); //formatar caso não esteja;          
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteClient([FromRoute]Guid Id)
        {
           // metodo para acessar o BD e deletar um cliente
           //Não retorna nada
           return Ok(); // caso de sucesso
            return BadRequest();
        }


    }
}