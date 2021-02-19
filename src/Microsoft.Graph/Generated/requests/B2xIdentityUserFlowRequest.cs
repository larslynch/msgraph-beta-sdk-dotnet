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
    /// The type B2xIdentityUserFlowRequest.
    /// </summary>
    public partial class B2xIdentityUserFlowRequest : BaseRequest, IB2xIdentityUserFlowRequest
    {
        /// <summary>
        /// Constructs a new B2xIdentityUserFlowRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public B2xIdentityUserFlowRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified B2xIdentityUserFlow using POST.
        /// </summary>
        /// <param name="b2xIdentityUserFlowToCreate">The B2xIdentityUserFlow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created B2xIdentityUserFlow.</returns>
        public async System.Threading.Tasks.Task<B2xIdentityUserFlow> CreateAsync(B2xIdentityUserFlow b2xIdentityUserFlowToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<B2xIdentityUserFlow>(b2xIdentityUserFlowToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified B2xIdentityUserFlow using POST and returns a <see cref="GraphResponse{B2xIdentityUserFlow}"/> object.
        /// </summary>
        /// <param name="b2xIdentityUserFlowToCreate">The B2xIdentityUserFlow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{B2xIdentityUserFlow}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<B2xIdentityUserFlow>> CreateResponseAsync(B2xIdentityUserFlow b2xIdentityUserFlowToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<B2xIdentityUserFlow>(b2xIdentityUserFlowToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified B2xIdentityUserFlow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<B2xIdentityUserFlow>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified B2xIdentityUserFlow and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified B2xIdentityUserFlow.
        /// </summary>
        /// <returns>The B2xIdentityUserFlow.</returns>
        public System.Threading.Tasks.Task<B2xIdentityUserFlow> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified B2xIdentityUserFlow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The B2xIdentityUserFlow.</returns>
        public async System.Threading.Tasks.Task<B2xIdentityUserFlow> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<B2xIdentityUserFlow>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified B2xIdentityUserFlow and returns a <see cref="GraphResponse{B2xIdentityUserFlow}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{B2xIdentityUserFlow}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<B2xIdentityUserFlow>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified B2xIdentityUserFlow and returns a <see cref="GraphResponse{B2xIdentityUserFlow}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{B2xIdentityUserFlow}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<B2xIdentityUserFlow>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<B2xIdentityUserFlow>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified B2xIdentityUserFlow using PATCH.
        /// </summary>
        /// <param name="b2xIdentityUserFlowToUpdate">The B2xIdentityUserFlow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated B2xIdentityUserFlow.</returns>
        public async System.Threading.Tasks.Task<B2xIdentityUserFlow> UpdateAsync(B2xIdentityUserFlow b2xIdentityUserFlowToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<B2xIdentityUserFlow>(b2xIdentityUserFlowToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified B2xIdentityUserFlow using PATCH and returns a <see cref="GraphResponse{B2xIdentityUserFlow}"/> object.
        /// </summary>
        /// <param name="b2xIdentityUserFlowToUpdate">The B2xIdentityUserFlow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{B2xIdentityUserFlow}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<B2xIdentityUserFlow>> UpdateResponseAsync(B2xIdentityUserFlow b2xIdentityUserFlowToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<B2xIdentityUserFlow>(b2xIdentityUserFlowToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IB2xIdentityUserFlowRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IB2xIdentityUserFlowRequest Expand(Expression<Func<B2xIdentityUserFlow, object>> expandExpression)
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
        public IB2xIdentityUserFlowRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IB2xIdentityUserFlowRequest Select(Expression<Func<B2xIdentityUserFlow, object>> selectExpression)
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
        /// <param name="b2xIdentityUserFlowToInitialize">The <see cref="B2xIdentityUserFlow"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(B2xIdentityUserFlow b2xIdentityUserFlowToInitialize)
        {

            if (b2xIdentityUserFlowToInitialize != null && b2xIdentityUserFlowToInitialize.AdditionalData != null)
            {

                if (b2xIdentityUserFlowToInitialize.IdentityProviders != null && b2xIdentityUserFlowToInitialize.IdentityProviders.CurrentPage != null)
                {
                    b2xIdentityUserFlowToInitialize.IdentityProviders.AdditionalData = b2xIdentityUserFlowToInitialize.AdditionalData;

                    object nextPageLink;
                    b2xIdentityUserFlowToInitialize.AdditionalData.TryGetValue("identityProviders@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        b2xIdentityUserFlowToInitialize.IdentityProviders.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (b2xIdentityUserFlowToInitialize.Languages != null && b2xIdentityUserFlowToInitialize.Languages.CurrentPage != null)
                {
                    b2xIdentityUserFlowToInitialize.Languages.AdditionalData = b2xIdentityUserFlowToInitialize.AdditionalData;

                    object nextPageLink;
                    b2xIdentityUserFlowToInitialize.AdditionalData.TryGetValue("languages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        b2xIdentityUserFlowToInitialize.Languages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (b2xIdentityUserFlowToInitialize.UserAttributeAssignments != null && b2xIdentityUserFlowToInitialize.UserAttributeAssignments.CurrentPage != null)
                {
                    b2xIdentityUserFlowToInitialize.UserAttributeAssignments.AdditionalData = b2xIdentityUserFlowToInitialize.AdditionalData;

                    object nextPageLink;
                    b2xIdentityUserFlowToInitialize.AdditionalData.TryGetValue("userAttributeAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        b2xIdentityUserFlowToInitialize.UserAttributeAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
