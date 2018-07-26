using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Challonge.Net.Models
{
    public partial class CreateTournament
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tournament_type")]
        public string TournamentType { get; set; }

        [JsonProperty("subdomain")]
        public object Subdomain { get; set; }

        [JsonProperty("open_signup")]
        public bool OpenSignup { get; set; }

        [JsonProperty("hold_third_place_match")]
        public bool HoldThirdPlaceMatch { get; set; }

        [JsonProperty("pts_for_game_win")]
        public string PtsForGameWin { get; set; }

        [JsonProperty("pts_for_game_tie")]
        public string PtsForGameTie { get; set; }

        [JsonProperty("pts_for_match_win")]
        public string PtsForMatchWin { get; set; }

        [JsonProperty("pts_for_match_tie")]
        public string PtsForMatchTie { get; set; }

        [JsonProperty("pts_for_bye")]
        public string PtsForBye { get; set; }

        [JsonProperty("swiss_rounds")]
        public long SwissRounds { get; set; }

        [JsonProperty("ranked_by")]
        public string RankedBy { get; set; }

        [JsonProperty("rr_pts_for_game_win")]
        public string RrPtsForGameWin { get; set; }

        [JsonProperty("rr_pts_for_game_tie")]
        public string RrPtsForGameTie { get; set; }

        [JsonProperty("rr_pts_for_match_win")]
        public string RrPtsForMatchWin { get; set; }

        [JsonProperty("rr_pts_for_match_tie")]
        public string RrPtsForMatchTie { get; set; }

        [JsonProperty("accept_attachments")]
        public bool AcceptAttachments { get; set; }

        [JsonProperty("hide_forum")]
        public bool HideForum { get; set; }

        [JsonProperty("show_rounds")]
        public bool ShowRounds { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("notify_users_when_matches_open")]
        public bool NotifyUsersWhenMatchesOpen { get; set; }

        [JsonProperty("notify_users_when_the_tournament_ends")]
        public bool NotifyUsersWhenTheTournamentEnds { get; set; }

        [JsonProperty("sequential_pairings")]
        public bool SequentialPairings { get; set; }

        [JsonProperty("signup_cap")]
        public long SignupCap { get; set; }

        [JsonProperty("started_at")]
        public DateTimeOffset StartedAt { get; set; }

        [JsonProperty("check_in_duration")]
        public long CheckInDuration { get; set; }

        [JsonProperty("grand_finals_modifier")]
        public object GrandFinalsModifier { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
