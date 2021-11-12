using BlueBank.Domain.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Queries.Account
{
    public class GetHistoryAccountByIdQuerieHandler
    {
        private readonly IHistoryRepository _historyRepository;

        public GetHistoryAccountByIdQuerieHandler(IHistoryRepository historyRepository)
        {
           
            _historyRepository = historyRepository;
        }

        public List<Transaction> GetHistory(Guid id)
        {
            return _historyRepository.GetAllByAccountId(id);
        }
    }
}
