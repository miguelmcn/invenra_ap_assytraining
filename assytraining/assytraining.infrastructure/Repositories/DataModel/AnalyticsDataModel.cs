using System.Text.Json.Serialization;

namespace assytraining.infrastructure.Repositories.DataModel
{
    public record AnalyticsDataModel
    {
        [JsonPropertyName("inveniraStdID")]
        public string InvenIRAStudentID { get; set; }

        [JsonPropertyName("qualAnalytics")]
        public IEnumerable<AnalyticsConfigurationItemDataModel>? Qualitative { get; set; }

        [JsonPropertyName("quantAnalytics")]
        public IEnumerable<AnalyticsConfigurationItemDataModel>? Quantitative { get; set; }
    }
}
