using System.Text.Json.Serialization;

namespace assytraining.infrastructure.Repositories.DataModel
{
    public record AnalyticsConfigurationDataModel
    {        

        [JsonPropertyName("qualAnalytics")]
        public IEnumerable<AnalyticsConfigurationItemDataModel> Qualitative { get; set; }

        [JsonPropertyName("quantAnalytics")]
        public IEnumerable<AnalyticsConfigurationItemDataModel> Quantitative { get; set; }
    }

}
