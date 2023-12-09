using System.Text.Json.Serialization;

namespace assytraining.infrastructure.Repositories.DataModel
{
    public record ActivityDataModel
    {
        [JsonPropertyName("activityID")]
        public string ActivityID { get; set; }

        [JsonPropertyName("InvenRAstdID")]
        public string IvenIRAStudentID { get; set; }

        [JsonPropertyName("json_params")]
        public Dictionary<string, string> Params { get; set; }
    }
}
