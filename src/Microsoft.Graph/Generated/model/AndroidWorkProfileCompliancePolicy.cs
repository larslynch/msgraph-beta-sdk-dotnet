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
    /// The type Android Work Profile Compliance Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidWorkProfileCompliancePolicy : DeviceCompliancePolicy
    {
    
		///<summary>
		/// The AndroidWorkProfileCompliancePolicy constructor
		///</summary>
        public AndroidWorkProfileCompliancePolicy()
        {
            this.ODataType = "microsoft.graph.androidWorkProfileCompliancePolicy";
        }
	
        /// <summary>
        /// Gets or sets advanced threat protection required security level.
        /// MDATP Require Mobile Threat Protection minimum risk level to report noncompliance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "advancedThreatProtectionRequiredSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public DeviceThreatProtectionLevel? AdvancedThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection enabled.
        /// Require that devices have enabled device threat protection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceThreatProtectionEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DeviceThreatProtectionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection required security level.
        /// Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceThreatProtectionRequiredSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets min android security patch level.
        /// Minimum Android security patch level.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minAndroidSecurityPatchLevel", Required = Newtonsoft.Json.Required.Default)]
        public string MinAndroidSecurityPatchLevel { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum version.
        /// Maximum Android version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMaximumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// Minimum Android version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "osMinimumVersion", Required = Newtonsoft.Json.Required.Default)]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires. Valid values 1 to 365
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum password length. Valid values 4 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity before a password is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeLock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// Number of previous passwords to block. Valid values 1 to 24
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Require a password to unlock device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// Type of characters in password. Possible values are: deviceDefault, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, numeric, numericComplex, any.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidRequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password sign in failure count before factory reset.
        /// Number of sign-in failures allowed before factory reset. Valid values 1 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordSignInFailureCountBeforeFactoryReset", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
    
        /// <summary>
        /// Gets or sets security block jailbroken devices.
        /// Devices must not be jailbroken or rooted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityBlockJailbrokenDevices", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityBlockJailbrokenDevices { get; set; }
    
        /// <summary>
        /// Gets or sets security disable usb debugging.
        /// Disable USB debugging on Android devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityDisableUsbDebugging", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityDisableUsbDebugging { get; set; }
    
        /// <summary>
        /// Gets or sets security prevent install apps from unknown sources.
        /// Require that devices disallow installation of apps from unknown sources.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityPreventInstallAppsFromUnknownSources", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityPreventInstallAppsFromUnknownSources { get; set; }
    
        /// <summary>
        /// Gets or sets security require company portal app integrity.
        /// Require the device to pass the Company Portal client app runtime integrity check.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireCompanyPortalAppIntegrity", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireCompanyPortalAppIntegrity { get; set; }
    
        /// <summary>
        /// Gets or sets security require google play services.
        /// Require Google Play Services to be installed and enabled on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireGooglePlayServices", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireGooglePlayServices { get; set; }
    
        /// <summary>
        /// Gets or sets security require safety net attestation basic integrity.
        /// Require the device to pass the SafetyNet basic integrity check.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireSafetyNetAttestationBasicIntegrity", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireSafetyNetAttestationBasicIntegrity { get; set; }
    
        /// <summary>
        /// Gets or sets security require safety net attestation certified device.
        /// Require the device to pass the SafetyNet certified device check.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireSafetyNetAttestationCertifiedDevice", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireSafetyNetAttestationCertifiedDevice { get; set; }
    
        /// <summary>
        /// Gets or sets security require up to date security providers.
        /// Require the device to have up to date security providers. The device will require Google Play Services to be enabled and up to date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireUpToDateSecurityProviders", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireUpToDateSecurityProviders { get; set; }
    
        /// <summary>
        /// Gets or sets security require verify apps.
        /// Require the Android Verify apps feature is turned on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireVerifyApps", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireVerifyApps { get; set; }
    
        /// <summary>
        /// Gets or sets storage require encryption.
        /// Require encryption on Android devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageRequireEncryption", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageRequireEncryption { get; set; }
    
    }
}

