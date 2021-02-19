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
    /// The type DeviceManagementScopedForResourceRequest.
    /// </summary>
    public partial class DeviceManagementScopedForResourceRequest : BaseRequest, IDeviceManagementScopedForResourceRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementScopedForResourceRequest.
        /// </summary>
        public DeviceManagementScopedForResourceRequest(
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
        public async System.Threading.Tasks.Task<bool?> GetAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "GET";
            var response = await this.SendAsync<ODataMethodBooleanResponse>(null, cancellationToken);
            return response.Value;
        }

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ODataMethodBooleanResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<ODataMethodBooleanResponse>(null, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScopedForResourceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementScopedForResourceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
