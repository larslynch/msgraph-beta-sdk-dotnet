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
    /// The type Approval Step.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ApprovalStep : Entity
    {
    
		///<summary>
		/// The ApprovalStep constructor
		///</summary>
        public ApprovalStep()
        {
            this.ODataType = "microsoft.graph.approvalStep";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets justification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "justification", Required = Newtonsoft.Json.Required.Default)]
        public string Justification { get; set; }
    
        /// <summary>
        /// Gets or sets reviewed by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reviewedBy", Required = Newtonsoft.Json.Required.Default)]
        public Identity ReviewedBy { get; set; }
    
        /// <summary>
        /// Gets or sets reviewed date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reviewedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ReviewedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets review result.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reviewResult", Required = Newtonsoft.Json.Required.Default)]
        public string ReviewResult { get; set; }
    
    }
}

