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
    /// The type Skype For Business Activity User Detail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SkypeForBusinessActivityUserDetail : Entity
    {
    
		///<summary>
		/// The SkypeForBusinessActivityUserDetail constructor
		///</summary>
        public SkypeForBusinessActivityUserDetail()
        {
            this.ODataType = "microsoft.graph.skypeForBusinessActivityUserDetail";
        }
	
        /// <summary>
        /// Gets or sets assigned products.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedProducts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AssignedProducts { get; set; }
    
        /// <summary>
        /// Gets or sets deleted date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deletedDate", Required = Newtonsoft.Json.Required.Default)]
        public Date DeletedDate { get; set; }
    
        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDeleted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date LastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets organized conference app sharing count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizedConferenceAppSharingCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OrganizedConferenceAppSharingCount { get; set; }
    
        /// <summary>
        /// Gets or sets organized conference audio video count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizedConferenceAudioVideoCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OrganizedConferenceAudioVideoCount { get; set; }
    
        /// <summary>
        /// Gets or sets organized conference audio video minutes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizedConferenceAudioVideoMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OrganizedConferenceAudioVideoMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets organized conference cloud dial in microsoft minutes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizedConferenceCloudDialInMicrosoftMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OrganizedConferenceCloudDialInMicrosoftMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets organized conference cloud dial in out microsoft count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizedConferenceCloudDialInOutMicrosoftCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OrganizedConferenceCloudDialInOutMicrosoftCount { get; set; }
    
        /// <summary>
        /// Gets or sets organized conference cloud dial out microsoft minutes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizedConferenceCloudDialOutMicrosoftMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OrganizedConferenceCloudDialOutMicrosoftMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets organized conference dial in out3rd party count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizedConferenceDialInOut3rdPartyCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OrganizedConferenceDialInOut3rdPartyCount { get; set; }
    
        /// <summary>
        /// Gets or sets organized conference imcount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizedConferenceIMCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OrganizedConferenceIMCount { get; set; }
    
        /// <summary>
        /// Gets or sets organized conference last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizedConferenceLastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date OrganizedConferenceLastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets organized conference web count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizedConferenceWebCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? OrganizedConferenceWebCount { get; set; }
    
        /// <summary>
        /// Gets or sets participated conference app sharing count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participatedConferenceAppSharingCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ParticipatedConferenceAppSharingCount { get; set; }
    
        /// <summary>
        /// Gets or sets participated conference audio video count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participatedConferenceAudioVideoCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ParticipatedConferenceAudioVideoCount { get; set; }
    
        /// <summary>
        /// Gets or sets participated conference audio video minutes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participatedConferenceAudioVideoMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ParticipatedConferenceAudioVideoMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets participated conference dial in out3rd party count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participatedConferenceDialInOut3rdPartyCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ParticipatedConferenceDialInOut3rdPartyCount { get; set; }
    
        /// <summary>
        /// Gets or sets participated conference imcount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participatedConferenceIMCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ParticipatedConferenceIMCount { get; set; }
    
        /// <summary>
        /// Gets or sets participated conference last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participatedConferenceLastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ParticipatedConferenceLastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets participated conference web count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "participatedConferenceWebCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ParticipatedConferenceWebCount { get; set; }
    
        /// <summary>
        /// Gets or sets peer to peer app sharing count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "peerToPeerAppSharingCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PeerToPeerAppSharingCount { get; set; }
    
        /// <summary>
        /// Gets or sets peer to peer audio count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "peerToPeerAudioCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PeerToPeerAudioCount { get; set; }
    
        /// <summary>
        /// Gets or sets peer to peer audio minutes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "peerToPeerAudioMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PeerToPeerAudioMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets peer to peer file transfer count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "peerToPeerFileTransferCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PeerToPeerFileTransferCount { get; set; }
    
        /// <summary>
        /// Gets or sets peer to peer imcount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "peerToPeerIMCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PeerToPeerIMCount { get; set; }
    
        /// <summary>
        /// Gets or sets peer to peer last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "peerToPeerLastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date PeerToPeerLastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets peer to peer video count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "peerToPeerVideoCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PeerToPeerVideoCount { get; set; }
    
        /// <summary>
        /// Gets or sets peer to peer video minutes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "peerToPeerVideoMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int64? PeerToPeerVideoMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportPeriod", Required = Newtonsoft.Json.Required.Default)]
        public string ReportPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets total organized conference count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalOrganizedConferenceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? TotalOrganizedConferenceCount { get; set; }
    
        /// <summary>
        /// Gets or sets total participated conference count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalParticipatedConferenceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? TotalParticipatedConferenceCount { get; set; }
    
        /// <summary>
        /// Gets or sets total peer to peer session count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalPeerToPeerSessionCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? TotalPeerToPeerSessionCount { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
    }
}

