using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class TimeSegment
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("label")]
        public string label { get; set; }
        [JsonProperty("start")]
        public string start { get; set; }
        [JsonProperty("end")]
        public string end { get; set; }
        [JsonProperty("days")]
        public List<string> days { get; set; }
    }
}
