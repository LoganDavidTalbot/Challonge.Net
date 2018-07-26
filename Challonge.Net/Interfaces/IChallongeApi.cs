using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challonge.Net.Interfaces
{
    public partial interface IChallongeApi : System.IDisposable
    {
        /// <summary>
        /// The API Key of the service.
        /// </summary>
        string ApiKey { get; set; }
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Gets the ITournaments.
        /// </summary>
        ITournaments Tournaments { get; }
    }
}
