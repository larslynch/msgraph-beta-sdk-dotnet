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
    /// The type App Consent Request.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AppConsentRequestObject : Entity
    {
    
		///<summary>
		/// The AppConsentRequest constructor
		///</summary>
        public AppConsentRequestObject()
        {
            this.ODataType = "microsoft.graph.appConsentRequest";
        }
	
        /// <summary>
        /// Gets or sets app display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appId", Required = Newtonsoft.Json.Required.Default)]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets consent type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "consentType", Required = Newtonsoft.Json.Required.Default)]
        public string ConsentType { get; set; }
    
        /// <summary>
        /// Gets or sets pending scopes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pendingScopes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppConsentRequestScope> PendingScopes { get; set; }
    
        /// <summary>
        /// Gets or sets user consent requests.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userConsentRequests", Required = Newtonsoft.Json.Required.Default)]
        public IAppConsentRequestUserConsentRequestsCollectionPage UserConsentRequests { get; set; }
    
    }
}

