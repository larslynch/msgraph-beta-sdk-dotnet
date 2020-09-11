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
    /// The type User Experience Analytics Regression Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserExperienceAnalyticsRegressionSummary : Entity
    {
    
		///<summary>
		/// The UserExperienceAnalyticsRegressionSummary constructor
		///</summary>
        public UserExperienceAnalyticsRegressionSummary()
        {
            this.ODataType = "microsoft.graph.userExperienceAnalyticsRegressionSummary";
        }
	
        /// <summary>
        /// Gets or sets manufacturer regression.
        /// The metric values for the user experience analytics Manufacturer regression.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manufacturerRegression", Required = Newtonsoft.Json.Required.Default)]
        public IUserExperienceAnalyticsRegressionSummaryManufacturerRegressionCollectionPage ManufacturerRegression { get; set; }
    
        /// <summary>
        /// Gets or sets model regression.
        /// The metric values for the user experience analytics model regression.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "modelRegression", Required = Newtonsoft.Json.Required.Default)]
        public IUserExperienceAnalyticsRegressionSummaryModelRegressionCollectionPage ModelRegression { get; set; }
    
        /// <summary>
        /// Gets or sets operating system regression.
        /// The metric values for the user experience analytics operating system regression.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystemRegression", Required = Newtonsoft.Json.Required.Default)]
        public IUserExperienceAnalyticsRegressionSummaryOperatingSystemRegressionCollectionPage OperatingSystemRegression { get; set; }
    
    }
}

