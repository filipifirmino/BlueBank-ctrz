using BlueBank.Domain.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Queries.Account
{
    public class GetAccountByIdQuerieHandler
    {
        private readonly IAccountRepository _accountRepository;

        public GetAccountByIdQuerieHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Core.Account GetById(Guid id)
        {
            return _accountRepository.GetById(id);
        }


    }
}
