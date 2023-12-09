using assytraining.application.Domain;

namespace assytraining.application.Interfaces.Services
{
    public interface IService<TDomainModel> where TDomainModel : IDomainModel
    {
        public Task<IEnumerable<TDomainModel>> GetAll();

        public Task<TDomainModel> GetBy(string id);
        public Task<TDomainModel> Save(TDomainModel domainModel);
    }
}
