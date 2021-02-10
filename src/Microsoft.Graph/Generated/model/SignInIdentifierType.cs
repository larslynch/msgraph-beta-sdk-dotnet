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
    /// The enum SignInIdentifierType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SignInIdentifierType
    {
    
        /// <summary>
        /// User Principal Name
        /// </summary>
        UserPrincipalName = 0,
	
        /// <summary>
        /// Phone Number
        /// </summary>
        PhoneNumber = 1,
	
        /// <summary>
        /// Proxy Address
        /// </summary>
        ProxyAddress = 2,
	
        /// <summary>
        /// Qr Code
        /// </summary>
        QrCode = 3,
	
        /// <summary>
        /// On Premises User Principal Name
        /// </summary>
        OnPremisesUserPrincipalName = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
