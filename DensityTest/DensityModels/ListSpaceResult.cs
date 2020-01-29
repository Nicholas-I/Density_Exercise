using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DensityTest.DensityModels
{
    public class ListSpaceResult
    {
        [JsonProperty("total")]
        public long total { get; set; }
        [JsonProperty("next")]
        public string next { get; set; }
        [JsonProperty("previous")]
        public string previous { get; set; }
        [JsonProperty("results")]
        public List<Space> results { get; set; }
    }
}
