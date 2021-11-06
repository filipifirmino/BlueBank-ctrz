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
                .Property(x => x.ClientId)
                .HasColumnName("ID_CLIENT");

            //builder
            //    .HasOne(x => x.Client)
            //    .WithOne(x => (CC)x.Account)
            //    .OnDelete(DeleteBehavior.NoAction);
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
            //builder
            //.HasOne(x => x.Client)
            //.WithOne(x => (CP)x.Account)
            //.OnDelete(DeleteBehavior.NoAction);
        }
    }
}
