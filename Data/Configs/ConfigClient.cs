using BlueBank.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configs
{
    abstract class ConfigClient<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Client
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("ID");

            builder
                .Property(x => x.Name)
                .HasColumnName("ST_NAME");

            builder
                .Property(x => x.Phone)
                .HasColumnName("ST_PHONE");

            builder
                .Property(x => x.Cpf)
                .HasColumnName("ST_CPF");

            //builder
            //    .Property(x => x.Account)
            //    .HasColumnName("DT_ACCOUNT");

            builder
                .Property(x => x.AccountId)
                .HasColumnName("ID_ACCOUNT");

        }
    }
}
