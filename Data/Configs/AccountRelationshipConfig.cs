using Bluebank.Data.Configs;
using BlueBank.Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace BlueBanck.Data.Configs
{
    class AccountRelationshipConfig : ConfigAccount<Account>
    {
        public override void Configure(EntityTypeBuilder<Account> builder)
        {
            base.Configure(builder);

            builder
                .Property(x => x.ClientId)
                .HasColumnName("ID_CLIENT");

            builder
                .HasOne(x => x.Client)
                .WithOne(x => x.Account)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
