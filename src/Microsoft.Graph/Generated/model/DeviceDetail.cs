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
    /// The type DeviceDetail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceDetail"/> class.
        /// </summary>
        public DeviceDetail()
        {
            this.ODataType = "microsoft.graph.deviceDetail";
        }

        /// <summary>
        /// Gets or sets browser.
        /// Indicates the browser information of the used for signing in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browser", Required = Newtonsoft.Json.Required.Default)]
        public string Browser { get; set; }
    
        /// <summary>
        /// Gets or sets browserId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserId", Required = Newtonsoft.Json.Required.Default)]
        public string BrowserId { get; set; }
    
        /// <summary>
        /// Gets or sets deviceId.
        /// Refers to the UniqueID of the device used for signing in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceId", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// Refers to the name of the device used for signing in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets isCompliant.
        /// Indicates whether the device is compliant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isCompliant", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsCompliant { get; set; }
    
        /// <summary>
        /// Gets or sets isManaged.
        /// Indicates whether the device is managed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isManaged", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsManaged { get; set; }
    
        /// <summary>
        /// Gets or sets operatingSystem.
        /// Indicates the operating system name and version used for signing in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystem", Required = Newtonsoft.Json.Required.Default)]
        public string OperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets trustType.
        /// Provides information about whether the signed-in device is Workplace Joined, AzureAD Joined, Domain Joined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trustType", Required = Newtonsoft.Json.Required.Default)]
        public string TrustType { get; set; }
    
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
