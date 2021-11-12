
using System;
using System.Collections.Generic;
using System.Linq;
using BlueBank.Domain.Core;
using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Data;
using Microsoft.EntityFrameworkCore;

namespace BlueBank.Infra.Data.Repositorys
{
    public class HistoryRepository : IHistoryRepository
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
            var result = _bankContext.Transactions.AsNoTracking().Where(x => x.AccountId == Id).ToList();
            return result;
        }

        public void Save()
        {
            _bankContext.SaveChanges();
        }
    }
}
