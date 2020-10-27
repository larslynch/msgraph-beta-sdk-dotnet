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
    /// The type Android Device Owner Enrollment Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidDeviceOwnerEnrollmentProfile : Entity
    {
    
		///<summary>
		/// The AndroidDeviceOwnerEnrollmentProfile constructor
		///</summary>
        public AndroidDeviceOwnerEnrollmentProfile()
        {
            this.ODataType = "microsoft.graph.androidDeviceOwnerEnrollmentProfile";
        }
	
        /// <summary>
        /// Gets or sets account id.
        /// Tenant GUID the enrollment profile belongs to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountId", Required = Newtonsoft.Json.Required.Default)]
        public string AccountId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date time the enrollment profile was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description for the enrollment profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name for the enrollment profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enrolled device count.
        /// Total number of Android devices that have enrolled using this enrollment profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrolledDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? EnrolledDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment mode.
        /// The enrollment mode of devices that use this enrollment profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentMode", Required = Newtonsoft.Json.Required.Default)]
        public AndroidDeviceOwnerEnrollmentMode? EnrollmentMode { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment token type.
        /// The enrollment token type for an enrollment profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentTokenType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidDeviceOwnerEnrollmentTokenType? EnrollmentTokenType { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Date time the enrollment profile was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets qr code content.
        /// String used to generate a QR code for the token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qrCodeContent", Required = Newtonsoft.Json.Required.Default)]
        public string QrCodeContent { get; set; }
    
        /// <summary>
        /// Gets or sets qr code image.
        /// String used to generate a QR code for the token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qrCodeImage", Required = Newtonsoft.Json.Required.Default)]
        public MimeContent QrCodeImage { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets token creation date time.
        /// Date time the most recently created token was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenCreationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? TokenCreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets token expiration date time.
        /// Date time the most recently created token will expire.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenExpirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? TokenExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets token value.
        /// Value of the most recently created token for this enrollment profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenValue", Required = Newtonsoft.Json.Required.Default)]
        public string TokenValue { get; set; }
    
    }
}

