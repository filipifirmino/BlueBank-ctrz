using BlueBank.Domain.Core;
using BlueBank.Domain.Core.Interface;
using System;

namespace BlueBank.Domain.Shared.Requests.Conta
{
    public class UpdateAccountCommandHandler
    {
        private readonly IAccountRepository _accountrepository;

        public UpdateAccountCommandHandler(IAccountRepository repository)
        {
            _accountrepository = repository;

        }

        public void Deposit(Client client, double depositValue)
        {
            var transaction = new Transaction();

            client.Account.Balance += depositValue;
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
