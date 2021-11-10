using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Interface
{
    public interface IClientRepository
    {
        public List<Client> GetAll();

        public Client GetById(Guid id);

        public void Add(Client client);

        public void Save();

    }
}
