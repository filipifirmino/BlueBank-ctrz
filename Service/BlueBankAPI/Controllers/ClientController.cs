using BlueBank.Domain.Core;
using BlueBank.Domain.Core.Command.Client;
using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Queries.Client;
using BlueBank.Domain.Core.Queries.Clients;
using BlueBank.Domain.Shared.Requests;
using BlueBank.Domain.Core.Requestes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BlueBank.Domain.BlueBankAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IAccountRepository _accountRepository;


        public ClientController(IClientRepository repository, IAccountRepository accountRepository)
        {
            _clientRepository = repository;
            _accountRepository = accountRepository;
           
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Handler = new GetAllClietQueryHandler(_clientRepository);
            var result = Handler.GetAllClients();

            return Ok(result);
        }

        [HttpGet("{Id}")]
        public IActionResult GetClient([FromRoute] Guid id)
        {
            var Handler = new GetByIdClientQueryHandler(_clientRepository);
            var result = Handler.GetClientById(id);

            return Ok(result);
        }

        [HttpDelete]
        public IActionResult DeleteClient([FromRoute] Guid id)
        {
            var Handler = new DeletClientCommandHandler(_clientRepository, _accountRepository);
            Handler.Delete(id);

            return Ok();
        }

        [HttpPost]
        public IActionResult AddClient([FromBody] AddClientRequest request)
        {
<<<<<<< HEAD
            try
            {
                var Handler = new AddClientCommandHandler(_clientRepository);
                var result = Handler.Add(request);
=======
            var Handler = new AddClientCommandHandler(_clientRepository, _accountRepository);
            var result = Handler.Add(request);
>>>>>>> main

                return Ok(result);
            }
            catch (Exception e)
            {
               throw new InvalidOperationException("Error:", e);
            }
            
        }

        [HttpPut]
        public IActionResult UpdateClient([FromBody] UpdateClientRequest client)
        {
            var Handler = new UpdateClientCommandHandler(_clientRepository);
            var result = Handler.Update(client);

            return Ok(result);
        }
    }
}