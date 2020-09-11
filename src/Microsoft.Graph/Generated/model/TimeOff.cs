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
    /// The type Time Off.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TimeOff : ChangeTrackedEntity
    {
    
		///<summary>
		/// The TimeOff constructor
		///</summary>
        public TimeOff()
        {
            this.ODataType = "microsoft.graph.timeOff";
        }
	
        /// <summary>
        /// Gets or sets draft time off.
        /// The draft version of this timeOff that is viewable by managers. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "draftTimeOff", Required = Newtonsoft.Json.Required.Default)]
        public TimeOffItem DraftTimeOff { get; set; }
    
        /// <summary>
        /// Gets or sets is staged for deletion.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isStagedForDeletion", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsStagedForDeletion { get; set; }
    
        /// <summary>
        /// Gets or sets shared time off.
        /// The shared version of this timeOff that is viewable by both employees and managers. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharedTimeOff", Required = Newtonsoft.Json.Required.Default)]
        public TimeOffItem SharedTimeOff { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// ID of the user assigned to the timeOff. Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
    }
}

