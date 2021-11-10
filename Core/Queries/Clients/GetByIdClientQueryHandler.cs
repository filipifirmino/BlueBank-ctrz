using BlueBank.Domain.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Queries.Client
{
    public class GetByIdClientQueryHandler
    {
        private readonly IClientRepository _clientRepository;

        public GetByIdClientQueryHandler(IClientRepository repository)
        {
            _clientRepository = repository;
        }

        public Core.Client GetClientById(Guid id)
        {
           return _clientRepository.GetById(id);
        }
    }
}
