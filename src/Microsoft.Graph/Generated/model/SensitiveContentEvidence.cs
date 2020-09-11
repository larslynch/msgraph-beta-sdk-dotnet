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
    /// The type SensitiveContentEvidence.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class SensitiveContentEvidence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensitiveContentEvidence"/> class.
        /// </summary>
        public SensitiveContentEvidence()
        {
            this.ODataType = "microsoft.graph.sensitiveContentEvidence";
        }

        /// <summary>
        /// Gets or sets length.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "length", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Length { get; set; }
    
        /// <summary>
        /// Gets or sets match.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "match", Required = Newtonsoft.Json.Required.Default)]
        public string Match { get; set; }
    
        /// <summary>
        /// Gets or sets offset.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "offset", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Offset { get; set; }
    
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
