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
    /// The type Connector Group.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ConnectorGroup : Entity
    {
    
		///<summary>
		/// The ConnectorGroup constructor
		///</summary>
        public ConnectorGroup()
        {
            this.ODataType = "microsoft.graph.connectorGroup";
        }
	
        /// <summary>
        /// Gets or sets connector group type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectorGroupType", Required = Newtonsoft.Json.Required.Default)]
        public ConnectorGroupType? ConnectorGroupType { get; set; }
    
        /// <summary>
        /// Gets or sets is default.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDefault", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets region.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "region", Required = Newtonsoft.Json.Required.Default)]
        public ConnectorGroupRegion? Region { get; set; }
    
        /// <summary>
        /// Gets or sets applications.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applications", Required = Newtonsoft.Json.Required.Default)]
        public IConnectorGroupApplicationsCollectionWithReferencesPage Applications { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "members", Required = Newtonsoft.Json.Required.Default)]
        public IConnectorGroupMembersCollectionWithReferencesPage Members { get; set; }
    
    }
}

