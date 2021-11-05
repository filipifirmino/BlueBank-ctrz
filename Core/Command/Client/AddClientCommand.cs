using BlueBank.Domain.Core;
using System;

namespace BlueBank.Domain.Shared.Requests
{
    public class AddClientCommand
    {
        public void AddClient()
        {
            var client = new Client();
            var account = new Account();

            // falta add metodo para salvar no BD
            // falta add metodo validação de dados
        }

    }
}