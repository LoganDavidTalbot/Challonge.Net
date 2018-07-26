namespace Challonge.Net.Models
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    public partial class Tournament
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tournament_type")]
        public string TournamentType { get; set; }

        [JsonProperty("started_at")]
        public object StartedAt { get; set; }

        [JsonProperty("completed_at")]
        public object CompletedAt { get; set; }

        [JsonProperty("require_score_agreement")]
        public bool RequireScoreAgreement { get; set; }

        [JsonProperty("notify_users_when_matches_open")]
        public bool NotifyUsersWhenMatchesOpen { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("open_signup")]
        public bool OpenSignup { get; set; }

        [JsonProperty("notify_users_when_the_tournament_ends")]
        public bool NotifyUsersWhenTheTournamentEnds { get; set; }

        [JsonProperty("progress_meter")]
        public long ProgressMeter { get; set; }

        [JsonProperty("quick_advance")]
        public bool QuickAdvance { get; set; }

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

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("ranked_by")]
        public string RankedBy { get; set; }

        [JsonProperty("show_rounds")]
        public bool ShowRounds { get; set; }

        [JsonProperty("hide_forum")]
        public bool HideForum { get; set; }

        [JsonProperty("sequential_pairings")]
        public bool SequentialPairings { get; set; }

        [JsonProperty("accept_attachments")]
        public bool AcceptAttachments { get; set; }

        [JsonProperty("rr_pts_for_game_win")]
        public string RrPtsForGameWin { get; set; }

        [JsonProperty("rr_pts_for_game_tie")]
        public string RrPtsForGameTie { get; set; }

        [JsonProperty("rr_pts_for_match_win")]
        public string RrPtsForMatchWin { get; set; }

        [JsonProperty("rr_pts_for_match_tie")]
        public string RrPtsForMatchTie { get; set; }

        [JsonProperty("created_by_api")]
        public bool CreatedByApi { get; set; }

        [JsonProperty("credit_capped")]
        public bool CreditCapped { get; set; }

        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("hide_seeds")]
        public bool HideSeeds { get; set; }

        [JsonProperty("prediction_method")]
        public long PredictionMethod { get; set; }

        [JsonProperty("predictions_opened_at")]
        public object PredictionsOpenedAt { get; set; }

        [JsonProperty("anonymous_voting")]
        public bool AnonymousVoting { get; set; }

        [JsonProperty("max_predictions_per_user")]
        public long MaxPredictionsPerUser { get; set; }

        [JsonProperty("signup_cap")]
        public object SignupCap { get; set; }

        [JsonProperty("game_id")]
        public long? GameId { get; set; }

        [JsonProperty("participants_count")]
        public long ParticipantsCount { get; set; }

        [JsonProperty("group_stages_enabled")]
        public bool GroupStagesEnabled { get; set; }

        [JsonProperty("allow_participant_match_reporting")]
        public bool AllowParticipantMatchReporting { get; set; }

        [JsonProperty("teams")]
        public bool Teams { get; set; }

        [JsonProperty("check_in_duration")]
        public object CheckInDuration { get; set; }

        [JsonProperty("start_at")]
        public DateTimeOffset? StartAt { get; set; }

        [JsonProperty("started_checking_in_at")]
        public object StartedCheckingInAt { get; set; }

        [JsonProperty("tie_breaks")]
        public string[] TieBreaks { get; set; }

        [JsonProperty("locked_at")]
        public object LockedAt { get; set; }

        [JsonProperty("event_id")]
        public object EventId { get; set; }

        [JsonProperty("public_predictions_before_start_time")]
        public bool PublicPredictionsBeforeStartTime { get; set; }

        [JsonProperty("ranked")]
        public bool Ranked { get; set; }

        [JsonProperty("grand_finals_modifier")]
        public object GrandFinalsModifier { get; set; }

        [JsonProperty("predict_the_losers_bracket")]
        public bool PredictTheLosersBracket { get; set; }

        [JsonProperty("spam")]
        public object Spam { get; set; }

        [JsonProperty("ham")]
        public object Ham { get; set; }

        [JsonProperty("rr_iterations")]
        public long RrIterations { get; set; }

        [JsonProperty("tournament_registration_id")]
        public object TournamentRegistrationId { get; set; }

        [JsonProperty("donation_contest_enabled")]
        public object DonationContestEnabled { get; set; }

        [JsonProperty("mandatory_donation")]
        public object MandatoryDonation { get; set; }

        [JsonProperty("description_source")]
        public string DescriptionSource { get; set; }

        [JsonProperty("subdomain")]
        public object Subdomain { get; set; }

        [JsonProperty("full_challonge_url")]
        public string FullChallongeUrl { get; set; }

        [JsonProperty("live_image_url")]
        public string LiveImageUrl { get; set; }

        [JsonProperty("sign_up_url")]
        public object SignUpUrl { get; set; }

        [JsonProperty("review_before_finalizing")]
        public bool ReviewBeforeFinalizing { get; set; }

        [JsonProperty("accepting_predictions")]
        public bool AcceptingPredictions { get; set; }

        [JsonProperty("participants_locked")]
        public bool ParticipantsLocked { get; set; }

        [JsonProperty("game_name")]
        public string GameName { get; set; }

        [JsonProperty("participants_swappable")]
        public bool ParticipantsSwappable { get; set; }

        [JsonProperty("team_convertable")]
        public bool TeamConvertable { get; set; }

        [JsonProperty("group_stages_were_started")]
        public bool GroupStagesWereStarted { get; set; }

        [JsonProperty("matches")]
        public MatchElement[] Matches { get; set; }

        [JsonProperty("participants")]
        public ParticipantElement[] Participants { get; set; }
    }
}
