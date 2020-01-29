using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class Doorway
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("link_id")]
        public string linkID { get; set; }
        [JsonProperty("sensor_placement")]
        public int? sensorePlacement { get; set; }
    }
}
