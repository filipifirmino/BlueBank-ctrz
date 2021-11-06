using BlueBank.Domain.Shared;
using Data.Configs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Data.Configs
{
    class ClientConfig : ConfigClient<Client>
    {
        public override void Configure(EntityTypeBuilder<Client> builder)
        {
            base.Configure(builder);

            builder
                .Property(x => x.AccountId)
                .HasColumnName("ID_ACCOUNT");

           // builder
           //     .HasOne(x => x.Account)
           //     .WithOne(x => x.Client);
        }
    }
}
