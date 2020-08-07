// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type IdentityContainerB2cUserFlowsCollectionRequestBuilder.
    /// </summary>
    public partial class IdentityContainerB2cUserFlowsCollectionRequestBuilder : BaseRequestBuilder, IIdentityContainerB2cUserFlowsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new IdentityContainerB2cUserFlowsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public IdentityContainerB2cUserFlowsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IIdentityContainerB2cUserFlowsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IIdentityContainerB2cUserFlowsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new IdentityContainerB2cUserFlowsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IB2cIdentityUserFlowRequestBuilder"/> for the specified IdentityContainerB2cIdentityUserFlow.
        /// </summary>
        /// <param name="id">The ID for the IdentityContainerB2cIdentityUserFlow.</param>
        /// <returns>The <see cref="IB2cIdentityUserFlowRequestBuilder"/>.</returns>
        public IB2cIdentityUserFlowRequestBuilder this[string id]
        {
            get
            {
                return new B2cIdentityUserFlowRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
