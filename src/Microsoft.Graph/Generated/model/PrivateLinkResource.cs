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
    /// The type Private Link Resource.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrivateLinkResource : Entity
    {
    
		///<summary>
		/// The PrivateLinkResource constructor
		///</summary>
        public PrivateLinkResource()
        {
            this.ODataType = "microsoft.graph.privateLinkResource";
        }
	
        /// <summary>
        /// Gets or sets allowed tenant ids.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedTenantIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AllowedTenantIds { get; set; }
    
        /// <summary>
        /// Gets or sets arm resource id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "armResourceId", Required = Newtonsoft.Json.Required.Default)]
        public string ArmResourceId { get; set; }
    
    }
}

