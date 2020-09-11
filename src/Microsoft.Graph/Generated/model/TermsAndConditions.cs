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
    /// The type Terms And Conditions.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TermsAndConditions : Entity
    {
    
		///<summary>
		/// The TermsAndConditions constructor
		///</summary>
        public TermsAndConditions()
        {
            this.ODataType = "microsoft.graph.termsAndConditions";
        }
	
        /// <summary>
        /// Gets or sets acceptance statement.
        /// Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&amp;C policy. This is shown to the user on prompts to accept the T&amp;C policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "acceptanceStatement", Required = Newtonsoft.Json.Required.Default)]
        public string AcceptanceStatement { get; set; }
    
        /// <summary>
        /// Gets or sets body text.
        /// Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&amp;C policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bodyText", Required = Newtonsoft.Json.Required.Default)]
        public string BodyText { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// DateTime the object was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Administrator-supplied description of the T&amp;C policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Administrator-supplied name for the T&amp;C policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "modifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&amp;C policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "title", Required = Newtonsoft.Json.Required.Default)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&amp;C policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Version { get; set; }
    
        /// <summary>
        /// Gets or sets acceptance statuses.
        /// The list of acceptance statuses for this T&amp;C policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "acceptanceStatuses", Required = Newtonsoft.Json.Required.Default)]
        public ITermsAndConditionsAcceptanceStatusesCollectionPage AcceptanceStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of assignments for this T&amp;C policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public ITermsAndConditionsAssignmentsCollectionPage Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets group assignments.
        /// The list of group assignments for this T&amp;C policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupAssignments", Required = Newtonsoft.Json.Required.Default)]
        public ITermsAndConditionsGroupAssignmentsCollectionPage GroupAssignments { get; set; }
    
    }
}

