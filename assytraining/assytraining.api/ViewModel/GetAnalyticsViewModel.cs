using System.Text.Json.Serialization;

namespace assytraining.api.ViewModel
{
    public class GetAnalyticsViewModel
    {
        [JsonPropertyName("activityID")]
        public string ActivityID { get; set; }
    }
}
