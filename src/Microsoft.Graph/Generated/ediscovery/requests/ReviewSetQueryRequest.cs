// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type ReviewSetQueryRequest.
    /// </summary>
    public partial class ReviewSetQueryRequest : Microsoft.Graph.BaseRequest, IReviewSetQueryRequest
    {
        /// <summary>
        /// Constructs a new ReviewSetQueryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ReviewSetQueryRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ReviewSetQuery using POST.
        /// </summary>
        /// <param name="reviewSetQueryToCreate">The ReviewSetQuery to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ReviewSetQuery.</returns>
        public async System.Threading.Tasks.Task<ReviewSetQuery> CreateAsync(ReviewSetQuery reviewSetQueryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<ReviewSetQuery>(reviewSetQueryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ReviewSetQuery using POST and returns a <see cref="GraphResponse{ReviewSetQuery}"/> object.
        /// </summary>
        /// <param name="reviewSetQueryToCreate">The ReviewSetQuery to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ReviewSetQuery}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ReviewSetQuery>> CreateResponseAsync(ReviewSetQuery reviewSetQueryToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<ReviewSetQuery>(reviewSetQueryToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ReviewSetQuery.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<ReviewSetQuery>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ReviewSetQuery and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ReviewSetQuery.
        /// </summary>
        /// <returns>The ReviewSetQuery.</returns>
        public System.Threading.Tasks.Task<ReviewSetQuery> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ReviewSetQuery.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ReviewSetQuery.</returns>
        public async System.Threading.Tasks.Task<ReviewSetQuery> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ReviewSetQuery>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ReviewSetQuery and returns a <see cref="GraphResponse{ReviewSetQuery}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ReviewSetQuery}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReviewSetQuery>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ReviewSetQuery and returns a <see cref="GraphResponse{ReviewSetQuery}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ReviewSetQuery}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ReviewSetQuery>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<ReviewSetQuery>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified ReviewSetQuery using PATCH.
        /// </summary>
        /// <param name="reviewSetQueryToUpdate">The ReviewSetQuery to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ReviewSetQuery.</returns>
        public async System.Threading.Tasks.Task<ReviewSetQuery> UpdateAsync(ReviewSetQuery reviewSetQueryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ReviewSetQuery>(reviewSetQueryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ReviewSetQuery using PATCH and returns a <see cref="GraphResponse{ReviewSetQuery}"/> object.
        /// </summary>
        /// <param name="reviewSetQueryToUpdate">The ReviewSetQuery to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ReviewSetQuery}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<ReviewSetQuery>> UpdateResponseAsync(ReviewSetQuery reviewSetQueryToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<ReviewSetQuery>(reviewSetQueryToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IReviewSetQueryRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IReviewSetQueryRequest Expand(Expression<Func<ReviewSetQuery, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IReviewSetQueryRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IReviewSetQueryRequest Select(Expression<Func<ReviewSetQuery, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="reviewSetQueryToInitialize">The <see cref="ReviewSetQuery"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ReviewSetQuery reviewSetQueryToInitialize)
        {

        }
    }
}
