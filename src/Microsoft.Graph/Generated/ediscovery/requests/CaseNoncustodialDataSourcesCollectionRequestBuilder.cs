// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type CaseNoncustodialDataSourcesCollectionRequestBuilder.
    /// </summary>
    public partial class CaseNoncustodialDataSourcesCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, ICaseNoncustodialDataSourcesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CaseNoncustodialDataSourcesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public CaseNoncustodialDataSourcesCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICaseNoncustodialDataSourcesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICaseNoncustodialDataSourcesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new CaseNoncustodialDataSourcesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="INoncustodialDataSourceRequestBuilder"/> for the specified CaseNoncustodialDataSource.
        /// </summary>
        /// <param name="id">The ID for the CaseNoncustodialDataSource.</param>
        /// <returns>The <see cref="INoncustodialDataSourceRequestBuilder"/>.</returns>
        public INoncustodialDataSourceRequestBuilder this[string id]
        {
            get
            {
                return new NoncustodialDataSourceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
