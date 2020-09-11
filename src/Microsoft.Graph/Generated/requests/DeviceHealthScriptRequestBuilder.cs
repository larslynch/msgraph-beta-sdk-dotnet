// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DeviceHealthScriptRequestBuilder.
    /// </summary>
    public partial class DeviceHealthScriptRequestBuilder : EntityRequestBuilder, IDeviceHealthScriptRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceHealthScriptRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceHealthScriptRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceHealthScriptRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceHealthScriptRequest Request(IEnumerable<Option> options)
        {
            return new DeviceHealthScriptRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptAssignmentsCollectionRequestBuilder"/>.</returns>
        public IDeviceHealthScriptAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new DeviceHealthScriptAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceRunStates.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptDeviceRunStatesCollectionRequestBuilder"/>.</returns>
        public IDeviceHealthScriptDeviceRunStatesCollectionRequestBuilder DeviceRunStates
        {
            get
            {
                return new DeviceHealthScriptDeviceRunStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceRunStates"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RunSummary.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptRunSummaryRequestBuilder"/>.</returns>
        public IDeviceHealthScriptRunSummaryRequestBuilder RunSummary
        {
            get
            {
                return new DeviceHealthScriptRunSummaryRequestBuilder(this.AppendSegmentToRequestUrl("runSummary"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DeviceHealthScriptAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptAssignRequestBuilder"/>.</returns>
        public IDeviceHealthScriptAssignRequestBuilder Assign(
            IEnumerable<DeviceHealthScriptAssignment> deviceHealthScriptAssignments = null)
        {
            return new DeviceHealthScriptAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                deviceHealthScriptAssignments);
        }

        /// <summary>
        /// Gets the request builder for DeviceHealthScriptGetGlobalScriptHighestAvailableVersion.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptGetGlobalScriptHighestAvailableVersionRequestBuilder"/>.</returns>
        public IDeviceHealthScriptGetGlobalScriptHighestAvailableVersionRequestBuilder GetGlobalScriptHighestAvailableVersion()
        {
            return new DeviceHealthScriptGetGlobalScriptHighestAvailableVersionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getGlobalScriptHighestAvailableVersion"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for DeviceHealthScriptUpdateGlobalScript.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptUpdateGlobalScriptRequestBuilder"/>.</returns>
        public IDeviceHealthScriptUpdateGlobalScriptRequestBuilder UpdateGlobalScript(
            string version = null)
        {
            return new DeviceHealthScriptUpdateGlobalScriptRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.updateGlobalScript"),
                this.Client,
                version);
        }

        /// <summary>
        /// Gets the request builder for DeviceHealthScriptGetRemediationHistory.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptGetRemediationHistoryRequestBuilder"/>.</returns>
        public IDeviceHealthScriptGetRemediationHistoryRequestBuilder GetRemediationHistory()
        {
            return new DeviceHealthScriptGetRemediationHistoryRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getRemediationHistory"),
                this.Client);
        }
    
    }
}
