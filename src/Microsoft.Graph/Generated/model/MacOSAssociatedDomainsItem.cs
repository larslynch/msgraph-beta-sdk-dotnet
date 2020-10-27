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
    /// The type MacOSAssociatedDomainsItem.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MacOSAssociatedDomainsItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MacOSAssociatedDomainsItem"/> class.
        /// </summary>
        public MacOSAssociatedDomainsItem()
        {
            this.ODataType = "microsoft.graph.macOSAssociatedDomainsItem";
        }

        /// <summary>
        /// Gets or sets applicationIdentifier.
        /// The application identifier of the app to associate domains with.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string ApplicationIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets directDownloadsEnabled.
        /// Determines whether data should be downloaded directly or via a CDN.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "directDownloadsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DirectDownloadsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets domains.
        /// The list of domains to associate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Domains { get; set; }
    
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
