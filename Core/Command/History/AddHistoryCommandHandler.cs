using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Requestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Command.History
{
    public class AddHistoryCommandHandler
    {
        private readonly IHistoryRepository _historyRepository;

        public AddHistoryCommandHandler(IHistoryRepository repository)
        {
            _historyRepository = repository;
        }
        public Transaction Add(AddHistoryRequest request)
            // Desconstruir requeste para salvar no banco.
        {
            var History = new Transaction(); // Implementar variantes do contrutor

            _historyRepository.Add(History);
            _historyRepository.Save();

            return History;
        }
    }
}
