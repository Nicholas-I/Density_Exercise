using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class CountResult
    {
        [JsonProperty("total")]
        public long total { get; set; }
        [JsonProperty("next")]
        public string next { get; set; }
        [JsonProperty("previous")]
        public string previous { get; set; }
        [JsonProperty("metrics")]
        public Metrics metrics { get; set; }
        [JsonProperty("results")]
        public List<Count> results { get; set; }
    }
}
