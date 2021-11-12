using BlueBank.Domain.Core;
using BlueBank.Domain.Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Data.Repositorys
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly BankContext _bankContext;

        public TransactionRepository(BankContext contexto)
        {
            _bankContext = contexto;
        }

        public Guid Deposit(Guid accountId, double value)
        {
            var deposit = new Transaction(accountId, value);
            
            _bankContext.Transactions.Add(deposit);
            return accountId;
        }

        public Transaction Transfer(Guid accountId, double value, Guid destidestinyClientId )
        {
            var transfer = new Transaction(accountId, value, destidestinyClientId);
            _bankContext.Transactions.Add(transfer);
            return transfer;
        }

        public Transaction Withdraw(Guid accountId, double value)
        {
            var withdraw = new Transaction(accountId, value);
            _bankContext.Transactions.Add(withdraw);
            return withdraw;
        }

        public void Save()
        {
            _bankContext.SaveChanges();
        }

    }
}
