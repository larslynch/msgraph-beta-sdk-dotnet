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
    /// The type Security Baseline State.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SecurityBaselineState : Entity
    {
    
		///<summary>
		/// The SecurityBaselineState constructor
		///</summary>
        public SecurityBaselineState()
        {
            this.ODataType = "microsoft.graph.securityBaselineState";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the security baseline
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets security baseline template id.
        /// The security baseline template id
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityBaselineTemplateId", Required = Newtonsoft.Json.Required.Default)]
        public string SecurityBaselineTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets setting states.
        /// The security baseline state for different settings for a device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingStates", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityBaselineStateSettingStatesCollectionPage SettingStates { get; set; }
    
    }
}

