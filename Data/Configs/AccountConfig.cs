using BlueBank.Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Configs
{
    class AccountConfig : ConfigEntitie<CC>
    {
        public override void Configure(EntityTypeBuilder<CC> builder)
        {
            base.Configure(builder);

            builder
                .Property(x => x.ClintId)
                .HasColumnName("ID_CLIENT");
        }
    }

    class AccountCpConfig : ConfigEntitie<CP>
    {
        public override void Configure(EntityTypeBuilder<CP> builder)
        {
            base.Configure(builder);

            builder
                .Property(x => x.ClientId)
                .HasColumnName("ID_CLIENT");
        }
    }
}
