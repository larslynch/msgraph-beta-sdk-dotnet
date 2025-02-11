// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Apple Vpn Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AppleVpnConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The internal AppleVpnConfiguration constructor
		///</summary>
        protected internal AppleVpnConfiguration()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets associated domains.
        /// Associated Domains
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "associatedDomains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AssociatedDomains { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication method for this VPN connection. Possible values are: certificate, usernameAndPassword, sharedSecret, derivedCredential, azureAD.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public VpnAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets connection name.
        /// Connection name displayed to the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionName", Required = Newtonsoft.Json.Required.Default)]
        public string ConnectionName { get; set; }
    
        /// <summary>
        /// Gets or sets connection type.
        /// Connection type. Possible values are: ciscoAnyConnect, pulseSecure, f5EdgeClient, dellSonicWallMobileConnect, checkPointCapsuleVpn, customVpn, ciscoIPSec, citrix, ciscoAnyConnectV2, paloAltoGlobalProtect, zscalerPrivateAccess, f5Access2018, citrixSso, paloAltoGlobalProtectV2, ikEv2, alwaysOn, microsoftTunnel, netMotionMobility, microsoftProtect.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionType", Required = Newtonsoft.Json.Required.Default)]
        public AppleVpnConnectionType? ConnectionType { get; set; }
    
        /// <summary>
        /// Gets or sets custom data.
        /// Custom data when connection type is set to Custom VPN. Use this field to enable functionality not supported by Intune, but available in your VPN solution. Contact your VPN vendor to learn how to add these key/value pairs. This collection can contain a maximum of 25 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customData", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValue> CustomData { get; set; }
    
        /// <summary>
        /// Gets or sets custom key value data.
        /// Custom data when connection type is set to Custom VPN. Use this field to enable functionality not supported by Intune, but available in your VPN solution. Contact your VPN vendor to learn how to add these key/value pairs. This collection can contain a maximum of 25 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customKeyValueData", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> CustomKeyValueData { get; set; }
    
        /// <summary>
        /// Gets or sets disable on demand user override.
        /// Toggle to prevent user from disabling automatic VPN in the Settings app
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disableOnDemandUserOverride", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisableOnDemandUserOverride { get; set; }
    
        /// <summary>
        /// Gets or sets enable per app.
        /// Setting this to true creates Per-App VPN payload which can later be associated with Apps that can trigger this VPN conneciton on the end user's iOS device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enablePerApp", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnablePerApp { get; set; }
    
        /// <summary>
        /// Gets or sets enable split tunneling.
        /// Send all network traffic through VPN.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableSplitTunneling", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableSplitTunneling { get; set; }
    
        /// <summary>
        /// Gets or sets excluded domains.
        /// Domains that are accessed through the public internet instead of through VPN, even when per-app VPN is activated
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "excludedDomains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ExcludedDomains { get; set; }
    
        /// <summary>
        /// Gets or sets identifier.
        /// Identifier provided by VPN vendor when connection type is set to Custom VPN. For example: Cisco AnyConnect uses an identifier of the form com.cisco.anyconnect.applevpn.plugin
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identifier", Required = Newtonsoft.Json.Required.Default)]
        public string Identifier { get; set; }
    
        /// <summary>
        /// Gets or sets login group or domain.
        /// Login group or domain when connection type is set to Dell SonicWALL Mobile Connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "loginGroupOrDomain", Required = Newtonsoft.Json.Required.Default)]
        public string LoginGroupOrDomain { get; set; }
    
        /// <summary>
        /// Gets or sets on demand rules.
        /// On-Demand Rules. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onDemandRules", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<VpnOnDemandRule> OnDemandRules { get; set; }
    
        /// <summary>
        /// Gets or sets opt in to device id sharing.
        /// Opt-In to sharing the device's Id to third-party vpn clients for use during network access control validation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "optInToDeviceIdSharing", Required = Newtonsoft.Json.Required.Default)]
        public bool? OptInToDeviceIdSharing { get; set; }
    
        /// <summary>
        /// Gets or sets provider type.
        /// Provider type for per-app VPN. Possible values are: notConfigured, appProxy, packetTunnel.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "providerType", Required = Newtonsoft.Json.Required.Default)]
        public VpnProviderType? ProviderType { get; set; }
    
        /// <summary>
        /// Gets or sets proxy server.
        /// Proxy Server.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyServer", Required = Newtonsoft.Json.Required.Default)]
        public VpnProxyServer ProxyServer { get; set; }
    
        /// <summary>
        /// Gets or sets realm.
        /// Realm when connection type is set to Pulse Secure.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "realm", Required = Newtonsoft.Json.Required.Default)]
        public string Realm { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// Role when connection type is set to Pulse Secure.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "role", Required = Newtonsoft.Json.Required.Default)]
        public string Role { get; set; }
    
        /// <summary>
        /// Gets or sets safari domains.
        /// Safari domains when this VPN per App setting is enabled. In addition to the apps associated with this VPN, Safari domains specified here will also be able to trigger this VPN connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "safariDomains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SafariDomains { get; set; }
    
        /// <summary>
        /// Gets or sets server.
        /// VPN Server on the network. Make sure end users can access this network location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "server", Required = Newtonsoft.Json.Required.Default)]
        public VpnServer Server { get; set; }
    
    }
}

