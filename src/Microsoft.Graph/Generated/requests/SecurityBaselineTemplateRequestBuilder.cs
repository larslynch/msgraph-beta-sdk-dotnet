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
    /// The type SecurityBaselineTemplateRequestBuilder.
    /// </summary>
    public partial class SecurityBaselineTemplateRequestBuilder : DeviceManagementTemplateRequestBuilder, ISecurityBaselineTemplateRequestBuilder
    {

        /// <summary>
        /// Constructs a new SecurityBaselineTemplateRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SecurityBaselineTemplateRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISecurityBaselineTemplateRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISecurityBaselineTemplateRequest Request(IEnumerable<Option> options)
        {
            return new SecurityBaselineTemplateRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for CategoryDeviceStateSummaries.
        /// </summary>
        /// <returns>The <see cref="ISecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequestBuilder"/>.</returns>
        public ISecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequestBuilder CategoryDeviceStateSummaries
        {
            get
            {
                return new SecurityBaselineTemplateCategoryDeviceStateSummariesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("categoryDeviceStateSummaries"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStates.
        /// </summary>
        /// <returns>The <see cref="ISecurityBaselineTemplateDeviceStatesCollectionRequestBuilder"/>.</returns>
        public ISecurityBaselineTemplateDeviceStatesCollectionRequestBuilder DeviceStates
        {
            get
            {
                return new SecurityBaselineTemplateDeviceStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceStates"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceStateSummary.
        /// </summary>
        /// <returns>The <see cref="ISecurityBaselineStateSummaryRequestBuilder"/>.</returns>
        public ISecurityBaselineStateSummaryRequestBuilder DeviceStateSummary
        {
            get
            {
                return new SecurityBaselineStateSummaryRequestBuilder(this.AppendSegmentToRequestUrl("deviceStateSummary"), this.Client);
            }
        }
    
    }
}
