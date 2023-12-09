using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;
using assytraining.application.Interfaces.Services;

namespace assytraining.application.Services
{
    public class ConfigurationService(IRepository<ApplicationParameterItem> repository) : IService<ApplicationParameterItem>
    {
        private readonly IRepository<ApplicationParameterItem> _repository = repository;
        
        public Task<IEnumerable<ApplicationParameterItem>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<ApplicationParameterItem> GetBy(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationParameterItem> Save(ApplicationParameterItem domainModel)
        {
            throw new NotImplementedException();
        }
    }
}
