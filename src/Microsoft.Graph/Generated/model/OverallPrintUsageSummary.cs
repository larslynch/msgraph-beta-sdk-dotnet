// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type OverallPrintUsageSummary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class OverallPrintUsageSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverallPrintUsageSummary"/> class.
        /// </summary>
        public OverallPrintUsageSummary()
        {
            this.ODataType = "microsoft.graph.overallPrintUsageSummary";
        }

        /// <summary>
        /// Gets or sets activePrintersCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activePrintersCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ActivePrintersCount { get; set; }
    
        /// <summary>
        /// Gets or sets activeUsersCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeUsersCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ActiveUsersCount { get; set; }
    
        /// <summary>
        /// Gets or sets daysInPeriod.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "daysInPeriod", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DaysInPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets topPrinters.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "topPrinters", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrinterUsageSummary> TopPrinters { get; set; }
    
        /// <summary>
        /// Gets or sets topUsers.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "topUsers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<UserPrintUsageSummary> TopUsers { get; set; }
    
        /// <summary>
        /// Gets or sets totalIncompleteJobs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalIncompleteJobs", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalIncompleteJobs { get; set; }
    
        /// <summary>
        /// Gets or sets totalJobsProcessed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalJobsProcessed", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalJobsProcessed { get; set; }
    
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
