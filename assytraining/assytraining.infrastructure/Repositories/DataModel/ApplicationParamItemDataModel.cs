﻿using System.Text.Json.Serialization;

namespace assytraining.infrastructure.Repositories.DataModel
{
    public record ApplicationParamItemDataModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
