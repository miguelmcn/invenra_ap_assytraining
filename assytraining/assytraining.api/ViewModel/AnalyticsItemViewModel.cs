using System.Text.Json.Serialization;

namespace assytraining.api.ViewModel
{
    public class AnalyticsItemViewModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public dynamic Value { get; set; }
    }
}
