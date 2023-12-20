using assytraining.infrastructure.Infrastructure.Data;
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

        public Task Delete(ApplicationParamItemDataModel dataModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ApplicationParamItemDataModel>> GetAll()
        {
            var configs = await TableStorageFacade.GetInstance().GetData("PartitionKey eq 'Configuration'");
            return configs.Select(config => new ApplicationParamItemDataModel() { Name = config.Key, Type = config.Value });
        }

        public Task<ApplicationParamItemDataModel> GetBy<TId>(TId id)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationParamItemDataModel> Save(ApplicationParamItemDataModel dataModel)
        {
            throw new NotImplementedException();
        }
    }
}
