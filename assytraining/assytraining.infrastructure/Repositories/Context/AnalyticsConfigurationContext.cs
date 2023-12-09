using assytraining.infrastructure.Repositories.DataModel;

namespace assytraining.infrastructure.Repositories.Context
{
    internal class AnalyticsConfigurationContext : IContext<AnalyticsConfigurationDataModel>
    {
        private static AnalyticsConfigurationContext? instance;

        private AnalyticsConfigurationContext() { }

        public static AnalyticsConfigurationContext GetInstance()
        {
            return instance ??= new AnalyticsConfigurationContext();
        }

        public void Delete(AnalyticsConfigurationDataModel dataModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AnalyticsConfigurationDataModel> GetAll()
        {
            return new AnalyticsConfigurationDataModel[]
            {
                GetBy<string>(string.Empty)
            };
        }

        public AnalyticsConfigurationDataModel GetBy<TId>(TId id)
        {
            return new AnalyticsConfigurationDataModel()
            {
                Quantitative = new List<AnalyticsConfigurationItemDataModel>
                {
                    new()
                    {
                        Name = "failsPerPhase",
                        Type = "integer"
                    },
                    new()
                    {
                        Name = "failsPerCycle",
                        Type = "integer"
                    },
                    new()
                    {
                        Name = "failsTotal",
                        Type = "integer"
                    },
                    new()
                    {
                        Name = "timePerPhase",
                        Type = "integer"
                    },
                    new()
                    {
                        Name = "timePerCycle",
                        Type = "integer"
                    },
                    new()
                    {
                        Name = "timeTotal",
                        Type = "integer"
                    }
                }
            };
        }

        public AnalyticsConfigurationDataModel Save(AnalyticsConfigurationDataModel dataModel)
        {
            throw new NotImplementedException();
        }
    }
}
