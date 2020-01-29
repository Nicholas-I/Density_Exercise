using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DensityTest.DensityModels
{
    public class Ancestry : IEquatable<Ancestry>
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("id")]
        public string id { get; set; }

        public bool Equals(Ancestry other)
        {
            if (this.name == other.name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
