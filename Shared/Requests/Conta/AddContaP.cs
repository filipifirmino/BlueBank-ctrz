using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.Domain.Core;

namespace BlueBank.Domain.Shared.Requests.Conta
{
    class AddContaP
    {
        public void DepositoCP(Client client, double valorDeposito)
        {
            var idDeposito = new Guid();
            client.Account.Balance += valorDeposito;
        }

        public void SaqueCP(Client client, double valorSaque)
        {
            var idSaque = new Guid();
            try
            {
                if (client.Account.Balance >= valorSaque)
                {
                    client.Account.Balance -= valorSaque;
                }
            } catch
            {
                //DISPARAR EVENTO DE ERRO SE SALDO INDISPONIVEL
            }

        }




    }
}
