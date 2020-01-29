using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class Analytic
    {
        [JsonProperty("min")]
        public long min { get; set; }
        [JsonProperty("max")]
        public long max { get; set; }
        [JsonProperty("events")]
        public long events { get; set; }
        [JsonProperty("entrances")]
        public long entrances { get; set; }
        [JsonProperty("exits")]
        public long exits { get; set; }
        [JsonProperty("utilization")]
        public long utilization { get; set; }
        [JsonProperty("target_utilization")]
        public long targetUtilization { get; set; }
        [JsonProperty("entry_rate")]
        public long entryRate { get; set; }
        [JsonProperty("exit_rate")]
        public long exitRate { get; set; }
    }
}
