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
    /// The type IosMinimumOperatingSystem.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class IosMinimumOperatingSystem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosMinimumOperatingSystem"/> class.
        /// </summary>
        public IosMinimumOperatingSystem()
        {
            this.ODataType = "microsoft.graph.iosMinimumOperatingSystem";
        }

        /// <summary>
        /// Gets or sets v10_0.
        /// Version 10.0 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v10_0", Required = Newtonsoft.Json.Required.Default)]
        public bool? V10_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v11_0.
        /// Version 11.0 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v11_0", Required = Newtonsoft.Json.Required.Default)]
        public bool? V11_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v12_0.
        /// Version 12.0 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v12_0", Required = Newtonsoft.Json.Required.Default)]
        public bool? V12_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v13_0.
        /// Version 13.0 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v13_0", Required = Newtonsoft.Json.Required.Default)]
        public bool? V13_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v14_0.
        /// Version 14.0 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v14_0", Required = Newtonsoft.Json.Required.Default)]
        public bool? V14_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v8_0.
        /// Version 8.0 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v8_0", Required = Newtonsoft.Json.Required.Default)]
        public bool? V8_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v9_0.
        /// Version 9.0 or later.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "v9_0", Required = Newtonsoft.Json.Required.Default)]
        public bool? V9_0 { get; set; }
    
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
