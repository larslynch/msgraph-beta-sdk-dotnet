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
    /// The type DeviceEnrollmentConfigurationRequestBuilder.
    /// </summary>
    public partial class DeviceEnrollmentConfigurationRequestBuilder : EntityRequestBuilder, IDeviceEnrollmentConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new DeviceEnrollmentConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceEnrollmentConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDeviceEnrollmentConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDeviceEnrollmentConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new DeviceEnrollmentConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        public IDeviceEnrollmentConfigurationAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new DeviceEnrollmentConfigurationAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for DeviceEnrollmentConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationAssignRequestBuilder"/>.</returns>
        public IDeviceEnrollmentConfigurationAssignRequestBuilder Assign(
            IEnumerable<EnrollmentConfigurationAssignment> enrollmentConfigurationAssignments = null)
        {
            return new DeviceEnrollmentConfigurationAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                enrollmentConfigurationAssignments);
        }

        /// <summary>
        /// Gets the request builder for DeviceEnrollmentConfigurationSetPriority.
        /// </summary>
        /// <returns>The <see cref="IDeviceEnrollmentConfigurationSetPriorityRequestBuilder"/>.</returns>
        public IDeviceEnrollmentConfigurationSetPriorityRequestBuilder SetPriority(
            Int32 priority)
        {
            return new DeviceEnrollmentConfigurationSetPriorityRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setPriority"),
                this.Client,
                priority);
        }
    
    }
}
