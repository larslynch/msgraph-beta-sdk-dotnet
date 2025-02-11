// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The enum CloudPcOnPremisesConnectionHealthCheckErrorType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum CloudPcOnPremisesConnectionHealthCheckErrorType
    {
    
        /// <summary>
        /// Dns Check Fqdn Not Found
        /// </summary>
        DnsCheckFqdnNotFound = 100,
	
        /// <summary>
        /// Dns Check Unknown Error
        /// </summary>
        DnsCheckUnknownError = 199,
	
        /// <summary>
        /// Ad Join Check Fqdn Not Found
        /// </summary>
        AdJoinCheckFqdnNotFound = 200,
	
        /// <summary>
        /// Ad Join Check Incorrect Credentials
        /// </summary>
        AdJoinCheckIncorrectCredentials = 201,
	
        /// <summary>
        /// Ad Join Check Organizational Unit Not Found
        /// </summary>
        AdJoinCheckOrganizationalUnitNotFound = 202,
	
        /// <summary>
        /// Ad Join Check Organizational Unit Incorrect Format
        /// </summary>
        AdJoinCheckOrganizationalUnitIncorrectFormat = 203,
	
        /// <summary>
        /// Ad Join Check Unknown Error
        /// </summary>
        AdJoinCheckUnknownError = 299,
	
        /// <summary>
        /// Endpoint Connectivity Check Url Not Whitelisted
        /// </summary>
        EndpointConnectivityCheckUrlNotWhitelisted = 300,
	
        /// <summary>
        /// Endpoint Connectivity Check Unknown Error
        /// </summary>
        EndpointConnectivityCheckUnknownError = 399,
	
        /// <summary>
        /// Aad Connectivity Check Unknown Error
        /// </summary>
        AadConnectivityCheckUnknownError = 499,
	
        /// <summary>
        /// Resource Availability Check No Subnet IP
        /// </summary>
        ResourceAvailabilityCheckNoSubnetIP = 500,
	
        /// <summary>
        /// Resource Availability Check Subscription Disabled
        /// </summary>
        ResourceAvailabilityCheckSubscriptionDisabled = 501,
	
        /// <summary>
        /// Resource Availability Check Unknown Error
        /// </summary>
        ResourceAvailabilityCheckUnknownError = 599,
	
        /// <summary>
        /// Permission Check No Subscription Reader Role
        /// </summary>
        PermissionCheckNoSubscriptionReaderRole = 600,
	
        /// <summary>
        /// Permission Check No Resource Group Owner Role
        /// </summary>
        PermissionCheckNoResourceGroupOwnerRole = 601,
	
        /// <summary>
        /// Permission Check No VNet Contributor Role
        /// </summary>
        PermissionCheckNoVNetContributorRole = 602,
	
        /// <summary>
        /// Permission Check Unknown Error
        /// </summary>
        PermissionCheckUnknownError = 699,
	
        /// <summary>
        /// Internal Server Unknown Error
        /// </summary>
        InternalServerUnknownError = 999,
	
    }
}
