// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Comanagement Eligible Device.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ComanagementEligibleDevice : Entity
    {
    
		///<summary>
		/// The ComanagementEligibleDevice constructor
		///</summary>
        public ComanagementEligibleDevice()
        {
            this.ODataType = "microsoft.graph.comanagementEligibleDevice";
        }
	
        /// <summary>
        /// Gets or sets client registration status.
        /// ClientRegistrationStatus. Possible values are: notRegistered, registered, revoked, keyConflict, approvalPending, certificateReset, notRegisteredPendingEnrollment, unknown.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientRegistrationStatus", Required = Newtonsoft.Json.Required.Default)]
        public DeviceRegistrationState? ClientRegistrationStatus { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// DeviceName
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets device type.
        /// DeviceType. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, linux, blackberry, palm, unknown, cloudPC.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceType", Required = Newtonsoft.Json.Required.Default)]
        public DeviceType? DeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets entity source.
        /// EntitySource
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "entitySource", Required = Newtonsoft.Json.Required.Default)]
        public Int32? EntitySource { get; set; }
    
        /// <summary>
        /// Gets or sets management agents.
        /// ManagementAgents. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController, microsoft365ManagedMdm.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementAgents", Required = Newtonsoft.Json.Required.Default)]
        public ManagementAgentType? ManagementAgents { get; set; }
    
        /// <summary>
        /// Gets or sets management state.
        /// ManagementState. Possible values are: managed, retirePending, retireFailed, wipePending, wipeFailed, unhealthy, deletePending, retireIssued, wipeIssued, wipeCanceled, retireCanceled, discovered.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managementState", Required = Newtonsoft.Json.Required.Default)]
        public ManagementState? ManagementState { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// Manufacturer
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manufacturer", Required = Newtonsoft.Json.Required.Default)]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets mdm status.
        /// MDMStatus
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mdmStatus", Required = Newtonsoft.Json.Required.Default)]
        public string MdmStatus { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// Model
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "model", Required = Newtonsoft.Json.Required.Default)]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets os description.
        /// OSDescription
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osDescription", Required = Newtonsoft.Json.Required.Default)]
        public string OsDescription { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// OSVersion
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets owner type.
        /// OwnerType. Possible values are: unknown, company, personal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerType", Required = Newtonsoft.Json.Required.Default)]
        public OwnerType? OwnerType { get; set; }
    
        /// <summary>
        /// Gets or sets reference id.
        /// ReferenceId
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "referenceId", Required = Newtonsoft.Json.Required.Default)]
        public string ReferenceId { get; set; }
    
        /// <summary>
        /// Gets or sets serial number.
        /// SerialNumber
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "serialNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// ComanagementEligibleStatus. Possible values are: comanaged, eligible, eligibleButNotAzureAdJoined, needsOsUpdate, ineligible.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public ComanagementEligibleType? Status { get; set; }
    
        /// <summary>
        /// Gets or sets upn.
        /// UPN
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upn", Required = Newtonsoft.Json.Required.Default)]
        public string Upn { get; set; }
    
        /// <summary>
        /// Gets or sets user email.
        /// UserEmail
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userEmail", Required = Newtonsoft.Json.Required.Default)]
        public string UserEmail { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// UserId
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// UserName
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userName", Required = Newtonsoft.Json.Required.Default)]
        public string UserName { get; set; }
    
    }
}

