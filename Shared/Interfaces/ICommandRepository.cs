using BlueBank.Domain.Shared.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Shared.Interfaces
{
    public interface ICommandRepository<TEntity> where TEntity : Entity
    {
        TEntity GetById(Guid id);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        TEntity Update(TEntity entity);

        void Remove(TEntity entity);

        bool Exists(Expression<Func<TEntity, bool>> predicate);

        void Save();
    
    }

}
