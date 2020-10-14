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
    /// The type PrintJobStatus.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PrintJobStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintJobStatus"/> class.
        /// </summary>
        public PrintJobStatus()
        {
            this.ODataType = "microsoft.graph.printJobStatus";
        }

        /// <summary>
        /// Gets or sets acquiredByPrinter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "acquiredByPrinter", Required = Newtonsoft.Json.Required.Default)]
        public bool? AcquiredByPrinter { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "details", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrintJobStateDetail> Details { get; set; }
    
        /// <summary>
        /// Gets or sets isAcquiredByPrinter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isAcquiredByPrinter", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsAcquiredByPrinter { get; set; }
    
        /// <summary>
        /// Gets or sets processingState.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processingState", Required = Newtonsoft.Json.Required.Default)]
        public PrintJobProcessingState? ProcessingState { get; set; }
    
        /// <summary>
        /// Gets or sets processingStateDescription.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processingStateDescription", Required = Newtonsoft.Json.Required.Default)]
        public string ProcessingStateDescription { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public PrintJobProcessingState? State { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
