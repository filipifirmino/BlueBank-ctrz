using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Requestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Command.Transaction
{
    public class TransferCommandHandler
    {
        private readonly ITransactionRepository _itransactionRepository;

        public TransferCommandHandler(ITransactionRepository repository)
        {
            _itransactionRepository = repository;
        }

        public void Transfer(TransactionTransferRequest request)
        {
            _itransactionRepository.Transfer(request.AccountId, request.Value, request.AccountDestinyId);
            _itransactionRepository.Save();
        }
    }
}
