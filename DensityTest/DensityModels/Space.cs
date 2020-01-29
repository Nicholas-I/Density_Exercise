using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class Space
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("notes")]
        public string notes { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("parent_id")]
        public string parentID { get; set; }
        [JsonProperty("ancestry")]
        public List<Ancestry> ancestry { get; set; }
        [JsonProperty("space_type")]
        public string spaceType { get; set; }
        [JsonProperty("function")]
        public string function { get; set; }
        [JsonProperty("time_zone")]
        public string timeZone { get; set; }
        [JsonProperty("technologies")]
        public List<string> technologies { get; set; }
        [JsonProperty("daily_reset")]
        public string dailyReset { get; set; }
        [JsonProperty("current_count")]
        public int? currentCount { get; set; }
        [JsonProperty("capacity")]
        public int? capacity { get; set; }
        [JsonProperty("created_at")]
        public System.DateTimeOffset createdAt { get; set; }
        [JsonProperty("doorways")]
        public List<Doorway> doorways { get; set; }
        [JsonProperty("tags")]
        public List<string> tags { get; set; }
        [JsonProperty("address")]
        public string address { get; set; }
        [JsonProperty("latitude")]
        public string latitude { get; set; }
        [JsonProperty("longitude")]
        public string longitude { get; set; }
        [JsonProperty("time_segments")]
        public List<TimeSegment> timeSegments { get; set; }
        [JsonProperty("time_segment_groups")]
        public List<string> timeSegmentGroups { get; set; }
    }
}
