
using System;
using System.Collections.Generic;
using System.Linq;
using BlueBank.Domain.Core;
using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace BlueBank.Infra.Data.Repositorys
{
    class HistoryRepository : IHistoryRepository
    {
        private readonly BankContext _bankContext;

        public HistoryRepository(BankContext context)
        {
            _bankContext = context;
        }

        public void Add(Transaction history)
        {
            _bankContext.Add(history);
        }

        public List<Transaction> GetAllByAccountId(Guid Id)
        {
            return _bankContext.Transactions.AsNoTracking().Single(x => x.Id == Id).ToList();
        }

        public void Save()
        {
            _bankContext.SaveChanges();
        }
    }
}
