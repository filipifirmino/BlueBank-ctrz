using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Interface
{
    public interface IAccountRepository
    {
        public Account GetById(Guid id);

        public List<Account> GetAll();

        public void Add(Account account);

        public void Remove(Account account);

        public void Save();
    }
}
