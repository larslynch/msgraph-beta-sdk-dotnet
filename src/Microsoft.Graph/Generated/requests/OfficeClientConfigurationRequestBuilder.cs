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
    /// The type OfficeClientConfigurationRequestBuilder.
    /// </summary>
    public partial class OfficeClientConfigurationRequestBuilder : EntityRequestBuilder, IOfficeClientConfigurationRequestBuilder
    {

        /// <summary>
        /// Constructs a new OfficeClientConfigurationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OfficeClientConfigurationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOfficeClientConfigurationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOfficeClientConfigurationRequest Request(IEnumerable<Option> options)
        {
            return new OfficeClientConfigurationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IOfficeClientConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        public IOfficeClientConfigurationAssignmentsCollectionRequestBuilder Assignments
        {
            get
            {
                return new OfficeClientConfigurationAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignments"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for PolicyPayload.
        /// </summary>
        /// <returns>The <see cref="IOfficeClientConfigurationPolicyPayloadRequestBuilder"/>.</returns>
        public IOfficeClientConfigurationPolicyPayloadRequestBuilder PolicyPayload
        {
            get
            {
                return new OfficeClientConfigurationPolicyPayloadRequestBuilder(this.AppendSegmentToRequestUrl("policyPayload"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserPreferencePayload.
        /// </summary>
        /// <returns>The <see cref="IOfficeClientConfigurationUserPreferencePayloadRequestBuilder"/>.</returns>
        public IOfficeClientConfigurationUserPreferencePayloadRequestBuilder UserPreferencePayload
        {
            get
            {
                return new OfficeClientConfigurationUserPreferencePayloadRequestBuilder(this.AppendSegmentToRequestUrl("userPreferencePayload"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for OfficeClientConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="IOfficeClientConfigurationAssignRequestBuilder"/>.</returns>
        public IOfficeClientConfigurationAssignRequestBuilder Assign(
            IEnumerable<OfficeClientConfigurationAssignment> officeConfigurationAssignments = null)
        {
            return new OfficeClientConfigurationAssignRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assign"),
                this.Client,
                officeConfigurationAssignments);
        }
    
    }
}
