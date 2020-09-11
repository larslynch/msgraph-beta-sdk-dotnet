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
    /// The type ChannelModerationSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ChannelModerationSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelModerationSettings"/> class.
        /// </summary>
        public ChannelModerationSettings()
        {
            this.ODataType = "microsoft.graph.channelModerationSettings";
        }

        /// <summary>
        /// Gets or sets allowNewMessageFromBots.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowNewMessageFromBots", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowNewMessageFromBots { get; set; }
    
        /// <summary>
        /// Gets or sets allowNewMessageFromConnectors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowNewMessageFromConnectors", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowNewMessageFromConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets replyRestriction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replyRestriction", Required = Newtonsoft.Json.Required.Default)]
        public ReplyRestriction? ReplyRestriction { get; set; }
    
        /// <summary>
        /// Gets or sets userNewMessageRestriction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userNewMessageRestriction", Required = Newtonsoft.Json.Required.Default)]
        public UserNewMessageRestriction? UserNewMessageRestriction { get; set; }
    
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
