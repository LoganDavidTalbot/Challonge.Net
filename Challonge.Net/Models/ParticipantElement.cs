using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challonge.Net.Models
{
    public partial class ParticipantElement
    {
        [JsonProperty("participant")]
        public Participant Participant { get; set; }
    }
}
