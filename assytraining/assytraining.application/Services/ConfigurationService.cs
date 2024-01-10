using assytraining.application.Domain;
using assytraining.application.Interfaces.Repositories;

namespace assytraining.application.Services
{
    public class ConfigurationService(IRepository<ApplicationParameterItem> repository) : BaseService<ApplicationParameterItem>(repository)
    {
        private readonly IRepository<ApplicationParameterItem> _repository = repository;
        
        public override Task<IEnumerable<ApplicationParameterItem>> GetAll()
        {
            return _repository.GetAll();
        }

        public override Task<ApplicationParameterItem> GetBy(string id)
        {
            throw new NotImplementedException();
        }

        public override Task Validate(ApplicationParameterItem domainModel)
        {
            throw new NotImplementedException();
        }
    }
}
