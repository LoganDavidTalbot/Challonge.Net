using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challonge.Net.Models
{
    public partial class Participant
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("tournament_id")]
        public long TournamentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("seed")]
        public long Seed { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("invite_email")]
        public object InviteEmail { get; set; }

        [JsonProperty("final_rank")]
        public object FinalRank { get; set; }

        [JsonProperty("misc")]
        public object Misc { get; set; }

        [JsonProperty("icon")]
        public object Icon { get; set; }

        [JsonProperty("on_waiting_list")]
        public bool OnWaitingList { get; set; }

        [JsonProperty("invitation_id")]
        public long InvitationId { get; set; }

        [JsonProperty("group_id")]
        public object GroupId { get; set; }

        [JsonProperty("checked_in_at")]
        public object CheckedInAt { get; set; }

        [JsonProperty("ranked_member_id")]
        public object RankedMemberId { get; set; }

        [JsonProperty("challonge_username")]
        public object ChallongeUsername { get; set; }

        [JsonProperty("challonge_email_address_verified")]
        public object ChallongeEmailAddressVerified { get; set; }

        [JsonProperty("removable")]
        public bool Removable { get; set; }

        [JsonProperty("participatable_or_invitation_attached")]
        public bool ParticipatableOrInvitationAttached { get; set; }

        [JsonProperty("confirm_remove")]
        public bool ConfirmRemove { get; set; }

        [JsonProperty("invitation_pending")]
        public bool InvitationPending { get; set; }

        [JsonProperty("display_name_with_invitation_email_address")]
        public string DisplayNameWithInvitationEmailAddress { get; set; }

        [JsonProperty("email_hash")]
        public object EmailHash { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("attached_participatable_portrait_url")]
        public string AttachedParticipatablePortraitUrl { get; set; }

        [JsonProperty("can_check_in")]
        public bool CanCheckIn { get; set; }

        [JsonProperty("checked_in")]
        public bool CheckedIn { get; set; }

        [JsonProperty("reactivatable")]
        public bool Reactivatable { get; set; }

        [JsonProperty("check_in_open")]
        public bool CheckInOpen { get; set; }

        [JsonProperty("group_player_ids")]
        public object[] GroupPlayerIds { get; set; }

        [JsonProperty("has_irrelevant_seed")]
        public bool HasIrrelevantSeed { get; set; }
    }
}
