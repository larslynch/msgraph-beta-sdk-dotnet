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
    /// The type Android Store App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidStoreApp : MobileApp
    {
    
		///<summary>
		/// The AndroidStoreApp constructor
		///</summary>
        public AndroidStoreApp()
        {
            this.ODataType = "microsoft.graph.androidStoreApp";
        }
	
        /// <summary>
        /// Gets or sets app identifier.
        /// The Identity Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string AppIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets app store url.
        /// The Android app store URL.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appStoreUrl", Required = Newtonsoft.Json.Required.Default)]
        public string AppStoreUrl { get; set; }
    
        /// <summary>
        /// Gets or sets minimum supported operating system.
        /// The value for the minimum applicable operating system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumSupportedOperatingSystem", Required = Newtonsoft.Json.Required.Default)]
        public AndroidMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets package id.
        /// The package identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "packageId", Required = Newtonsoft.Json.Required.Default)]
        public string PackageId { get; set; }
    
    }
}

