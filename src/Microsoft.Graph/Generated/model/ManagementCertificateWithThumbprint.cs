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
    /// The type ManagementCertificateWithThumbprint.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ManagementCertificateWithThumbprint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementCertificateWithThumbprint"/> class.
        /// </summary>
        public ManagementCertificateWithThumbprint()
        {
            this.ODataType = "microsoft.graph.managementCertificateWithThumbprint";
        }

        /// <summary>
        /// Gets or sets certificate.
        /// The Base 64 encoded management certificate
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certificate", Required = Newtonsoft.Json.Required.Default)]
        public string Certificate { get; set; }
    
        /// <summary>
        /// Gets or sets thumbprint.
        /// The thumbprint of the management certificate
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "thumbprint", Required = Newtonsoft.Json.Required.Default)]
        public string Thumbprint { get; set; }
    
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
