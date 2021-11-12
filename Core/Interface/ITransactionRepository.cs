using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Interface
{
    public interface ITransactionRepository
    {
        public Transaction Withdraw(Guid accountId, double value);
        public Guid Deposit(Guid accountId, double value);
        public Transaction Transfer(Guid accountId, double value, Guid destidestinyClientId);
        public void Save();

    }
}
