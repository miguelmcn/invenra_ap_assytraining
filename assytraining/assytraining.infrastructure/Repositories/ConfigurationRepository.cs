using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.infrastructure.Repositories.Context;

namespace assytraining.infrastructure.Repositories
{
    public class ConfigurationRepository<TDataModel> : IRepository<ApplicationParameterItem>
        where TDataModel : class
    {
        public ConfigurationRepository()
        {
        }

        public Task Delete(ApplicationParameterItem dataModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ApplicationParameterItem>> GetAll()
        {
            return (await ConfigurationContext.GetInstance().GetAll()).Select(u => new ApplicationParameterItem
            {
                Name = u.Name,
                Type = u.Type
            });
        }

        public Task<ApplicationParameterItem> GetBy<TId>(TId id)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationParameterItem> Save(ApplicationParameterItem dataModel)
        {
            throw new NotImplementedException();
        }
    }
}
