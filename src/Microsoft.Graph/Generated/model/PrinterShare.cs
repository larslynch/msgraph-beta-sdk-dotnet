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
    /// The type Printer Share.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PrinterShare : PrinterBase
    {
    
		///<summary>
		/// The PrinterShare constructor
		///</summary>
        public PrinterShare()
        {
            this.ODataType = "microsoft.graph.printerShare";
        }
	
        /// <summary>
        /// Gets or sets allow all users.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowAllUsers", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowAllUsers { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets allowed groups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedGroups", Required = Newtonsoft.Json.Required.Default)]
        public IPrinterShareAllowedGroupsCollectionPage AllowedGroups { get; set; }
    
        /// <summary>
        /// Gets or sets allowed users.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedUsers", Required = Newtonsoft.Json.Required.Default)]
        public IPrinterShareAllowedUsersCollectionPage AllowedUsers { get; set; }
    
        /// <summary>
        /// Gets or sets printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "printer", Required = Newtonsoft.Json.Required.Default)]
        public Printer Printer { get; set; }
    
    }
}

