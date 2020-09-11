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
    /// The type Security Configuration Task.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SecurityConfigurationTask : DeviceAppManagementTask
    {
    
		///<summary>
		/// The SecurityConfigurationTask constructor
		///</summary>
        public SecurityConfigurationTask()
        {
            this.ODataType = "microsoft.graph.securityConfigurationTask";
        }
	
        /// <summary>
        /// Gets or sets applicable platform.
        /// The applicable platform.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicablePlatform", Required = Newtonsoft.Json.Required.Default)]
        public EndpointSecurityConfigurationApplicablePlatform? ApplicablePlatform { get; set; }
    
        /// <summary>
        /// Gets or sets endpoint security policy.
        /// The endpoint security policy type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endpointSecurityPolicy", Required = Newtonsoft.Json.Required.Default)]
        public EndpointSecurityConfigurationType? EndpointSecurityPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets endpoint security policy profile.
        /// The endpoint security policy profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "endpointSecurityPolicyProfile", Required = Newtonsoft.Json.Required.Default)]
        public EndpointSecurityConfigurationProfileType? EndpointSecurityPolicyProfile { get; set; }
    
        /// <summary>
        /// Gets or sets insights.
        /// Information about the mitigation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "insights", Required = Newtonsoft.Json.Required.Default)]
        public string Insights { get; set; }
    
        /// <summary>
        /// Gets or sets intended settings.
        /// The intended settings and their values.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intendedSettings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> IntendedSettings { get; set; }
    
        /// <summary>
        /// Gets or sets managed device count.
        /// The number of vulnerable devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ManagedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets managed devices.
        /// The vulnerable managed devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDevices", Required = Newtonsoft.Json.Required.Default)]
        public ISecurityConfigurationTaskManagedDevicesCollectionPage ManagedDevices { get; set; }
    
    }
}

