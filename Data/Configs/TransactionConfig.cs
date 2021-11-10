using BlueBank.Domain.Core;
using BlueBank.Infra.Data.Configs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Infra.Data.Configs
{
    public class TransactionConfig : EntityConfig<Transaction>
    {
        public override void Configure(EntityTypeBuilder<Transaction> builder)
        {
            base.Configure(builder);

            builder
                .Property(x => x.Value)
                .HasColumnName("VL_VALUE");

            builder
                .Property(x => x.DestinyClient)
                .HasColumnName("NM_CLIENT");

            builder
                .Property(x => x.AccountId)
                .HasColumnName("ID_ACCOUNT");
        }
    }
}
