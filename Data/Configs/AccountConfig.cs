using BlueBank.Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueBank.Infra.Data.Configs
{
    class AccountConfig : EntityConfig<Account> 
    {
        public override void Configure(EntityTypeBuilder<Account> builder)
        {
            base.Configure(builder);
           
            builder
                .Property(x => x.Balance)
                .HasColumnName("VL_BALANCE");

            builder
                .Property(x => x.Status)
                .HasColumnName("ST_STATUS");

            builder
                .Property(x => x.Type)
                .HasColumnName("ST_TYPE");


        }

    }
}
