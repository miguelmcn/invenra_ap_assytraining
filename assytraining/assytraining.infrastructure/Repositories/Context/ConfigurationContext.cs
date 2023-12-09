using assytraining.infrastructure.Repositories.DataModel;

namespace assytraining.infrastructure.Repositories.Context
{
    internal class ConfigurationContext : IContext<ApplicationParamItemDataModel>
    {
        private static ConfigurationContext? instance;

        private ConfigurationContext() { }

        public static ConfigurationContext GetInstance()
        {
            return instance ??= new ConfigurationContext();
        }

        public void Delete(ApplicationParamItemDataModel dataModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationParamItemDataModel> GetAll()
        {
            return new List<ApplicationParamItemDataModel>()
            {
                new ()
                {
                    Name = "Resumo",
                    Type = "text/plain",
                },
                new ()
                {
                    Name = "Veículo",
                    Type = "text/plain",
                },
                new ()
                {
                    Name = "Veículo",
                    Type = "text/plain",
                },
                new ()
                {
                    Name = "Cíclos por Atividade",
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
