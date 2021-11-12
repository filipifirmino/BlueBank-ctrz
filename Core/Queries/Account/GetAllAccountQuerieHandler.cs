using BlueBank.Domain.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Queries.Account
{
    public class GetAllAccountQuerieHandler
    {
        private readonly IAccountRepository _accountRepository;

        public GetAllAccountQuerieHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public List<Core.Account> GetAll()
        {
            return _accountRepository.GetAll();
        }
    }
}
