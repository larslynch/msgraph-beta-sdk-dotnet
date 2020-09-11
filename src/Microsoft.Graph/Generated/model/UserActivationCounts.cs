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
    /// The type UserActivationCounts.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class UserActivationCounts
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserActivationCounts"/> class.
        /// </summary>
        public UserActivationCounts()
        {
            this.ODataType = "microsoft.graph.userActivationCounts";
        }

        /// <summary>
        /// Gets or sets activatedOnSharedComputer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activatedOnSharedComputer", Required = Newtonsoft.Json.Required.Default)]
        public bool? ActivatedOnSharedComputer { get; set; }
    
        /// <summary>
        /// Gets or sets android.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "android", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Android { get; set; }
    
        /// <summary>
        /// Gets or sets ios.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ios", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Ios { get; set; }
    
        /// <summary>
        /// Gets or sets lastActivatedDate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastActivatedDate", Required = Newtonsoft.Json.Required.Default)]
        public Date LastActivatedDate { get; set; }
    
        /// <summary>
        /// Gets or sets mac.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mac", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Mac { get; set; }
    
        /// <summary>
        /// Gets or sets productType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productType", Required = Newtonsoft.Json.Required.Default)]
        public string ProductType { get; set; }
    
        /// <summary>
        /// Gets or sets windows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windows", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Windows { get; set; }
    
        /// <summary>
        /// Gets or sets windows10Mobile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windows10Mobile", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Windows10Mobile { get; set; }
    
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
