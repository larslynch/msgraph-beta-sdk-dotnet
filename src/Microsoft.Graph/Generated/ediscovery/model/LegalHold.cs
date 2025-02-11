// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Legal Hold.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class LegalHold : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The LegalHold constructor
		///</summary>
        public LegalHold()
        {
            this.ODataType = "microsoft.graph.ediscovery.legalHold";
        }
	
        /// <summary>
        /// Gets or sets content query.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentQuery", Required = Newtonsoft.Json.Required.Default)]
        public string ContentQuery { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets errors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errors", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Errors { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedBy", Required = Newtonsoft.Json.Required.Default)]
        public Microsoft.Graph.IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public LegalHoldStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets site sources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "siteSources", Required = Newtonsoft.Json.Required.Default)]
        public ILegalHoldSiteSourcesCollectionPage SiteSources { get; set; }
    
        /// <summary>
        /// Gets or sets unified group sources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unifiedGroupSources", Required = Newtonsoft.Json.Required.Default)]
        public ILegalHoldUnifiedGroupSourcesCollectionPage UnifiedGroupSources { get; set; }
    
        /// <summary>
        /// Gets or sets user sources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userSources", Required = Newtonsoft.Json.Required.Default)]
        public ILegalHoldUserSourcesCollectionPage UserSources { get; set; }
    
    }
}

