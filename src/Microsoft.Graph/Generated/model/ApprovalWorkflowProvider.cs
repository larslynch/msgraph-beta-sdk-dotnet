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
    /// The type Approval Workflow Provider.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ApprovalWorkflowProvider : Entity
    {
    
		///<summary>
		/// The ApprovalWorkflowProvider constructor
		///</summary>
        public ApprovalWorkflowProvider()
        {
            this.ODataType = "microsoft.graph.approvalWorkflowProvider";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets business flows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessFlows", Required = Newtonsoft.Json.Required.Default)]
        public IApprovalWorkflowProviderBusinessFlowsCollectionPage BusinessFlows { get; set; }
    
        /// <summary>
        /// Gets or sets business flows with requests awaiting my decision.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessFlowsWithRequestsAwaitingMyDecision", Required = Newtonsoft.Json.Required.Default)]
        public IApprovalWorkflowProviderBusinessFlowsWithRequestsAwaitingMyDecisionCollectionPage BusinessFlowsWithRequestsAwaitingMyDecision { get; set; }
    
        /// <summary>
        /// Gets or sets policy templates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyTemplates", Required = Newtonsoft.Json.Required.Default)]
        public IApprovalWorkflowProviderPolicyTemplatesCollectionPage PolicyTemplates { get; set; }
    
    }
}

