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
        public List<Client> Get()
        {
            // metodo para acessar o BD e obter a lista de clientes
            return new List<Client> { }; //formatar caso não esteja;          
        }
    }
}