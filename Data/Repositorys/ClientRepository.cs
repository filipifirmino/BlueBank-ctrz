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
    public class ClientRepository : IClientRepository
    {
        private readonly BankContext _bankContext;

        public ClientRepository(BankContext context)
        {
            _bankContext = context;
        }
        
        public List<Client> GetAll()
        {
            return _bankContext.Clients.AsNoTracking().AsQueryable().ToList();
        }

        public Client GetById(Guid id)
        {
            return _bankContext.Clients.AsNoTracking().Single(c => c.Id == id);
        }

        public void Add(Client client)
        {
            _bankContext.Add(client);
        }

        public void Save()
        {
            _bankContext.SaveChanges();
        }

    }
}
