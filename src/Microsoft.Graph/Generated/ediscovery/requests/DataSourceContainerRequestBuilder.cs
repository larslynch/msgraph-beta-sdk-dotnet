// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DataSourceContainerRequestBuilder.
    /// </summary>
    public partial class DataSourceContainerRequestBuilder : Microsoft.Graph.EntityRequestBuilder, IDataSourceContainerRequestBuilder
    {

        /// <summary>
        /// Constructs a new DataSourceContainerRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public DataSourceContainerRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDataSourceContainerRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDataSourceContainerRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new DataSourceContainerRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for LastIndexOperation.
        /// </summary>
        /// <returns>The <see cref="ICaseIndexOperationWithReferenceRequestBuilder"/>.</returns>
        public ICaseIndexOperationWithReferenceRequestBuilder LastIndexOperation
        {
            get
            {
                return new CaseIndexOperationWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("lastIndexOperation"), this.Client);
            }
        }
    
    }
}
