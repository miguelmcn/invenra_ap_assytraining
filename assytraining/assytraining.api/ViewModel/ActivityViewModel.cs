using System.Text.Json.Serialization;

namespace assytraining.api.ViewModel
{
    public class ActivityViewModel
    {
        [JsonPropertyName("activityID")]
        public string ActivityID { get; set; }

        [JsonPropertyName("Inven!RAstdID")]
        public string IvenIRAStudentID { get; set; }

        [JsonPropertyName("json_params")]
        public Dictionary<string, string> Params { get; set; }

    }
}
