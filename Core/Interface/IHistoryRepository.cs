using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Interface
{
    public interface IHistoryRepository
    {
        List<Transaction> GetAllByAccountId(Guid Id);
        void Save();
        void Add(Transaction history);
        
    }
}
