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
    /// The type MobileAppTroubleshootingAppPolicyCreationHistory.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MobileAppTroubleshootingAppPolicyCreationHistory : MobileAppTroubleshootingHistoryItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAppTroubleshootingAppPolicyCreationHistory"/> class.
        /// </summary>
        public MobileAppTroubleshootingAppPolicyCreationHistory()
        {
            this.ODataType = "microsoft.graph.mobileAppTroubleshootingAppPolicyCreationHistory";
        }

        /// <summary>
        /// Gets or sets errorCode.
        /// Error code for the failure, empty if no failure.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCode", Required = Newtonsoft.Json.Required.Default)]
        public string ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets runState.
        /// Status of the item.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "runState", Required = Newtonsoft.Json.Required.Default)]
        public RunState? RunState { get; set; }
    
    }
}
