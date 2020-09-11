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
    /// The type Windows Information Protection Network Learning Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsInformationProtectionNetworkLearningSummary : Entity
    {
    
		///<summary>
		/// The WindowsInformationProtectionNetworkLearningSummary constructor
		///</summary>
        public WindowsInformationProtectionNetworkLearningSummary()
        {
            this.ODataType = "microsoft.graph.windowsInformationProtectionNetworkLearningSummary";
        }
	
        /// <summary>
        /// Gets or sets device count.
        /// Device Count
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// Website url
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "url", Required = Newtonsoft.Json.Required.Default)]
        public string Url { get; set; }
    
    }
}

