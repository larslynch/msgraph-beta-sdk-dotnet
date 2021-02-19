// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EmbeddedSIMActivationCodePoolRequest.
    /// </summary>
    public partial class EmbeddedSIMActivationCodePoolRequest : BaseRequest, IEmbeddedSIMActivationCodePoolRequest
    {
        /// <summary>
        /// Constructs a new EmbeddedSIMActivationCodePoolRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EmbeddedSIMActivationCodePoolRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EmbeddedSIMActivationCodePool using POST.
        /// </summary>
        /// <param name="embeddedSIMActivationCodePoolToCreate">The EmbeddedSIMActivationCodePool to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmbeddedSIMActivationCodePool.</returns>
        public async System.Threading.Tasks.Task<EmbeddedSIMActivationCodePool> CreateAsync(EmbeddedSIMActivationCodePool embeddedSIMActivationCodePoolToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<EmbeddedSIMActivationCodePool>(embeddedSIMActivationCodePoolToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EmbeddedSIMActivationCodePool using POST and returns a <see cref="GraphResponse{EmbeddedSIMActivationCodePool}"/> object.
        /// </summary>
        /// <param name="embeddedSIMActivationCodePoolToCreate">The EmbeddedSIMActivationCodePool to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmbeddedSIMActivationCodePool}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EmbeddedSIMActivationCodePool>> CreateResponseAsync(EmbeddedSIMActivationCodePool embeddedSIMActivationCodePoolToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<EmbeddedSIMActivationCodePool>(embeddedSIMActivationCodePoolToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EmbeddedSIMActivationCodePool.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<EmbeddedSIMActivationCodePool>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EmbeddedSIMActivationCodePool and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EmbeddedSIMActivationCodePool.
        /// </summary>
        /// <returns>The EmbeddedSIMActivationCodePool.</returns>
        public System.Threading.Tasks.Task<EmbeddedSIMActivationCodePool> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EmbeddedSIMActivationCodePool.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmbeddedSIMActivationCodePool.</returns>
        public async System.Threading.Tasks.Task<EmbeddedSIMActivationCodePool> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EmbeddedSIMActivationCodePool>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EmbeddedSIMActivationCodePool and returns a <see cref="GraphResponse{EmbeddedSIMActivationCodePool}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{EmbeddedSIMActivationCodePool}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EmbeddedSIMActivationCodePool>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EmbeddedSIMActivationCodePool and returns a <see cref="GraphResponse{EmbeddedSIMActivationCodePool}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmbeddedSIMActivationCodePool}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EmbeddedSIMActivationCodePool>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<EmbeddedSIMActivationCodePool>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified EmbeddedSIMActivationCodePool using PATCH.
        /// </summary>
        /// <param name="embeddedSIMActivationCodePoolToUpdate">The EmbeddedSIMActivationCodePool to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EmbeddedSIMActivationCodePool.</returns>
        public async System.Threading.Tasks.Task<EmbeddedSIMActivationCodePool> UpdateAsync(EmbeddedSIMActivationCodePool embeddedSIMActivationCodePoolToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EmbeddedSIMActivationCodePool>(embeddedSIMActivationCodePoolToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EmbeddedSIMActivationCodePool using PATCH and returns a <see cref="GraphResponse{EmbeddedSIMActivationCodePool}"/> object.
        /// </summary>
        /// <param name="embeddedSIMActivationCodePoolToUpdate">The EmbeddedSIMActivationCodePool to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EmbeddedSIMActivationCodePool}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<EmbeddedSIMActivationCodePool>> UpdateResponseAsync(EmbeddedSIMActivationCodePool embeddedSIMActivationCodePoolToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<EmbeddedSIMActivationCodePool>(embeddedSIMActivationCodePoolToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmbeddedSIMActivationCodePoolRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEmbeddedSIMActivationCodePoolRequest Expand(Expression<Func<EmbeddedSIMActivationCodePool, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IEmbeddedSIMActivationCodePoolRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEmbeddedSIMActivationCodePoolRequest Select(Expression<Func<EmbeddedSIMActivationCodePool, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="embeddedSIMActivationCodePoolToInitialize">The <see cref="EmbeddedSIMActivationCodePool"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EmbeddedSIMActivationCodePool embeddedSIMActivationCodePoolToInitialize)
        {

            if (embeddedSIMActivationCodePoolToInitialize != null && embeddedSIMActivationCodePoolToInitialize.AdditionalData != null)
            {

                if (embeddedSIMActivationCodePoolToInitialize.Assignments != null && embeddedSIMActivationCodePoolToInitialize.Assignments.CurrentPage != null)
                {
                    embeddedSIMActivationCodePoolToInitialize.Assignments.AdditionalData = embeddedSIMActivationCodePoolToInitialize.AdditionalData;

                    object nextPageLink;
                    embeddedSIMActivationCodePoolToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        embeddedSIMActivationCodePoolToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (embeddedSIMActivationCodePoolToInitialize.DeviceStates != null && embeddedSIMActivationCodePoolToInitialize.DeviceStates.CurrentPage != null)
                {
                    embeddedSIMActivationCodePoolToInitialize.DeviceStates.AdditionalData = embeddedSIMActivationCodePoolToInitialize.AdditionalData;

                    object nextPageLink;
                    embeddedSIMActivationCodePoolToInitialize.AdditionalData.TryGetValue("deviceStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        embeddedSIMActivationCodePoolToInitialize.DeviceStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
