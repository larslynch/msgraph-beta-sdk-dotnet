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
    /// The type Windows81Trusted Root Certificate.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows81TrustedRootCertificate : DeviceConfiguration
    {
    
		///<summary>
		/// The Windows81TrustedRootCertificate constructor
		///</summary>
        public Windows81TrustedRootCertificate()
        {
            this.ODataType = "microsoft.graph.windows81TrustedRootCertificate";
        }
	
        /// <summary>
        /// Gets or sets cert file name.
        /// File name to display in UI.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "certFileName", Required = Newtonsoft.Json.Required.Default)]
        public string CertFileName { get; set; }
    
        /// <summary>
        /// Gets or sets destination store.
        /// Destination store location for the Trusted Root Certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "destinationStore", Required = Newtonsoft.Json.Required.Default)]
        public CertificateDestinationStore? DestinationStore { get; set; }
    
        /// <summary>
        /// Gets or sets trusted root certificate.
        /// Trusted Root Certificate
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trustedRootCertificate", Required = Newtonsoft.Json.Required.Default)]
        public byte[] TrustedRootCertificate { get; set; }
    
    }
}

