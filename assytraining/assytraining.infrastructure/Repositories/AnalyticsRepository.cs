using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.infrastructure.Repositories.Context;
using assytraining.infrastructure.Repositories.DataModel;

namespace assytraining.infrastructure.Repositories
{
    public class AnalyticsRepository<TDataModel> : IRepository<Analytics>
        where TDataModel : class
    {
        public AnalyticsRepository()
        {

        }

        public Task Delete(Analytics domainModel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Analytics>> GetAll()
        {
            return Task.FromResult(AnalyticsContext.GetInstance().GetAll().Select(u => new Analytics
            {
                InvenIRAStudentID = u.InvenIRAStudentID,
                Qualitative = u?.Qualitative?.Select(u => new AnalyticsConfigurationItem { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = u?.Quantitative?.Select(u => new AnalyticsConfigurationItem { Name = u.Name, Type = u.Type, Value = u.Value }),
            }
            ));
        }

        public Task<Analytics> GetBy<TId>(TId id)
        {
            var datamodel = AnalyticsContext.GetInstance().GetBy(id);

            return Task.FromResult(new Analytics
            {
                InvenIRAStudentID = datamodel.InvenIRAStudentID,
                Qualitative = datamodel?.Qualitative?.Select(u => new AnalyticsConfigurationItem { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = datamodel?.Quantitative?.Select(u => new AnalyticsConfigurationItem { Name = u.Name, Type = u.Type, Value = u.Value }),
            });
        }

        public async Task<Analytics> Save(Analytics domainModel)
        {
            var datamodel = new AnalyticsDataModel
            {
                InvenIRAStudentID = domainModel.InvenIRAStudentID,
                Qualitative = domainModel?.Qualitative?.Select(u => new AnalyticsConfigurationItemDataModel { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = domainModel?.Quantitative?.Select(u => new AnalyticsConfigurationItemDataModel { Name = u.Name, Type = u.Type, Value = u.Value }),
            };

            var saved = AnalyticsContext.GetInstance().Save(datamodel);

            return await GetBy(saved.InvenIRAStudentID);
        }
    }
}
