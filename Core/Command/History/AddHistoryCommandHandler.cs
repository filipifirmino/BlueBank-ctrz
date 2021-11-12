using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Requestes;


namespace BlueBank.Domain.Core.Command.History
{
    public class AddHistoryCommandHandler
    {
        private readonly IHistoryRepository _historyRepository;

        public AddHistoryCommandHandler(IHistoryRepository repository)
        {
            _historyRepository = repository;
        }

        public Core.Transaction Add(AddHistoryRequest request)

        {
            var History = new Core.Transaction(); 

            _historyRepository.Add(History);
            _historyRepository.Save();

            return History;
        }
    }
}
