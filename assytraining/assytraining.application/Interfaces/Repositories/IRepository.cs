using assytraining.application.Domain;

namespace assytraining.application.Interfaces.Repositories
{
    public interface IRepository<TDomainModel>
        where TDomainModel : IDomainModel
    {
        public Task<IEnumerable<TDomainModel>> GetAll();

        public Task<TDomainModel> GetBy<TId>(TId id);

        public Task<TDomainModel> Save(TDomainModel dataModel);

        public Task Delete(TDomainModel dataModel);
    }
}
