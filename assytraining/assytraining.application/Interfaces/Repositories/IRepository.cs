using assytraining.application.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assytraining.application.Interfaces.Repositories
{
    public interface IRepository<TDomainModel>
        where TDomainModel : IDomainModel
    {
        public IEnumerable<TDomainModel> GetAll();

        public TDomainModel GetBy<TId>(TId id);

        public TDomainModel Save(TDomainModel dataModel);

        public void Delete(TDomainModel dataModel);
    }
}
