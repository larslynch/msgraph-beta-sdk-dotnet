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
    /// The type Win32LobAppRegistryRequirement.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Win32LobAppRegistryRequirement : Win32LobAppRequirement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppRegistryRequirement"/> class.
        /// </summary>
        public Win32LobAppRegistryRequirement()
        {
            this.ODataType = "microsoft.graph.win32LobAppRegistryRequirement";
        }

        /// <summary>
        /// Gets or sets check32BitOn64System.
        /// A value indicating whether this registry path is for checking 32-bit app on 64-bit system
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "check32BitOn64System", Required = Newtonsoft.Json.Required.Default)]
        public bool? Check32BitOn64System { get; set; }
    
        /// <summary>
        /// Gets or sets detectionType.
        /// The registry data detection type
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "detectionType", Required = Newtonsoft.Json.Required.Default)]
        public Win32LobAppRegistryDetectionType? DetectionType { get; set; }
    
        /// <summary>
        /// Gets or sets keyPath.
        /// The registry key path to detect Win32 Line of Business (LoB) app
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "keyPath", Required = Newtonsoft.Json.Required.Default)]
        public string KeyPath { get; set; }
    
        /// <summary>
        /// Gets or sets valueName.
        /// The registry value name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "valueName", Required = Newtonsoft.Json.Required.Default)]
        public string ValueName { get; set; }
    
    }
}
