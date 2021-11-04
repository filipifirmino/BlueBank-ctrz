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
        public IActionResult GetAll()
        {
            // metodo para acessar o BD e obter a lista de clientes
            return Ok(new List<Client> { }); //formatar caso n�o esteja;          
        }

        [HttpGet("{Id}")]
        public  IActionResult GetClient([FromRoute]Guid id)
        {
            // metodo para acessar o BD e obter a lista de clientes
            return Ok(new Client); //formatar caso n�o esteja;          
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteClient([FromRoute]Guid id)
        {
           // metodo para acessar o BD e deletar um cliente
           //N�o retorna informa��o
           return Ok(); // caso de sucesso
           // return BadRequest(); caso de erro
        }

        [HttpPost]
        public IActionResult AddClient([FromBody]Client client)
        {
           // metodo para acessar o BD e adicionar um cliente
           //N�o retorna nada
           return Ok(); // caso de sucesso
           // return BadRequest(); caso de erro
        }

        [HttpPut]
        public IActionResult UpdateClient([FromBody]Client client)
        {
           // metodo para acessar o BD e adicionar um cliente
           //N�o retorna nada
           return Ok(); // caso de sucesso
           // return BadRequest(); caso de erro
        }
    }
}