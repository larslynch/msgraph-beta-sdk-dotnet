// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type IosKerberosSingleSignOnExtension.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosKerberosSingleSignOnExtension : IosSingleSignOnExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosKerberosSingleSignOnExtension"/> class.
        /// </summary>
        public IosKerberosSingleSignOnExtension()
        {
            this.ODataType = "microsoft.graph.iosKerberosSingleSignOnExtension";
        }

        /// <summary>
        /// Gets or sets activeDirectorySiteCode.
        /// Gets or sets the Active Directory site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeDirectorySiteCode", Required = Newtonsoft.Json.Required.Default)]
        public string ActiveDirectorySiteCode { get; set; }
    
        /// <summary>
        /// Gets or sets blockActiveDirectorySiteAutoDiscovery.
        /// Enables or disables whether the Kerberos extension can automatically determine its site name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blockActiveDirectorySiteAutoDiscovery", Required = Newtonsoft.Json.Required.Default)]
        public bool? BlockActiveDirectorySiteAutoDiscovery { get; set; }
    
        /// <summary>
        /// Gets or sets blockAutomaticLogin.
        /// Enables or disables Keychain usage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blockAutomaticLogin", Required = Newtonsoft.Json.Required.Default)]
        public bool? BlockAutomaticLogin { get; set; }
    
        /// <summary>
        /// Gets or sets cacheName.
        /// Gets or sets the Generic Security Services name of the Kerberos cache to use for this profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cacheName", Required = Newtonsoft.Json.Required.Default)]
        public string CacheName { get; set; }
    
        /// <summary>
        /// Gets or sets credentialBundleIdAccessControlList.
        /// Gets or sets a list of app Bundle IDs allowed to access the Kerberos Ticket Granting Ticket.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credentialBundleIdAccessControlList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> CredentialBundleIdAccessControlList { get; set; }
    
        /// <summary>
        /// Gets or sets domainRealms.
        /// Gets or sets a list of realms for custom domain-realm mapping. Realms are case sensitive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domainRealms", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> DomainRealms { get; set; }
    
        /// <summary>
        /// Gets or sets domains.
        /// Gets or sets a list of hosts or domain names for which the app extension performs SSO.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "domains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Domains { get; set; }
    
        /// <summary>
        /// Gets or sets isDefaultRealm.
        /// When true, this profile's realm will be selected as the default. Necessary if multiple Kerberos-type profiles are configured.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDefaultRealm", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDefaultRealm { get; set; }
    
        /// <summary>
        /// Gets or sets passwordBlockModification.
        /// Enables or disables password changes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockModification", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockModification { get; set; }
    
        /// <summary>
        /// Gets or sets passwordChangeUrl.
        /// Gets or sets the URL that the user will be sent to when they initiate a password change.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordChangeUrl", Required = Newtonsoft.Json.Required.Default)]
        public string PasswordChangeUrl { get; set; }
    
        /// <summary>
        /// Gets or sets passwordEnableLocalSync.
        /// Enables or disables password syncing. This won't affect users logged in with a mobile account on macOS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordEnableLocalSync", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordEnableLocalSync { get; set; }
    
        /// <summary>
        /// Gets or sets passwordExpirationDays.
        /// Overrides the default password expiration in days. For most domains, this value is calculated automatically.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets passwordExpirationNotificationDays.
        /// Gets or sets the number of days until the user is notified that their password will expire (default is 15).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationNotificationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationNotificationDays { get; set; }
    
        /// <summary>
        /// Gets or sets passwordMinimumAgeDays.
        /// Gets or sets the minimum number of days until a user can change their password again.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumAgeDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumAgeDays { get; set; }
    
        /// <summary>
        /// Gets or sets passwordMinimumLength.
        /// Gets or sets the minimum length of a password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets passwordPreviousPasswordBlockCount.
        /// Gets or sets the number of previous passwords to block.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets passwordRequireActiveDirectoryComplexity.
        /// Enables or disables whether passwords must meet Active Directory's complexity requirements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequireActiveDirectoryComplexity", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordRequireActiveDirectoryComplexity { get; set; }
    
        /// <summary>
        /// Gets or sets passwordRequirementsDescription.
        /// Gets or sets a description of the password complexity requirements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequirementsDescription", Required = Newtonsoft.Json.Required.Default)]
        public string PasswordRequirementsDescription { get; set; }
    
        /// <summary>
        /// Gets or sets realm.
        /// Gets or sets the case-sensitive realm name for this profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "realm", Required = Newtonsoft.Json.Required.Default)]
        public string Realm { get; set; }
    
        /// <summary>
        /// Gets or sets requireUserPresence.
        /// Gets or sets whether to require authentication via Touch ID, Face ID, or a passcode to access the keychain entry.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireUserPresence", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireUserPresence { get; set; }
    
        /// <summary>
        /// Gets or sets userPrincipalName.
        /// Gets or sets the principle user name to use for this profile. The realm name does not need to be included.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
    }
}
