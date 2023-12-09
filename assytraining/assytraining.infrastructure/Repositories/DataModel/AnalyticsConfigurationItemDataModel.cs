using System.Text.Json.Serialization;

namespace assytraining.infrastructure.Repositories.DataModel
{
    public record AnalyticsConfigurationItemDataModel
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
