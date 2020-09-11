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
    /// The type Device Configuration Group Assignment.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceConfigurationGroupAssignment : Entity
    {
    
		///<summary>
		/// The DeviceConfigurationGroupAssignment constructor
		///</summary>
        public DeviceConfigurationGroupAssignment()
        {
            this.ODataType = "microsoft.graph.deviceConfigurationGroupAssignment";
        }
	
        /// <summary>
        /// Gets or sets exclude group.
        /// Indicates if this group is should be excluded. Defaults that the group should be included
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "excludeGroup", Required = Newtonsoft.Json.Required.Default)]
        public bool? ExcludeGroup { get; set; }
    
        /// <summary>
        /// Gets or sets target group id.
        /// The Id of the AAD group we are targeting the device configuration to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetGroupId", Required = Newtonsoft.Json.Required.Default)]
        public string TargetGroupId { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration.
        /// The navigation link to the Device Configuration being targeted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceConfiguration", Required = Newtonsoft.Json.Required.Default)]
        public DeviceConfiguration DeviceConfiguration { get; set; }
    
    }
}

