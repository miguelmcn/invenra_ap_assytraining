using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.infrastructure.Repositories.Context;

namespace assytraining.infrastructure.Repositories
{
    public class AnalyticsConfigurationRepository<TDataModel> : IRepository<AnalyticsConfiguration>
        where TDataModel : class
    {
        public AnalyticsConfigurationRepository()
        {

        }

        public Task Delete(AnalyticsConfiguration dataModel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AnalyticsConfiguration>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<AnalyticsConfiguration> GetBy<TId>(TId id)
        {
            var datamodel = AnalyticsConfigurationContext.GetInstance().GetBy(typeof(AnalyticsConfiguration));

            return Task.FromResult(new AnalyticsConfiguration
            {
                Qualitative = datamodel?.Qualitative?.Select(u => new AnalyticsConfigurationItem { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = datamodel?.Quantitative?.Select(u => new AnalyticsConfigurationItem { Name = u.Name, Type = u.Type, Value = u.Value }),
            });
        }

        public Task<AnalyticsConfiguration> Save(AnalyticsConfiguration dataModel)
        {
            throw new NotImplementedException();
        }
    }
}
