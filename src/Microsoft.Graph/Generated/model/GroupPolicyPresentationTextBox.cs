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
    /// The type Group Policy Presentation Text Box.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupPolicyPresentationTextBox : GroupPolicyPresentation
    {
    
		///<summary>
		/// The GroupPolicyPresentationTextBox constructor
		///</summary>
        public GroupPolicyPresentationTextBox()
        {
            this.ODataType = "microsoft.graph.groupPolicyPresentationTextBox";
        }
	
        /// <summary>
        /// Gets or sets default value.
        /// Localized default string displayed in the text box. The default value is empty.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultValue", Required = Newtonsoft.Json.Required.Default)]
        public string DefaultValue { get; set; }
    
        /// <summary>
        /// Gets or sets max length.
        /// An unsigned integer that specifies the maximum number of text characters. Default value is 1023.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxLength", Required = Newtonsoft.Json.Required.Default)]
        public Int64? MaxLength { get; set; }
    
        /// <summary>
        /// Gets or sets required.
        /// Requirement to enter a value in the text box. Default value is false.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "required", Required = Newtonsoft.Json.Required.Default)]
        public bool? Required { get; set; }
    
    }
}

