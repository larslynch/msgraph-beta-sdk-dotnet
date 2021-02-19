// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type ApplicationTokenIssuancePoliciesCollectionReferencesRequest.
    /// </summary>
    public partial class ApplicationTokenIssuancePoliciesCollectionReferencesRequest : BaseRequest, IApplicationTokenIssuancePoliciesCollectionReferencesRequest
    {
        /// <summary>
        /// Constructs a new ApplicationTokenIssuancePoliciesCollectionReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ApplicationTokenIssuancePoliciesCollectionReferencesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified TokenIssuancePolicy to the collection via POST.
        /// </summary>
        /// <param name="tokenIssuancePolicy">The TokenIssuancePolicy to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(TokenIssuancePolicy tokenIssuancePolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";

            if (string.IsNullOrEmpty(tokenIssuancePolicy.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/policies/tokenIssuancePolicies/{1}", this.Client.BaseUrl, tokenIssuancePolicy.Id) };
            return this.SendAsync(requestBody, cancellationToken);
        }

        /// <summary>
        /// Adds the specified TokenIssuancePolicy to the collection via POST and returns a <see cref="GraphResponse{TokenIssuancePolicy}"/> object of the request.
        /// </summary>
        /// <param name="tokenIssuancePolicy">The TokenIssuancePolicy to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(TokenIssuancePolicy tokenIssuancePolicy, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";

            if (string.IsNullOrEmpty(tokenIssuancePolicy.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/policies/tokenIssuancePolicies/{1}", this.Client.BaseUrl, tokenIssuancePolicy.Id) };
            return this.SendAsyncWithGraphResponse(requestBody, cancellationToken);
        }

    }
}
