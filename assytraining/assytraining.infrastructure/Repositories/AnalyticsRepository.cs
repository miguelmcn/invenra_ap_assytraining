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

        public async Task<IEnumerable<Analytics>> GetAll()
        {
            return (await AnalyticsContext.GetInstance().GetAll()).Select(u => new Analytics
            {
                InvenIRAStudentID = u.InvenIRAStudentID,
                Qualitative = u?.Qualitative?.Select(u => new AnalyticsConfigurationItem { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = u?.Quantitative?.Select(u => new AnalyticsConfigurationItem { Name = u.Name, Type = u.Type, Value = u.Value }),
            });
        }

        public async Task<Analytics> GetBy<TId>(TId id)
        {
            var datamodel = await AnalyticsContext.GetInstance().GetBy(id);

            return new Analytics
            {
                InvenIRAStudentID = datamodel.InvenIRAStudentID,
                Qualitative = datamodel?.Qualitative?.Select(u => new AnalyticsConfigurationItem { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = datamodel?.Quantitative?.Select(u => new AnalyticsConfigurationItem { Name = u.Name, Type = u.Type, Value = u.Value }),
            };
        }

        public async Task<Analytics> Save(Analytics domainModel)
        {
            var datamodel = new AnalyticsDataModel
            {
                InvenIRAStudentID = domainModel.InvenIRAStudentID,
                Qualitative = domainModel?.Qualitative?.Select(u => new AnalyticsConfigurationItemDataModel { Name = u.Name, Type = u.Type, Value = u.Value }),
                Quantitative = domainModel?.Quantitative?.Select(u => new AnalyticsConfigurationItemDataModel { Name = u.Name, Type = u.Type, Value = u.Value }),
            };

            var saved = await AnalyticsContext.GetInstance().Save(datamodel);

            return await GetBy(saved.InvenIRAStudentID);
        }
    }
}
