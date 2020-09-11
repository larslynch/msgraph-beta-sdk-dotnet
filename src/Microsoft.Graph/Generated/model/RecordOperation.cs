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
    /// The type Record Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RecordOperation : CommsOperation
    {
    
		///<summary>
		/// The RecordOperation constructor
		///</summary>
        public RecordOperation()
        {
            this.ODataType = "microsoft.graph.recordOperation";
        }
	
        /// <summary>
        /// Gets or sets completion reason.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "completionReason", Required = Newtonsoft.Json.Required.Default)]
        public RecordCompletionReason? CompletionReason { get; set; }
    
        /// <summary>
        /// Gets or sets recording access token.
        /// The access token required to retrieve the recording.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recordingAccessToken", Required = Newtonsoft.Json.Required.Default)]
        public string RecordingAccessToken { get; set; }
    
        /// <summary>
        /// Gets or sets recording location.
        /// The location where the recording is located.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recordingLocation", Required = Newtonsoft.Json.Required.Default)]
        public string RecordingLocation { get; set; }
    
    }
}

