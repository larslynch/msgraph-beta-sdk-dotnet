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
    /// The type Cloud Pc On Premises Connection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CloudPcOnPremisesConnection : Entity
    {
    
		///<summary>
		/// The CloudPcOnPremisesConnection constructor
		///</summary>
        public CloudPcOnPremisesConnection()
        {
            this.ODataType = "microsoft.graph.cloudPcOnPremisesConnection";
        }
	
        /// <summary>
        /// Gets or sets ad domain name.
        /// The fully qualified domain name (FQDN) of the Active Directory domain you want to join.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "adDomainName", Required = Newtonsoft.Json.Required.Default)]
        public string AdDomainName { get; set; }
    
        /// <summary>
        /// Gets or sets ad domain password.
        /// The password associated with adDomainUsername.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "adDomainPassword", Required = Newtonsoft.Json.Required.Default)]
        public string AdDomainPassword { get; set; }
    
        /// <summary>
        /// Gets or sets ad domain username.
        /// The username of an Active Directory account (user or service account) that has permissions to create computer objects in Active Directory. Required format: admin@contoso.com.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "adDomainUsername", Required = Newtonsoft.Json.Required.Default)]
        public string AdDomainUsername { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the on-premises connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets health check status.
        /// The status of the most recent health check done on the on-premises connection. For example, if status is 'passed', the on-premises connection has passed all checks run by the service. Possible values are: pending, running, passed, failed, unknownFutureValue. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "healthCheckStatus", Required = Newtonsoft.Json.Required.Default)]
        public CloudPcOnPremisesConnectionStatus? HealthCheckStatus { get; set; }
    
        /// <summary>
        /// Gets or sets health check status details.
        /// The details of the connection's health checks and the corresponding results. Returned only on $select.For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an on-premises connection, including healthCheckStatusDetails. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "healthCheckStatusDetails", Required = Newtonsoft.Json.Required.Default)]
        public CloudPcOnPremisesConnectionStatusDetails HealthCheckStatusDetails { get; set; }
    
        /// <summary>
        /// Gets or sets in use.
        /// When true, the on-premises connection is in use. When false, the connection is not in use. You cannot delete a connection that’s in use. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an on-premises connection, including healthCheckStatusDetails. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inUse", Required = Newtonsoft.Json.Required.Default)]
        public bool? InUse { get; set; }
    
        /// <summary>
        /// Gets or sets organizational unit.
        /// The organizational unit (OU) in which the computer account is created. If left null, the OU that’s configured as the default (a well-known computer object container) in your Active Directory domain (OU) is used. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizationalUnit", Required = Newtonsoft.Json.Required.Default)]
        public string OrganizationalUnit { get; set; }
    
        /// <summary>
        /// Gets or sets resource group id.
        /// The ID of the target resource group. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceGroupId", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceGroupId { get; set; }
    
        /// <summary>
        /// Gets or sets subnet id.
        /// The ID of the target subnet. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkId}/subnets/{subnetName}'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subnetId", Required = Newtonsoft.Json.Required.Default)]
        public string SubnetId { get; set; }
    
        /// <summary>
        /// Gets or sets subscription id.
        /// The ID of the target Azure subscription that’s associated with your tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptionId", Required = Newtonsoft.Json.Required.Default)]
        public string SubscriptionId { get; set; }
    
        /// <summary>
        /// Gets or sets subscription name.
        /// The name of the target Azure subscription. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subscriptionName", Required = Newtonsoft.Json.Required.Default)]
        public string SubscriptionName { get; set; }
    
        /// <summary>
        /// Gets or sets virtual network id.
        /// The ID of the target virtual network. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "virtualNetworkId", Required = Newtonsoft.Json.Required.Default)]
        public string VirtualNetworkId { get; set; }
    
    }
}

