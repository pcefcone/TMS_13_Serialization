using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_13_Serialization.Models
{
    public class Currency
    {
        [Newtonsoft.Json.JsonProperty("name")]
        public string name { get; set; }
        [Newtonsoft.Json.JsonProperty("age")]
        public int age { get; set; }
        [Newtonsoft.Json.JsonProperty("city")]
        public string city { get; set; }
    }
}
