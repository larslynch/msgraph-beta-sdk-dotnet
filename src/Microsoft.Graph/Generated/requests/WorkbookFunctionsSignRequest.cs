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
    /// The type WorkbookFunctionsSignRequest.
    /// </summary>
    public partial class WorkbookFunctionsSignRequest : BaseRequest, IWorkbookFunctionsSignRequest
    {
        /// <summary>
        /// Constructs a new WorkbookFunctionsSignRequest.
        /// </summary>
        public WorkbookFunctionsSignRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.RequestBody = new WorkbookFunctionsSignRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public WorkbookFunctionsSignRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<WorkbookFunctionResult> PostAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "POST";
            return this.SendAsync<WorkbookFunctionResult>(this.RequestBody, cancellationToken);
        }

        /// <summary>
        /// Issues the POST request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WorkbookFunctionResult>> PostResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WorkbookFunctionResult>(this.RequestBody, cancellationToken).ConfigureAwait(false);
        }



        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookFunctionsSignRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookFunctionsSignRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
