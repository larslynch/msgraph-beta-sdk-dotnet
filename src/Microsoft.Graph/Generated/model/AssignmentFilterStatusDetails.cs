// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type AssignmentFilterStatusDetails.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AssignmentFilterStatusDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignmentFilterStatusDetails"/> class.
        /// </summary>
        public AssignmentFilterStatusDetails()
        {
            this.ODataType = "microsoft.graph.assignmentFilterStatusDetails";
        }

        /// <summary>
        /// Gets or sets deviceProperties.
        /// Device properties used for filter evaluation during device check-in time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceProperties", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> DeviceProperties { get; set; }
    
        /// <summary>
        /// Gets or sets evalutionSummaries.
        /// Evaluation result summaries for each filter associated to device and payload
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "evalutionSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AssignmentFilterEvaluationSummary> EvalutionSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets managedDeviceId.
        /// Unique identifier for the device object.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets payloadId.
        /// Unique identifier for payload object.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payloadId", Required = Newtonsoft.Json.Required.Default)]
        public string PayloadId { get; set; }
    
        /// <summary>
        /// Gets or sets userId.
        /// Unique identifier for UserId object. Can be null
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
