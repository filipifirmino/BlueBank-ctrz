using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Queries.History;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueBank.Domain.Core.Requestes;
using BlueBank.Domain.Core.Command.History;

namespace BlueBankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        public readonly IHistoryRepository _historyRepository;

        public HistoryController(IHistoryRepository repository)
        {
            _historyRepository = repository;
        }
    
        [HttpGet("{id}")]
        public IActionResult GetAll([FromQuery] Guid id)
        {
            var handler = new HistoryQueryHandler(_historyRepository);
            var result = handler.GetAllHistoryById(id);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add([FromBody] AddHistoryRequest request)
        {
            var handler = new AddHistoryCommandHandler(_historyRepository);
            var result = handler.Add(request);
            return Ok(result);
        }
    }
}
