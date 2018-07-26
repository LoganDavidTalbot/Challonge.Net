using Challonge.Net.Models;
using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challonge.Net.Interfaces
{
    public partial interface ITournaments
    {
        Task<HttpOperationResponse<IList<Models.TournamentElement>>> GetTournamentAllWithHttpMessagesAsync(string state = default(string), string type = default(string), DateTime createdAfter = default(DateTime), DateTime createdBefore = default(DateTime), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        Task<HttpOperationResponse<Models.TournamentElement>> GetTournamentWithHttpMessagesAsync(string id, bool includeParticipants = false, bool includeMatches = false, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        Task<HttpOperationResponse<Models.TournamentElement>> PostTournamentWithHttpMessagesAsync(CreateTournament tournament, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
