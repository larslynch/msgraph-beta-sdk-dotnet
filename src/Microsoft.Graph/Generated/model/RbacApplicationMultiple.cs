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
    /// The type Rbac Application Multiple.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RbacApplicationMultiple : Entity
    {
    
		///<summary>
		/// The RbacApplicationMultiple constructor
		///</summary>
        public RbacApplicationMultiple()
        {
            this.ODataType = "microsoft.graph.rbacApplicationMultiple";
        }
	
        /// <summary>
        /// Gets or sets resource namespaces.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceNamespaces", Required = Newtonsoft.Json.Required.Default)]
        public IRbacApplicationMultipleResourceNamespacesCollectionPage ResourceNamespaces { get; set; }
    
        /// <summary>
        /// Gets or sets role assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IRbacApplicationMultipleRoleAssignmentsCollectionPage RoleAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets role definitions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleDefinitions", Required = Newtonsoft.Json.Required.Default)]
        public IRbacApplicationMultipleRoleDefinitionsCollectionPage RoleDefinitions { get; set; }
    
    }
}

