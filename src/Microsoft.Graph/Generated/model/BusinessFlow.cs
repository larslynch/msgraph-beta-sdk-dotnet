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
    /// The type Business Flow.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class BusinessFlow : Entity
    {
    
		///<summary>
		/// The BusinessFlow constructor
		///</summary>
        public BusinessFlow()
        {
            this.ODataType = "microsoft.graph.businessFlow";
        }
	
        /// <summary>
        /// Gets or sets custom data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customData", Required = Newtonsoft.Json.Required.Default)]
        public string CustomData { get; set; }
    
        /// <summary>
        /// Gets or sets de duplication id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deDuplicationId", Required = Newtonsoft.Json.Required.Default)]
        public string DeDuplicationId { get; set; }
    
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
        /// Gets or sets policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policy", Required = Newtonsoft.Json.Required.Default)]
        public GovernancePolicy Policy { get; set; }
    
        /// <summary>
        /// Gets or sets policy template id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyTemplateId", Required = Newtonsoft.Json.Required.Default)]
        public string PolicyTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets record version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recordVersion", Required = Newtonsoft.Json.Required.Default)]
        public string RecordVersion { get; set; }
    
        /// <summary>
        /// Gets or sets schema id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schemaId", Required = Newtonsoft.Json.Required.Default)]
        public string SchemaId { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public BusinessFlowSettings Settings { get; set; }
    
    }
}

