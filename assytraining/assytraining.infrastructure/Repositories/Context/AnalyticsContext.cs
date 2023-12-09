using assytraining.infrastructure.Repositories.DataModel;
using System.Security.Cryptography;

namespace assytraining.infrastructure.Repositories.Context
{
    internal class AnalyticsContext : IContext<AnalyticsDataModel>
    {
        private static AnalyticsContext? instance;

        private AnalyticsContext() { }

        public static AnalyticsContext GetInstance()
        {
            return instance ??= new AnalyticsContext();
        }

        public void Delete(AnalyticsDataModel dataModel)
        {
            
        }

        public IEnumerable<AnalyticsDataModel> GetAll()
        {
            return new List<AnalyticsDataModel>()
            {
                MockedData(Guid.NewGuid().ToString()),
                MockedData(Guid.NewGuid().ToString())
        };
        }

        public AnalyticsDataModel GetBy<TId>(TId id)
        {
            return MockedData(id);
        }
                
        public AnalyticsDataModel Save(AnalyticsDataModel dataModel)
        {
            return MockedData(Guid.NewGuid().ToString());
        }

        private static AnalyticsDataModel MockedData<TId>(TId id)
        {
            return new AnalyticsDataModel()
            {
                InvenIRAStudentID = id as string,
                Quantitative = new List<AnalyticsConfigurationItemDataModel>
                {
                    new()
                    {
                        Name = "failsPerPhase",
                        Type = "integer",
                        Value = 0
                    },
                    new()
                    {
                        Name = "failsPerCycle",
                        Type = "integer",
                        Value = 0
                    },
                    new()
                    {
                        Name = "failsTotal",
                        Type = "integer",
                        Value = 0
                    },
                    new()
                    {
                        Name = "timePerPhase",
                        Type = "integer",
                        Value = 20
                    },
                    new()
                    {
                        Name = "timePerCycle",
                        Type = "integer",
                        Value = 60
                    },
                    new()
                    {
                        Name = "timeTotal",
                        Type = "integer",
                        Value = 600
                    }
                }
            };
        }
    }
}
