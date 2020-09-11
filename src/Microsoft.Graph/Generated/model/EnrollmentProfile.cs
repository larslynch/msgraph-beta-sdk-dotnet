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
    /// The type Enrollment Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EnrollmentProfile : Entity
    {
    
		///<summary>
		/// The EnrollmentProfile constructor
		///</summary>
        public EnrollmentProfile()
        {
            this.ODataType = "microsoft.graph.enrollmentProfile";
        }
	
        /// <summary>
        /// Gets or sets configuration endpoint url.
        /// Configuration endpoint url to use for Enrollment
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurationEndpointUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ConfigurationEndpointUrl { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the profile
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the profile
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enable authentication via company portal.
        /// Indicates to authenticate with Apple Setup Assistant instead of Company Portal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableAuthenticationViaCompanyPortal", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableAuthenticationViaCompanyPortal { get; set; }
    
        /// <summary>
        /// Gets or sets require company portal on setup assistant enrolled devices.
        /// Indicates that Company Portal is required on setup assistant enrolled devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireCompanyPortalOnSetupAssistantEnrolledDevices", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireCompanyPortalOnSetupAssistantEnrolledDevices { get; set; }
    
        /// <summary>
        /// Gets or sets requires user authentication.
        /// Indicates if the profile requires user authentication
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requiresUserAuthentication", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequiresUserAuthentication { get; set; }
    
    }
}

