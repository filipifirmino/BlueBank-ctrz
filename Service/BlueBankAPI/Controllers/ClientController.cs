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

        public ClientController(IClientRepository repository)
        {
            _clientRepository = repository;
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
        public IActionResult DeleteClient([FromBody] Client client)
        {
            var Handler = new DeletClientCommandHandler(_clientRepository);
            Handler.Delete(client);

            return Ok();
        }

        [HttpPost]
        public IActionResult AddClient([FromBody] AddClientRequest request)
        {
            var Handler = new AddClientCommandHandler(_clientRepository);
            var result = Handler.Add(request);

            return Ok(result);
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