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
    /// The enum AndroidVpnConnectionType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AndroidVpnConnectionType
    {
    
        /// <summary>
        /// Cisco Any Connect
        /// </summary>
        CiscoAnyConnect = 0,
	
        /// <summary>
        /// Pulse Secure
        /// </summary>
        PulseSecure = 1,
	
        /// <summary>
        /// F5Edge Client
        /// </summary>
        F5EdgeClient = 2,
	
        /// <summary>
        /// Dell Sonic Wall Mobile Connect
        /// </summary>
        DellSonicWallMobileConnect = 3,
	
        /// <summary>
        /// Check Point Capsule Vpn
        /// </summary>
        CheckPointCapsuleVpn = 4,
	
        /// <summary>
        /// Citrix
        /// </summary>
        Citrix = 5,
	
        /// <summary>
        /// Microsoft Tunnel
        /// </summary>
        MicrosoftTunnel = 7,
	
        /// <summary>
        /// Net Motion Mobility
        /// </summary>
        NetMotionMobility = 8,
	
    }
}
