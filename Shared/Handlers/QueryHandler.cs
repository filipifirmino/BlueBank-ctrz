using BlueBank.Domain.Shared.Entitie;
using BlueBank.Domain.Shared.Interfaces;

namespace BlueBank.Domain.Shared.Handlers
{
    public abstract class QueryHandler<TEntity, TRequest, TResponse>
        where TEntity : Entity
    {
        protected readonly IQueryRepository<TEntity> _repository;

        public QueryHandler(IQueryRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public abstract TResponse Handle(TRequest request);
    }
}
