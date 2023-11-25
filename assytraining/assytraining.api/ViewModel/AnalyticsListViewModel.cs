using System.Text.Json.Serialization;

namespace assytraining.api.ViewModel
{
    public class AnalyticsListViewModel
    {        

        [JsonPropertyName("qualAnalytics")]
        public IEnumerable<AnalyticsItemViewModel> Qualitative { get; set; }

        [JsonPropertyName("quantAnalytics")]
        public IEnumerable<AnalyticsItemViewModel> Quantitative { get; set; }
    }

}
