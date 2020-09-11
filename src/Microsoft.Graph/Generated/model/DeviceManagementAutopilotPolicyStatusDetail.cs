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
    /// The type Device Management Autopilot Policy Status Detail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementAutopilotPolicyStatusDetail : Entity
    {
    
		///<summary>
		/// The DeviceManagementAutopilotPolicyStatusDetail constructor
		///</summary>
        public DeviceManagementAutopilotPolicyStatusDetail()
        {
            this.ODataType = "microsoft.graph.deviceManagementAutopilotPolicyStatusDetail";
        }
	
        /// <summary>
        /// Gets or sets compliance status.
        /// The policy compliance status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "complianceStatus", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementAutopilotPolicyComplianceStatus? ComplianceStatus { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The friendly name of the policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last reported date time.
        /// Timestamp of the reported policy status
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastReportedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastReportedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets policy type.
        /// The type of policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyType", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementAutopilotPolicyType? PolicyType { get; set; }
    
        /// <summary>
        /// Gets or sets tracked on enrollment status.
        /// Indicates if this prolicy was tracked as part of the autopilot bootstrap enrollment sync session
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trackedOnEnrollmentStatus", Required = Newtonsoft.Json.Required.Default)]
        public bool? TrackedOnEnrollmentStatus { get; set; }
    
    }
}

