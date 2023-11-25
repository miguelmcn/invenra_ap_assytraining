using System.Text.Json.Serialization;

namespace assytraining.api.ViewModel
{
    public class JsonParamItemViewModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
