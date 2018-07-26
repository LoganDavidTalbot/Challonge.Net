using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challonge.Net.Models
{
    public partial class MatchElement
    {
        [JsonProperty("match")]
        public Match Match { get; set; }
    }
}
