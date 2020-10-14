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
    /// The type Unified Rbac Resource Namespace.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UnifiedRbacResourceNamespace : Entity
    {
    
		///<summary>
		/// The UnifiedRbacResourceNamespace constructor
		///</summary>
        public UnifiedRbacResourceNamespace()
        {
            this.ODataType = "microsoft.graph.unifiedRbacResourceNamespace";
        }
	
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets resource actions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceActions", Required = Newtonsoft.Json.Required.Default)]
        public IUnifiedRbacResourceNamespaceResourceActionsCollectionPage ResourceActions { get; set; }
    
    }
}

