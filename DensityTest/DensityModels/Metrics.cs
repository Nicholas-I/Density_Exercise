using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class Metrics
    {
        [JsonProperty("entrances")]
        public Entrances Entrances { get; set; }

        [JsonProperty("exits")]
        public Entrances Exits { get; set; }

        [JsonProperty("count")]
        public CountValues Count { get; set; }

        [JsonProperty("target_utilization")]
        public CountValues TargetUtilization { get; set; }
    }
}
