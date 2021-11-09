using BlueBank.Domain.Core;
using Data.Configs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueBank.Domain.Data.Configs
{
    class ClientRelationshipConfig : ConfigClient<Client>
    {
        public override void Configure(EntityTypeBuilder<Client> builder)
        {
            base.Configure(builder);

            builder
                .Property(x => x.AccountId)
                .HasColumnName("ID_ACCOUNT");

             builder
                .HasOne(x => x.Account)
                .WithOne(x => x.Client);
        }
    }
}
