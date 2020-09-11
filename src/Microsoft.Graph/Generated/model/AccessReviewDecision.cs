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
    /// The type Access Review Decision.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AccessReviewDecision : Entity
    {
    
		///<summary>
		/// The AccessReviewDecision constructor
		///</summary>
        public AccessReviewDecision()
        {
            this.ODataType = "microsoft.graph.accessReviewDecision";
        }
	
        /// <summary>
        /// Gets or sets access recommendation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessRecommendation", Required = Newtonsoft.Json.Required.Default)]
        public string AccessRecommendation { get; set; }
    
        /// <summary>
        /// Gets or sets access review id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessReviewId", Required = Newtonsoft.Json.Required.Default)]
        public string AccessReviewId { get; set; }
    
        /// <summary>
        /// Gets or sets applied by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliedBy", Required = Newtonsoft.Json.Required.Default)]
        public UserIdentity AppliedBy { get; set; }
    
        /// <summary>
        /// Gets or sets applied date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? AppliedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets apply result.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applyResult", Required = Newtonsoft.Json.Required.Default)]
        public string ApplyResult { get; set; }
    
        /// <summary>
        /// Gets or sets justification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "justification", Required = Newtonsoft.Json.Required.Default)]
        public string Justification { get; set; }
    
        /// <summary>
        /// Gets or sets reviewed by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reviewedBy", Required = Newtonsoft.Json.Required.Default)]
        public UserIdentity ReviewedBy { get; set; }
    
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

