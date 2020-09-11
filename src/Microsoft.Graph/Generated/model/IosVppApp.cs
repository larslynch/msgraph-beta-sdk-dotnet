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
    /// The type Ios Vpp App.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosVppApp : MobileApp
    {
    
		///<summary>
		/// The IosVppApp constructor
		///</summary>
        public IosVppApp()
        {
            this.ODataType = "microsoft.graph.iosVppApp";
        }
	
        /// <summary>
        /// Gets or sets applicable device type.
        /// The applicable iOS Device Type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicableDeviceType", Required = Newtonsoft.Json.Required.Default)]
        public IosDeviceType ApplicableDeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets app store url.
        /// The store URL.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appStoreUrl", Required = Newtonsoft.Json.Required.Default)]
        public string AppStoreUrl { get; set; }
    
        /// <summary>
        /// Gets or sets bundle id.
        /// The Identity Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bundleId", Required = Newtonsoft.Json.Required.Default)]
        public string BundleId { get; set; }
    
        /// <summary>
        /// Gets or sets licensing type.
        /// The supported License Type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licensingType", Required = Newtonsoft.Json.Required.Default)]
        public VppLicensingType LicensingType { get; set; }
    
        /// <summary>
        /// Gets or sets release date time.
        /// The VPP application release date and time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "releaseDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ReleaseDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets revoke license action results.
        /// Results of revoke license actions on this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "revokeLicenseActionResults", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<IosVppAppRevokeLicensesActionResult> RevokeLicenseActionResults { get; set; }
    
        /// <summary>
        /// Gets or sets total license count.
        /// The total number of VPP licenses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalLicenseCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets used license count.
        /// The number of VPP licenses in use.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usedLicenseCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UsedLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets vpp token account type.
        /// The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: business, education. Possible values are: business, education.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vppTokenAccountType", Required = Newtonsoft.Json.Required.Default)]
        public VppTokenAccountType? VppTokenAccountType { get; set; }
    
        /// <summary>
        /// Gets or sets vpp token apple id.
        /// The Apple Id associated with the given Apple Volume Purchase Program Token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vppTokenAppleId", Required = Newtonsoft.Json.Required.Default)]
        public string VppTokenAppleId { get; set; }
    
        /// <summary>
        /// Gets or sets vpp token id.
        /// Identifier of the VPP token associated with this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vppTokenId", Required = Newtonsoft.Json.Required.Default)]
        public string VppTokenId { get; set; }
    
        /// <summary>
        /// Gets or sets vpp token organization name.
        /// The organization associated with the Apple Volume Purchase Program Token
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vppTokenOrganizationName", Required = Newtonsoft.Json.Required.Default)]
        public string VppTokenOrganizationName { get; set; }
    
        /// <summary>
        /// Gets or sets assigned licenses.
        /// The licenses assigned to this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedLicenses", Required = Newtonsoft.Json.Required.Default)]
        public IIosVppAppAssignedLicensesCollectionPage AssignedLicenses { get; set; }
    
    }
}

