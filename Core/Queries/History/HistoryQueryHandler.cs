using BlueBank.Domain.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Queries.History
{
    public class HistoryQueryHandler
    {
        private readonly IHistoryRepository _historyRespository;

        public HistoryQueryHandler(IHistoryRepository repository)
        {
            _historyRespository = repository;
        }

        public List<Transaction> GetAllHistoryById(Guid id)
        {
            return _historyRespository.GetAllByAccountId(id);
        }
    }
}
