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
    /// The type Dep Enrollment Base Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DepEnrollmentBaseProfile : EnrollmentProfile
    {
    
		///<summary>
		/// The internal DepEnrollmentBaseProfile constructor
		///</summary>
        protected internal DepEnrollmentBaseProfile()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets apple id disabled.
        /// Indicates if Apple id setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appleIdDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppleIdDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets apple pay disabled.
        /// Indicates if Apple pay setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applePayDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ApplePayDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets configuration web url.
        /// URL for setup assistant login
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configurationWebUrl", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConfigurationWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets device name template.
        /// Sets a literal or name pattern.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceNameTemplate", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceNameTemplate { get; set; }
    
        /// <summary>
        /// Gets or sets diagnostics disabled.
        /// Indicates if diagnostics setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "diagnosticsDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DiagnosticsDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets display tone setup disabled.
        /// Indicates if displaytone setup screen is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayToneSetupDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisplayToneSetupDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets is default.
        /// Indicates if this is the default profile
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDefault", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets is mandatory.
        /// Indicates if the profile is mandatory
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMandatory", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMandatory { get; set; }
    
        /// <summary>
        /// Gets or sets location disabled.
        /// Indicates if Location service setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locationDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? LocationDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets privacy pane disabled.
        /// Indicates if privacy screen is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "privacyPaneDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? PrivacyPaneDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets profile removal disabled.
        /// Indicates if the profile removal option is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileRemovalDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ProfileRemovalDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets restore blocked.
        /// Indicates if Restore setup pane is blocked
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "restoreBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? RestoreBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets screen time screen disabled.
        /// Indicates if screen timeout setup is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenTimeScreenDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenTimeScreenDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets siri disabled.
        /// Indicates if siri setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "siriDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SiriDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets supervised mode enabled.
        /// Supervised mode, True to enable, false otherwise. See https://docs.microsoft.com/en-us/intune/deploy-use/enroll-devices-in-microsoft-intune for additional information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supervisedModeEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SupervisedModeEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets support department.
        /// Support department information
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportDepartment", Required = Newtonsoft.Json.Required.Default)]
        public string SupportDepartment { get; set; }
    
        /// <summary>
        /// Gets or sets support phone number.
        /// Support phone number
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportPhoneNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SupportPhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets terms and conditions disabled.
        /// Indicates if 'Terms and Conditions' setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "termsAndConditionsDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? TermsAndConditionsDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets touch id disabled.
        /// Indicates if touch id setup pane is disabled
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "touchIdDisabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? TouchIdDisabled { get; set; }
    
    }
}

