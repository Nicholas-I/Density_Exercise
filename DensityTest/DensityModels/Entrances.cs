using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class Entrances
    {
        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("average")]
        public long Average { get; set; }

        [JsonProperty("peak")]
        public Peak Peak { get; set; }
    }
}
