using assytraining.api.ViewModel;

namespace assytraining.api
{
    public class InvenRAMockService
    {
        public AnalyticsListViewModel GetAnalyticsListViewModel()
        {
            return new AnalyticsListViewModel()
            {
                Qualitative = new List<AnalyticsItemViewModel>()
                {
                    new AnalyticsItemViewModel(){
                        Name = "Analytic 1",
                        Type = "text/plain"
                    },
                    new AnalyticsItemViewModel(){
                        Name = "Analytic 2",
                        Type = "URL"
                    }
                },
                Quantitative = new List<AnalyticsItemViewModel>
                {
                    new AnalyticsItemViewModel() {
                        Name = "Analytic 3",
                        Type = "boolean"
                    },
                    new AnalyticsItemViewModel() {
                        Name = "Analytic 4",
                        Type = "integer"
                    }
                }
            };
        }

        public AnalyticsViewModel GetAnalyticsViewModel()
        {
            return new AnalyticsViewModel()
            {
                InvenIRAStudentID = Guid.NewGuid().ToString(),
                Qualitative = new List<AnalyticsItemViewModel>()
                {
                    new AnalyticsItemViewModel(){
                        Name = "Analytic 1",
                        Type = "text/plain",
                        Value = "1"
                    },
                    new AnalyticsItemViewModel(){
                        Name = "Analytic 2",
                        Type = "URL",
                        Value = "http://<endereço>/1001"
                    }
                },
                Quantitative = new List<AnalyticsItemViewModel>
                {
                    new AnalyticsItemViewModel() {
                        Name = "Analytic 3",
                        Type = "boolean",
                        Value = true
                    },
                    new AnalyticsItemViewModel() {
                        Name = "Analytic 4",
                        Type = "integer",
                        Value = 1
                    }
                }
            };
        }

        public ConfigurationsViewModel GetConfigurationsViewModel()
        {
            return new ConfigurationsViewModel()
            {

            };
        }

        public List<JsonParamItemViewModel> GetJsonParamViewModel()
        {
            return new List<JsonParamItemViewModel>()
                {
                    new JsonParamItemViewModel
                    {
                        Name = "resumo",
                        Type = "text/plain",
                    },
                    new JsonParamItemViewModel
                    {
                        Name = "instrucoes",
                        Type = "text/plain",
                    }
                };

        }

        public ActivityViewModel GetUserViewModel()
        {
            return new ActivityViewModel()
            {

            };
        }
    }
}
