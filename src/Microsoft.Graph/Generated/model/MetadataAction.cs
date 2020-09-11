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
    /// The type MetadataAction.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MetadataAction : InformationProtectionAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataAction"/> class.
        /// </summary>
        public MetadataAction()
        {
            this.ODataType = "microsoft.graph.metadataAction";
        }

        /// <summary>
        /// Gets or sets metadataToAdd.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "metadataToAdd", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> MetadataToAdd { get; set; }
    
        /// <summary>
        /// Gets or sets metadataToRemove.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "metadataToRemove", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> MetadataToRemove { get; set; }
    
    }
}
