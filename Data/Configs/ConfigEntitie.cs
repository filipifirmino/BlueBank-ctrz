using BlueBank.Domain.Core;
using BlueBank.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bluebank.Data.Configs
{
    abstract class ConfigEntitie<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Account
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("ID");

            builder
                .Property(x => x.CreatedAt)
                .HasColumnName("DT_CREATED");

            builder
                .Property(x => x.UpdatedAt)
                .HasColumnName("DT_UPDATED");

            builder
                .Property(x => x.Balance)
                .HasColumnName("ST_BALANCE");

            builder
                .Property(x => x.Status)
                .HasColumnName("ST_STATUS");

        }
    }
}
