using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;

namespace assytraining.application.Services
{
    public abstract class BaseService<TDomainModel>(IRepository<TDomainModel> repository) : IService<TDomainModel>  where TDomainModel : IDomainModel
    {
        protected readonly IRepository<TDomainModel> _repository = repository;

        public abstract Task<IEnumerable<TDomainModel>> GetAll();

        public abstract Task<TDomainModel> GetBy(string id);

        public async Task<TDomainModel> Save(TDomainModel domainModel)
        {
            await Validate(domainModel);

            return await _repository.Save(domainModel);
        }

        public abstract Task Validate(TDomainModel domainModel);
    }
}
