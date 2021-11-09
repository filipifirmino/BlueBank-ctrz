using BlueBank.Domain.Core;
using BlueBank.Domain.Shared.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueBank.Infra.Data.Configs
{
    public  class ClientConfig : EntityConfig<Client> 
    {
        public override void Configure(EntityTypeBuilder<Client> builder)
        {
            base.Configure(builder);
                     

            builder
                .Property(x => x.Name)
                .HasColumnName("ST_NAME");

            builder
                .Property(x => x.Phone)
                .HasColumnName("ST_PHONE");

            builder
                .Property(x => x.Cpf)
                .HasColumnName("ST_CPF");
            
            builder
               .Property(x => x.Address)
               .HasColumnName("DT_ADDRESS")
               .HasConversion(
                    address => address.FullAddress,
                    valueOfDataBase => new Address(valueOfDataBase)
                );

            builder
                .Property(x => x.AccountId)
                .HasColumnName("ID_ACCOUNT");

            builder
                .HasOne(c => c.Account)
                .WithOne(a => a.Client)
                .HasForeignKey<Account>(c => c.ClientId);

        }
    }
}
