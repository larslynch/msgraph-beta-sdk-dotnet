// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Presence.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Presence : Entity
    {
    
		///<summary>
		/// The Presence constructor
		///</summary>
        public Presence()
        {
            this.ODataType = "microsoft.graph.presence";
        }
	
        /// <summary>
        /// Gets or sets activity.
        /// The supplemental information to a user's availability. Possible values are Available, Away, BeRightBack, Busy, DoNotDisturb, InACall, InAConferenceCall, Inactive,InAMeeting, Offline, OffWork,OutOfOffice, PresenceUnknown,Presenting, UrgentInterruptionsOnly.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activity", Required = Newtonsoft.Json.Required.Default)]
        public string Activity { get; set; }
    
        /// <summary>
        /// Gets or sets availability.
        /// The base presence information for a user. Possible values are Available, AvailableIdle,  Away, BeRightBack, Busy, BusyIdle, DoNotDisturb, Offline, PresenceUnknown
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "availability", Required = Newtonsoft.Json.Required.Default)]
        public string Availability { get; set; }
    
        /// <summary>
        /// Gets or sets out of office settings.
        /// The out of office settings for a user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outOfOfficeSettings", Required = Newtonsoft.Json.Required.Default)]
        public OutOfOfficeSettings OutOfOfficeSettings { get; set; }
    
    }
}

