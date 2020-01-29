using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class Count
    {
        [JsonProperty("timestamp")]
        public System.DateTimeOffset timestamp { get; set; }
        [JsonProperty("count")]
        public int? count { get; set; }
        [JsonProperty("interval")]
        public Interval interval { get; set; }
    }
}
