// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Add To Review Set Operation.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AddToReviewSetOperation : CaseOperation
    {
    
		///<summary>
		/// The AddToReviewSetOperation constructor
		///</summary>
        public AddToReviewSetOperation()
        {
            this.ODataType = "microsoft.graph.ediscovery.addToReviewSetOperation";
        }
	
        /// <summary>
        /// Gets or sets review set.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reviewSet", Required = Newtonsoft.Json.Required.Default)]
        public ReviewSet ReviewSet { get; set; }
    
        /// <summary>
        /// Gets or sets source collection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceCollection", Required = Newtonsoft.Json.Required.Default)]
        public SourceCollection SourceCollection { get; set; }
    
    }
}

