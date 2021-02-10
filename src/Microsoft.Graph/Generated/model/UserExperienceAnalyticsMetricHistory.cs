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
    /// The type User Experience Analytics Metric History.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserExperienceAnalyticsMetricHistory : Entity
    {
    
		///<summary>
		/// The UserExperienceAnalyticsMetricHistory constructor
		///</summary>
        public UserExperienceAnalyticsMetricHistory()
        {
            this.ODataType = "microsoft.graph.userExperienceAnalyticsMetricHistory";
        }
	
        /// <summary>
        /// Gets or sets metric date time.
        /// The user experience analytics metric date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "metricDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? MetricDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets metric type.
        /// The user experience analytics metric type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "metricType", Required = Newtonsoft.Json.Required.Default)]
        public string MetricType { get; set; }
    
        /// <summary>
        /// Gets or sets user experience analytics metric.
        /// User experience analytics metric.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userExperienceAnalyticsMetric", Required = Newtonsoft.Json.Required.Default)]
        public UserExperienceAnalyticsMetric UserExperienceAnalyticsMetric { get; set; }
    
    }
}

