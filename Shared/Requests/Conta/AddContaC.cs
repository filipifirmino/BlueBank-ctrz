using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.Domain.Core;

namespace BlueBank.Domain.Shared.Requests.Conta
{
    class AddContaC
    {
        public void DepositoCC(Client client, double valorDeposito)
        {
            var idDeposito = new Guid();
            client.Account.Balance += valorDeposito;
        }

        public void SaqueCC(Client client, double valorSaque)
        {
            var idSaque = new Guid();
            try
            {
                if (client.Account.Balance >= valorSaque)
                {
                    client.Account.Balance -= valorSaque;
                }
            }
            catch
            {
                //DISPARAR EVENTO DE ERRO SE SALDO INDISPONIVEL
            }
        }

        public void TransferenciaCC(Client client, double valorTransferencia, Client clientDestino)
        {
            var idTransferencia = new Guid();
            
            try
            {
                if (client.Account.Balance >= valorTransferencia)
                {
                    client.Account.Balance -= valorTransferencia;
                    clientDestino.Account.Balance += valorTransferencia;
                }
            }
            catch
            {
                //DISPARAR EVENTO DE ERRO SE SALDO INDISPONIVEL
            }
        }
    }
}
