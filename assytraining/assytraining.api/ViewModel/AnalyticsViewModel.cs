using System.Text.Json.Serialization;

namespace assytraining.api.ViewModel
{
    public class AnalyticsViewModel
    {
        [JsonPropertyName("inveniraStdID")]
        public string InvenIRAStudentID { get; set; }

        [JsonPropertyName("qualAnalytics")]
        public IEnumerable<AnalyticsItemViewModel> Qualitative { get; set; }

        [JsonPropertyName("quantAnalytics")]
        public IEnumerable<AnalyticsItemViewModel> Quantitative { get; set; }
    }
}
