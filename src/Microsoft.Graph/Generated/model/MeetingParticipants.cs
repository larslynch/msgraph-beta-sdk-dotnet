// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type MeetingParticipants.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MeetingParticipants
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingParticipants"/> class.
        /// </summary>
        public MeetingParticipants()
        {
            this.ODataType = "microsoft.graph.meetingParticipants";
        }

        /// <summary>
        /// Gets or sets attendees.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attendees", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MeetingParticipantInfo> Attendees { get; set; }
    
        /// <summary>
        /// Gets or sets contributors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contributors", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MeetingParticipantInfo> Contributors { get; set; }
    
        /// <summary>
        /// Gets or sets organizer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizer", Required = Newtonsoft.Json.Required.Default)]
        public MeetingParticipantInfo Organizer { get; set; }
    
        /// <summary>
        /// Gets or sets producers.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "producers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MeetingParticipantInfo> Producers { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
