namespace Challonge.Net.Models
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    public partial class TournamentElement
    {
        [JsonProperty("tournament")]
        public Tournament Tournament { get; set; }
    }
}
