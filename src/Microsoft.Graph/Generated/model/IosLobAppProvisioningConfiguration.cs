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
    /// The type Ios Lob App Provisioning Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosLobAppProvisioningConfiguration : Entity
    {
    
		///<summary>
		/// The IosLobAppProvisioningConfiguration constructor
		///</summary>
        public IosLobAppProvisioningConfiguration()
        {
            this.ODataType = "microsoft.graph.iosLobAppProvisioningConfiguration";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// DateTime the object was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Admin provided description of the Device Configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Admin provided name of the device configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// Optional profile expiration date and time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets payload.
        /// Payload. (UTF8 encoded byte array)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payload", Required = Newtonsoft.Json.Required.Default)]
        public byte[] Payload { get; set; }
    
        /// <summary>
        /// Gets or sets payload file name.
        /// Payload file name (*.mobileprovision | *.xml).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payloadFileName", Required = Newtonsoft.Json.Required.Default)]
        public string PayloadFileName { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this iOS LOB app provisioning configuration entity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the device configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Version { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The associated group assignments for IosLobAppProvisioningConfiguration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IIosLobAppProvisioningConfigurationAssignmentsCollectionPage Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets device statuses.
        /// The list of device installation states for this mobile app configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IIosLobAppProvisioningConfigurationDeviceStatusesCollectionPage DeviceStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets group assignments.
        /// The associated group assignments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupAssignments", Required = Newtonsoft.Json.Required.Default)]
        public IIosLobAppProvisioningConfigurationGroupAssignmentsCollectionPage GroupAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets user statuses.
        /// The list of user installation states for this mobile app configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IIosLobAppProvisioningConfigurationUserStatusesCollectionPage UserStatuses { get; set; }
    
    }
}

