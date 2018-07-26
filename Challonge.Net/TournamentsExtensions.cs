using Challonge.Net.Interfaces;
using Challonge.Net.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challonge.Net
{
    public static partial class TournamentsExtensions
    {
        public static IList<Models.TournamentElement> GetTournamentAll(this ITournaments operations, string state = default(string), string type = default(string), DateTime createdAfter = default(DateTime), DateTime createdBefore = default(DateTime))
        {
            return operations.GetTournamentAllAsync(state, type, createdAfter, createdBefore).GetAwaiter().GetResult();
        }

        public static async Task<IList<Models.TournamentElement>> GetTournamentAllAsync(this ITournaments operations, string state = default(string), string type = default(string), DateTime createdAfter = default(DateTime), DateTime createdBefore = default(DateTime), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetTournamentAllWithHttpMessagesAsync(state, type, createdAfter, createdBefore, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        public static Models.TournamentElement GetTournament(this ITournaments operations, string id, bool includeParticipants = false, bool includeMatches = false)
        {
            return operations.GetTournamentAsync(id, includeParticipants, includeMatches).GetAwaiter().GetResult();
        }

        public static async Task<Models.TournamentElement> GetTournamentAsync(this ITournaments operations, string id, bool includeParticipants = false, bool includeMatches = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetTournamentWithHttpMessagesAsync(id, includeParticipants, includeMatches, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        public static Models.TournamentElement PostTournament(this ITournaments operations, CreateTournament model)
        {
            return operations.PostTournamentAsync(model).GetAwaiter().GetResult();
        }

        public static async Task<Models.TournamentElement> PostTournamentAsync(this ITournaments operations, CreateTournament model, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.PostTournamentWithHttpMessagesAsync(model, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        
        public static void DeleteRegion(this ITournaments operations, string id)
        {
            operations.DeleteRegionAsync(id).GetAwaiter().GetResult();
        }
        
        public static async Task DeleteRegionAsync(this ITournaments operations, string id, CancellationToken cancellationToken = default(CancellationToken))
        {
            var _result = await operations.DeleteTournamentWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
        }
    }
}
