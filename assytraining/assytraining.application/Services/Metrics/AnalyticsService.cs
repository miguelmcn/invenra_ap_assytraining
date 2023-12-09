using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;

namespace assytraining.application.Services.Metrics
{
    public class AnalyticsService(IRepository<Analytics> repository) : IService<Analytics>
    {
        private readonly IRepository<Analytics> _repository = repository;

        public Task<IEnumerable<Analytics>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<Analytics> GetBy(string id)
        {
            return _repository.GetBy(id);
        }

        public Task<Analytics> Save(Analytics domainModel)
        {
            return _repository.Save(domainModel);
        }
    }
}
