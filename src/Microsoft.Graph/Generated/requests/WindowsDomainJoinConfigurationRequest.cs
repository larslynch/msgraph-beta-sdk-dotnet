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
    /// The type WindowsDomainJoinConfigurationRequest.
    /// </summary>
    public partial class WindowsDomainJoinConfigurationRequest : BaseRequest, IWindowsDomainJoinConfigurationRequest
    {
        /// <summary>
        /// Constructs a new WindowsDomainJoinConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsDomainJoinConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsDomainJoinConfiguration using POST.
        /// </summary>
        /// <param name="windowsDomainJoinConfigurationToCreate">The WindowsDomainJoinConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsDomainJoinConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsDomainJoinConfiguration> CreateAsync(WindowsDomainJoinConfiguration windowsDomainJoinConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsDomainJoinConfiguration>(windowsDomainJoinConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WindowsDomainJoinConfiguration using POST and returns a <see cref="GraphResponse{WindowsDomainJoinConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsDomainJoinConfigurationToCreate">The WindowsDomainJoinConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDomainJoinConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsDomainJoinConfiguration>> CreateResponseAsync(WindowsDomainJoinConfiguration windowsDomainJoinConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WindowsDomainJoinConfiguration>(windowsDomainJoinConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsDomainJoinConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsDomainJoinConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsDomainJoinConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WindowsDomainJoinConfiguration.
        /// </summary>
        /// <returns>The WindowsDomainJoinConfiguration.</returns>
        public System.Threading.Tasks.Task<WindowsDomainJoinConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsDomainJoinConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsDomainJoinConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsDomainJoinConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsDomainJoinConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WindowsDomainJoinConfiguration and returns a <see cref="GraphResponse{WindowsDomainJoinConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WindowsDomainJoinConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsDomainJoinConfiguration>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsDomainJoinConfiguration and returns a <see cref="GraphResponse{WindowsDomainJoinConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDomainJoinConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsDomainJoinConfiguration>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<WindowsDomainJoinConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified WindowsDomainJoinConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsDomainJoinConfigurationToUpdate">The WindowsDomainJoinConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsDomainJoinConfiguration.</returns>
        public async System.Threading.Tasks.Task<WindowsDomainJoinConfiguration> UpdateAsync(WindowsDomainJoinConfiguration windowsDomainJoinConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsDomainJoinConfiguration>(windowsDomainJoinConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsDomainJoinConfiguration using PATCH and returns a <see cref="GraphResponse{WindowsDomainJoinConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsDomainJoinConfigurationToUpdate">The WindowsDomainJoinConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsDomainJoinConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsDomainJoinConfiguration>> UpdateResponseAsync(WindowsDomainJoinConfiguration windowsDomainJoinConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WindowsDomainJoinConfiguration>(windowsDomainJoinConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsDomainJoinConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsDomainJoinConfigurationRequest Expand(Expression<Func<WindowsDomainJoinConfiguration, object>> expandExpression)
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
        public IWindowsDomainJoinConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsDomainJoinConfigurationRequest Select(Expression<Func<WindowsDomainJoinConfiguration, object>> selectExpression)
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
        /// <param name="windowsDomainJoinConfigurationToInitialize">The <see cref="WindowsDomainJoinConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsDomainJoinConfiguration windowsDomainJoinConfigurationToInitialize)
        {

            if (windowsDomainJoinConfigurationToInitialize != null && windowsDomainJoinConfigurationToInitialize.AdditionalData != null)
            {

                if (windowsDomainJoinConfigurationToInitialize.NetworkAccessConfigurations != null && windowsDomainJoinConfigurationToInitialize.NetworkAccessConfigurations.CurrentPage != null)
                {
                    windowsDomainJoinConfigurationToInitialize.NetworkAccessConfigurations.AdditionalData = windowsDomainJoinConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    windowsDomainJoinConfigurationToInitialize.AdditionalData.TryGetValue("networkAccessConfigurations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        windowsDomainJoinConfigurationToInitialize.NetworkAccessConfigurations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
