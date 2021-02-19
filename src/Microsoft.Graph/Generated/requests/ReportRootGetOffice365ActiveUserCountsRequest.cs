// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type ReportRootGetOffice365ActiveUserCountsRequest.
    /// </summary>
    public partial class ReportRootGetOffice365ActiveUserCountsRequest : BaseRequest, IReportRootGetOffice365ActiveUserCountsRequest
    {
        /// <summary>
        /// Constructs a new ReportRootGetOffice365ActiveUserCountsRequest.
        /// </summary>
        public ReportRootGetOffice365ActiveUserCountsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetOffice365ActiveUserCountsCollectionPage> GetAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "GET";
            var response = await this.SendAsync<ReportRootGetOffice365ActiveUserCountsCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;

                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ReportRootGetOffice365ActiveUserCountsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<ReportRootGetOffice365ActiveUserCountsCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="office365activeusercounts">The Office365ActiveUserCounts object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetOffice365ActiveUserCountsCollectionPage> PatchAsync(Office365ActiveUserCounts office365activeusercounts, 
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "PATCH";
            var response = await this.SendAsync<ReportRootGetOffice365ActiveUserCountsCollectionResponse>(office365activeusercounts, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;

                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the PATCH request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="office365activeusercounts">The Office365ActiveUserCounts object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ReportRootGetOffice365ActiveUserCountsCollectionResponse>> PatchResponseAsync(Office365ActiveUserCounts office365activeusercounts, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<ReportRootGetOffice365ActiveUserCountsCollectionResponse>(office365activeusercounts, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="office365activeusercounts">The Office365ActiveUserCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IReportRootGetOffice365ActiveUserCountsCollectionPage> PutAsync(Office365ActiveUserCounts office365activeusercounts, 
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "PUT";
            var response = await this.SendAsync<ReportRootGetOffice365ActiveUserCountsCollectionResponse>(office365activeusercounts, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;

                    object nextPageLink;
                    response.AdditionalData.TryGetValue("@odata.nextLink", out nextPageLink);

                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        response.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the PUT request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="office365activeusercounts">The Office365ActiveUserCounts object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ReportRootGetOffice365ActiveUserCountsCollectionResponse>> PutResponseAsync(Office365ActiveUserCounts office365activeusercounts, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "PUT";
            return await this.SendAsyncWithGraphResponse<ReportRootGetOffice365ActiveUserCountsCollectionResponse>(office365activeusercounts, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserCountsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserCountsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserCountsRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserCountsRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserCountsRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootGetOffice365ActiveUserCountsRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
