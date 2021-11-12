using BlueBank.Domain.Core;
using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorys
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankContext _bankcontext;

        public AccountRepository(BankContext context)
        {
            _bankcontext = context;
        }
        public void Add(Account account)
        {
           _bankcontext.Add(account);
        }

        public List<Account> GetAll()
        {
            var result = _bankcontext.Accounts.AsNoTracking().AsQueryable().ToList();
            return result;
        }

        public Account GetById(Guid Id)
        {
            return _bankcontext.Accounts.AsNoTracking().Single(a => a.Id == Id);
        }

        public void Remove(Account account)
        {
            _bankcontext.Accounts.Remove(account);
        }

        public void Save()
        {
            _bankcontext.SaveChanges();
        }
    }
}
