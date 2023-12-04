using assytraining.infrastructure.Repositories.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assytraining.infrastructure.Repositories.Context
{
    public class ConfigurationContext : IContext<ApplicationParamItemDataModel>
    {
        public void Delete(ApplicationParamItemDataModel dataModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationParamItemDataModel> GetAll()
        {
            return new List<ApplicationParamItemDataModel>()
            {
                 new ApplicationParamItemDataModel
                    {
                        Name = "resumo",
                        Type = "text/plain",
                    },
                    new ApplicationParamItemDataModel
                    {
                        Name = "instrucoes",
                        Type = "text/plain",
                    }
            };
        }

        public ApplicationParamItemDataModel GetBy<TId>(TId id)
        {
            throw new NotImplementedException();
        }

        public ApplicationParamItemDataModel Save(ApplicationParamItemDataModel dataModel)
        {
            throw new NotImplementedException();
        }
    }
}
