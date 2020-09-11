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
    /// The type Print Task.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrintTask : Entity
    {
    
		///<summary>
		/// The PrintTask constructor
		///</summary>
        public PrintTask()
        {
            this.ODataType = "microsoft.graph.printTask";
        }
	
        /// <summary>
        /// Gets or sets parent url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ParentUrl { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public PrintTaskStatus Status { get; set; }
    
        /// <summary>
        /// Gets or sets definition.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "definition", Required = Newtonsoft.Json.Required.Default)]
        public PrintTaskDefinition Definition { get; set; }
    
        /// <summary>
        /// Gets or sets trigger.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trigger", Required = Newtonsoft.Json.Required.Default)]
        public PrintTaskTrigger Trigger { get; set; }
    
    }
}

