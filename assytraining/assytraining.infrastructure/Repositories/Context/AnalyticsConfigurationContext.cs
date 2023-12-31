﻿using assytraining.infrastructure.Repositories.DataModel;

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

        public Task Delete(AnalyticsConfigurationDataModel dataModel)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AnalyticsConfigurationDataModel>> GetAll()
        {
            return new AnalyticsConfigurationDataModel[]
            {
                await GetBy<string>(string.Empty)
            };
        }

        public Task<AnalyticsConfigurationDataModel> GetBy<TId>(TId id)
        {
            return Task.Run(() =>
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
            });
        }

        public Task<AnalyticsConfigurationDataModel> Save(AnalyticsConfigurationDataModel dataModel)
        {
            throw new NotImplementedException();
        }
    }
}
