using BlueBank.Domain.Core;
using System;

namespace BlueBank.Domain.Shared.Requests
{
    public class AddClient
    {
        public void AddClientCc(Client client)
        {
            var id = new Guid();
            var Account = new CC(id, 0.0, true, client);

            // falta add metodo para salvar no BD
            // falta add metodo validação de dados
        }

        public void AddClientCp(Client client)
        {
            var id = new Guid();
            var Account = new CP(id, 0.0, true, client);

            // falta add metodo para salvar no BD
            // falta add metodo validação de dados
        }
    }
}