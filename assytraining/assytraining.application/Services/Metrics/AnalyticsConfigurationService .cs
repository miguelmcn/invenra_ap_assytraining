using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;

namespace assytraining.application.Services.Metrics
{
    public class AnalyticsConfigurationService(IRepository<AnalyticsConfiguration> repository) : IService<AnalyticsConfiguration>
    {
        private readonly IRepository<AnalyticsConfiguration> _repository = repository;

        public Task<IEnumerable<AnalyticsConfiguration>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<AnalyticsConfiguration> GetBy(string id)
        {
            return _repository.GetBy(typeof(AnalyticsConfiguration));
        }

        public Task<AnalyticsConfiguration> Save(AnalyticsConfiguration domainModel)
        {
            return _repository.Save(domainModel);
        }
    }
}
