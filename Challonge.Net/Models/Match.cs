using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challonge.Net.Models
{
    public partial class Match
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("tournament_id")]
        public long TournamentId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("player1_id")]
        public long? Player1Id { get; set; }

        [JsonProperty("player2_id")]
        public long? Player2Id { get; set; }

        [JsonProperty("player1_prereq_match_id")]
        public long? Player1PrereqMatchId { get; set; }

        [JsonProperty("player2_prereq_match_id")]
        public long? Player2PrereqMatchId { get; set; }

        [JsonProperty("player1_is_prereq_match_loser")]
        public bool Player1IsPrereqMatchLoser { get; set; }

        [JsonProperty("player2_is_prereq_match_loser")]
        public bool Player2IsPrereqMatchLoser { get; set; }

        [JsonProperty("winner_id")]
        public object WinnerId { get; set; }

        [JsonProperty("loser_id")]
        public object LoserId { get; set; }

        [JsonProperty("started_at")]
        public DateTimeOffset? StartedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("has_attachment")]
        public bool HasAttachment { get; set; }

        [JsonProperty("round")]
        public long Round { get; set; }

        [JsonProperty("player1_votes")]
        public object Player1Votes { get; set; }

        [JsonProperty("player2_votes")]
        public object Player2Votes { get; set; }

        [JsonProperty("group_id")]
        public object GroupId { get; set; }

        [JsonProperty("attachment_count")]
        public object AttachmentCount { get; set; }

        [JsonProperty("scheduled_time")]
        public object ScheduledTime { get; set; }

        [JsonProperty("location")]
        public object Location { get; set; }

        [JsonProperty("underway_at")]
        public object UnderwayAt { get; set; }

        [JsonProperty("optional")]
        public bool? Optional { get; set; }

        [JsonProperty("rushb_id")]
        public object RushbId { get; set; }

        [JsonProperty("completed_at")]
        public object CompletedAt { get; set; }

        [JsonProperty("suggested_play_order")]
        public long? SuggestedPlayOrder { get; set; }

        [JsonProperty("forfeited")]
        public object Forfeited { get; set; }

        [JsonProperty("prerequisite_match_ids_csv")]
        public string PrerequisiteMatchIdsCsv { get; set; }

        [JsonProperty("scores_csv")]
        public string ScoresCsv { get; set; }
    }
}
