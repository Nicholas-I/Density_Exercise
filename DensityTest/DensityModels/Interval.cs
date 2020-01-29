using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class Interval
    {
        [JsonProperty("start")]
        public System.DateTimeOffset start { get; set; }
        [JsonProperty("end")]
        public System.DateTimeOffset end { get; set; }
        [JsonProperty("analytics")]
        public Analytic analytics { get; set; }
    }
}
