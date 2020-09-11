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
    /// The type DeviceManagementScriptRequestBuilder.
    /// </summary>
    public partial class DeviceManagementScriptRequestBuilder : EntityRequestBuilder, IDeviceManagementScriptRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceManagementScriptRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementScriptRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceManagementScriptRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceManagementScriptRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementScriptRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptAssignmentsCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementScriptAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new DeviceManagementScriptAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceRunStates.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptDeviceRunStatesCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementScriptDeviceRunStatesCollectionRequestBuilder DeviceRunStates
        {
            get
            {
                return new DeviceManagementScriptDeviceRunStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceRunStates"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for GroupAssignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptGroupAssignmentsCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementScriptGroupAssignmentsCollectionRequestBuilder GroupAssignments
        {
            get
            {
                return new DeviceManagementScriptGroupAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("groupAssignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RunSummary.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptRunSummaryWithReferenceRequestBuilder"/>.</returns>
        public IDeviceManagementScriptRunSummaryWithReferenceRequestBuilder RunSummary
        {
            get
            {
                return new DeviceManagementScriptRunSummaryWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("runSummary"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserRunStates.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptUserRunStatesCollectionRequestBuilder"/>.</returns>
        public IDeviceManagementScriptUserRunStatesCollectionRequestBuilder UserRunStates
        {
            get
            {
                return new DeviceManagementScriptUserRunStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userRunStates"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DeviceManagementScriptAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementScriptAssignRequestBuilder"/>.</returns>
        public IDeviceManagementScriptAssignRequestBuilder Assign(
            IEnumerable<DeviceManagementScriptGroupAssignment> deviceManagementScriptGroupAssignments = null,
            IEnumerable<DeviceManagementScriptAssignment> deviceManagementScriptAssignments = null)
        {
            return new DeviceManagementScriptAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                deviceManagementScriptGroupAssignments,
                deviceManagementScriptAssignments);
        }
    
    }
}
