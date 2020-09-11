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
    /// The type Language Proficiency.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class LanguageProficiency : ItemFacet
    {
    
		///<summary>
		/// The LanguageProficiency constructor
		///</summary>
        public LanguageProficiency()
        {
            this.ODataType = "microsoft.graph.languageProficiency";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets proficiency.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proficiency", Required = Newtonsoft.Json.Required.Default)]
        public LanguageProficiencyLevel? Proficiency { get; set; }
    
        /// <summary>
        /// Gets or sets reading.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reading", Required = Newtonsoft.Json.Required.Default)]
        public LanguageProficiencyLevel? Reading { get; set; }
    
        /// <summary>
        /// Gets or sets spoken.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "spoken", Required = Newtonsoft.Json.Required.Default)]
        public LanguageProficiencyLevel? Spoken { get; set; }
    
        /// <summary>
        /// Gets or sets tag.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tag", Required = Newtonsoft.Json.Required.Default)]
        public string Tag { get; set; }
    
        /// <summary>
        /// Gets or sets written.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "written", Required = Newtonsoft.Json.Required.Default)]
        public LanguageProficiencyLevel? Written { get; set; }
    
    }
}

