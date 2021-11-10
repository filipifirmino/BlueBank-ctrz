using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Requestes;


namespace BlueBank.Domain.Core.Command.Client
{
    public class UpdateClientCommandHandler
    {
        private readonly IClientRepository _clientRepository;

        public UpdateClientCommandHandler(IClientRepository repository)
        {
            _clientRepository = repository;
        }

        public Core.Client Update(UpdateClientRequest request)
        {
            var client = new Core.Client(request.Name, request.Phone, request.Address, request.Cpf);
            _clientRepository.Update(client);
            return client;
        }
    }
}
