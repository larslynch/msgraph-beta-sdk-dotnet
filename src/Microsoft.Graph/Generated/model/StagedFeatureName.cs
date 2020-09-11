// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum StagedFeatureName.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum StagedFeatureName
    {
    
        /// <summary>
        /// Passthrough Authentication
        /// </summary>
        PassthroughAuthentication = 0,
	
        /// <summary>
        /// Seamless Sso
        /// </summary>
        SeamlessSso = 1,
	
        /// <summary>
        /// Password Hash Sync
        /// </summary>
        PasswordHashSync = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
        /// <summary>
        /// Email As Alternate Id
        /// </summary>
        EmailAsAlternateId = 3,
	
    }
}
