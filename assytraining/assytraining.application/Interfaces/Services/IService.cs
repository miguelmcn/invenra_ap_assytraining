using assytraining.application.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assytraining.application.Interfaces.Services
{
    public interface IService<TDomainModel> where TDomainModel : IDomainModel
    {
        public IEnumerable<TDomainModel> GetAll();

        public TDomainModel GetBy(string id);
    }
}
