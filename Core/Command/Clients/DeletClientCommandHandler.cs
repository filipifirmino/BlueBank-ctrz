
using BlueBank.Domain.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Command.Client
{
    public class DeletClientCommandHandler
    {
        private readonly IClientRepository _clientRepository;

        public DeletClientCommandHandler(IClientRepository repository)
        {
            _clientRepository = repository;
        }

        public void Delete(Core.Client client)
        {
            _clientRepository.Remove(client);
        }
    }
}
