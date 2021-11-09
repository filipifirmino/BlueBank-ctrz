using BlueBank.Domain.Shared.Entitie;
using BlueBank.Domain.Shared.Interfaces;
using BlueBank.Domain.Shared.Responses;
using FluentValidation;
using System;
using System.Linq;


namespace BlueBank.Domain.Shared.Handlers
{
    public abstract class CommandHandler<TEntity, TRequest, TResponse>
       where TEntity : Entity
       where TResponse : Response
    {
        protected readonly ICommandRepository<TEntity> _repository;

        public abstract IValidator<TRequest> Validator { get; }

        protected TResponse _response { get; }

        public CommandHandler(ICommandRepository<TEntity> repository)
        {
            _repository = repository;

            _response = Activator.CreateInstance<TResponse>();
        }

        private void ValidateRequest(TRequest request)
        {
            var errors = Validator.Validate(request).Errors;

            _response.SetErrorList(errors);
        }

        public TResponse Handle(TRequest request)
        {
            ValidateRequest(request);

            if (_response.Errors.Any()) return _response;

            BeforeChanges(request);

            if (_response.Errors.Any()) return _response;

            var entidade = Changes(request);

            _repository.Save();

            return AfterChanges(request, entidade);
        }


        protected abstract void BeforeChanges(TRequest request);

        protected abstract TEntity Changes(TRequest request);

        protected abstract TResponse AfterChanges(TRequest request, TEntity entidade);
    }
}
