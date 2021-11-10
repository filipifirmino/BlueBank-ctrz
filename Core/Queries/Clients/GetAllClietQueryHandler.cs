using BlueBank.Domain.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Queries.Clients
{
    public class GetAllClietQueryHandler
    {

        private readonly IClientRepository _clientRepository;

        public GetAllClietQueryHandler(IClientRepository repository)
        {
            _clientRepository = repository;
        }

        public List<Core.Client> GetAllClients()
        {
            return _clientRepository.GetAll();
        }
    }
}
