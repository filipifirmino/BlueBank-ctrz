using BlueBank.Domain.Shared.Entitie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlueBank.Infra.Data.Configs
{
    public abstract class EntityConfig<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
    {
      
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("ID");
        }
        

    }
}
