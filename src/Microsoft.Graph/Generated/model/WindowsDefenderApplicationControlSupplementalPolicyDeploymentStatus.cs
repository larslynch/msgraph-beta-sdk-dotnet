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
    /// The type Windows Defender Application Control Supplemental Policy Deployment Status.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus : Entity
    {
    
		///<summary>
		/// The WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus constructor
		///</summary>
        public WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus()
        {
            this.ODataType = "microsoft.graph.windowsDefenderApplicationControlSupplementalPolicyDeploymentStatus";
        }
	
        /// <summary>
        /// Gets or sets deployment status.
        /// The deployment state of the policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentStatus", Required = Newtonsoft.Json.Required.Default)]
        public WindowsDefenderApplicationControlSupplementalPolicyStatuses? DeploymentStatus { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// Device ID.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Device name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceName", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// Last sync date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets os description.
        /// Windows OS Version Description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osDescription", Required = Newtonsoft.Json.Required.Default)]
        public string OsDescription { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// Windows OS Version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets policy version.
        /// Human readable version of the WindowsDefenderApplicationControl supplemental policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyVersion", Required = Newtonsoft.Json.Required.Default)]
        public string PolicyVersion { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// The name of the user of this device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userName", Required = Newtonsoft.Json.Required.Default)]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User Principal Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets policy.
        /// The navigation link to the WindowsDefenderApplicationControl supplemental policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policy", Required = Newtonsoft.Json.Required.Default)]
        public WindowsDefenderApplicationControlSupplementalPolicy Policy { get; set; }
    
    }
}

