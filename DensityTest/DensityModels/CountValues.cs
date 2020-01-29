using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class CountValues
    {
        [JsonProperty("average")]
        public long? Average { get; set; }

        [JsonProperty("min")]
        public Peak Min { get; set; }

        [JsonProperty("max")]
        public Peak Max { get; set; }

        [JsonProperty("durations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Durations { get; set; }
    }
}
