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
    /// The type Device Compliance Script Device State.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceComplianceScriptDeviceState : Entity
    {
    
		///<summary>
		/// The DeviceComplianceScriptDeviceState constructor
		///</summary>
        public DeviceComplianceScriptDeviceState()
        {
            this.ODataType = "microsoft.graph.deviceComplianceScriptDeviceState";
        }
	
        /// <summary>
        /// Gets or sets detection state.
        /// Detection state from the lastest device compliance script execution. Possible values are: unknown, success, fail, scriptError, pending, notApplicable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionState", Required = Newtonsoft.Json.Required.Default)]
        public RunState? DetectionState { get; set; }
    
        /// <summary>
        /// Gets or sets expected state update date time.
        /// The next timestamp of when the device compliance script is expected to execute
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expectedStateUpdateDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpectedStateUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last state update date time.
        /// The last timestamp of when the device compliance script executed
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastStateUpdateDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastStateUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// The last time that Intune Management Extension synced with Intune
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets script error.
        /// Error from the detection script
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scriptError", Required = Newtonsoft.Json.Required.Default)]
        public string ScriptError { get; set; }
    
        /// <summary>
        /// Gets or sets script output.
        /// Output of the detection script
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scriptOutput", Required = Newtonsoft.Json.Required.Default)]
        public string ScriptOutput { get; set; }
    
        /// <summary>
        /// Gets or sets managed device.
        /// The managed device on which the device compliance script executed
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDevice", Required = Newtonsoft.Json.Required.Default)]
        public ManagedDevice ManagedDevice { get; set; }
    
    }
}

