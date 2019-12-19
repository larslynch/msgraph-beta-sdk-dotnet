// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Online Meeting.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class OnlineMeeting : Entity
    {
    
		///<summary>
		/// The OnlineMeeting constructor
		///</summary>
        public OnlineMeeting()
        {
            this.ODataType = "microsoft.graph.onlineMeeting";
        }
	
        /// <summary>
        /// Gets or sets creation date time.
        /// The meeting creation time in UTC. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "creationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// The meeting start time in UTC.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "startDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets end date time.
        /// The meeting end time in UTC.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets canceled date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "canceledDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CanceledDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets entry exit announcement.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "entryExitAnnouncement", Required = Newtonsoft.Json.Required.Default)]
        public bool? EntryExitAnnouncement { get; set; }
    
        /// <summary>
        /// Gets or sets join url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "joinUrl", Required = Newtonsoft.Json.Required.Default)]
        public string JoinUrl { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The subject of the online meeting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets is cancelled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isCancelled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsCancelled { get; set; }
    
        /// <summary>
        /// Gets or sets participants.
        /// The participants associated with the online meeting.  This includes the organizer and the attendees.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participants", Required = Newtonsoft.Json.Required.Default)]
        public MeetingParticipants Participants { get; set; }
    
        /// <summary>
        /// Gets or sets is broadcast.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isBroadcast", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsBroadcast { get; set; }
    
        /// <summary>
        /// Gets or sets access level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessLevel", Required = Newtonsoft.Json.Required.Default)]
        public AccessLevel? AccessLevel { get; set; }
    
        /// <summary>
        /// Gets or sets capabilities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "capabilities", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MeetingCapabilities> Capabilities { get; set; }
    
        /// <summary>
        /// Gets or sets audio conferencing.
        /// The phone access (dial-in) information for an online meeting. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "audioConferencing", Required = Newtonsoft.Json.Required.Default)]
        public AudioConferencing AudioConferencing { get; set; }
    
        /// <summary>
        /// Gets or sets chat info.
        /// The chat information associated with this online meeting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "chatInfo", Required = Newtonsoft.Json.Required.Default)]
        public ChatInfo ChatInfo { get; set; }
    
        /// <summary>
        /// Gets or sets video teleconference id.
        /// The videio teleconferencing ID. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "videoTeleconferenceId", Required = Newtonsoft.Json.Required.Default)]
        public string VideoTeleconferenceId { get; set; }
    
    }
}

