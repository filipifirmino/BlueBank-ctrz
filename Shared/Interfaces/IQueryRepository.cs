using BlueBank.Domain.Shared.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Shared.Interfaces
{
    public interface IQueryRepository<TEntity> where TEntity : Entity
    {
        TEntity GetById(Guid id);

        IQueryable<TEntity> Get();

        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

    }
}
