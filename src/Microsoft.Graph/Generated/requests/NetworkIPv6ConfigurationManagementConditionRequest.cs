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
    /// The type NetworkIPv6ConfigurationManagementConditionRequest.
    /// </summary>
    public partial class NetworkIPv6ConfigurationManagementConditionRequest : BaseRequest, INetworkIPv6ConfigurationManagementConditionRequest
    {
        /// <summary>
        /// Constructs a new NetworkIPv6ConfigurationManagementConditionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public NetworkIPv6ConfigurationManagementConditionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified NetworkIPv6ConfigurationManagementCondition using POST.
        /// </summary>
        /// <param name="networkIPv6ConfigurationManagementConditionToCreate">The NetworkIPv6ConfigurationManagementCondition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created NetworkIPv6ConfigurationManagementCondition.</returns>
        public async System.Threading.Tasks.Task<NetworkIPv6ConfigurationManagementCondition> CreateAsync(NetworkIPv6ConfigurationManagementCondition networkIPv6ConfigurationManagementConditionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<NetworkIPv6ConfigurationManagementCondition>(networkIPv6ConfigurationManagementConditionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified NetworkIPv6ConfigurationManagementCondition using POST and returns a <see cref="GraphResponse{NetworkIPv6ConfigurationManagementCondition}"/> object.
        /// </summary>
        /// <param name="networkIPv6ConfigurationManagementConditionToCreate">The NetworkIPv6ConfigurationManagementCondition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NetworkIPv6ConfigurationManagementCondition}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<NetworkIPv6ConfigurationManagementCondition>> CreateResponseAsync(NetworkIPv6ConfigurationManagementCondition networkIPv6ConfigurationManagementConditionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<NetworkIPv6ConfigurationManagementCondition>(networkIPv6ConfigurationManagementConditionToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified NetworkIPv6ConfigurationManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<NetworkIPv6ConfigurationManagementCondition>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified NetworkIPv6ConfigurationManagementCondition and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified NetworkIPv6ConfigurationManagementCondition.
        /// </summary>
        /// <returns>The NetworkIPv6ConfigurationManagementCondition.</returns>
        public System.Threading.Tasks.Task<NetworkIPv6ConfigurationManagementCondition> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified NetworkIPv6ConfigurationManagementCondition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The NetworkIPv6ConfigurationManagementCondition.</returns>
        public async System.Threading.Tasks.Task<NetworkIPv6ConfigurationManagementCondition> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<NetworkIPv6ConfigurationManagementCondition>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified NetworkIPv6ConfigurationManagementCondition and returns a <see cref="GraphResponse{NetworkIPv6ConfigurationManagementCondition}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{NetworkIPv6ConfigurationManagementCondition}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NetworkIPv6ConfigurationManagementCondition>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified NetworkIPv6ConfigurationManagementCondition and returns a <see cref="GraphResponse{NetworkIPv6ConfigurationManagementCondition}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NetworkIPv6ConfigurationManagementCondition}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<NetworkIPv6ConfigurationManagementCondition>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<NetworkIPv6ConfigurationManagementCondition>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified NetworkIPv6ConfigurationManagementCondition using PATCH.
        /// </summary>
        /// <param name="networkIPv6ConfigurationManagementConditionToUpdate">The NetworkIPv6ConfigurationManagementCondition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated NetworkIPv6ConfigurationManagementCondition.</returns>
        public async System.Threading.Tasks.Task<NetworkIPv6ConfigurationManagementCondition> UpdateAsync(NetworkIPv6ConfigurationManagementCondition networkIPv6ConfigurationManagementConditionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<NetworkIPv6ConfigurationManagementCondition>(networkIPv6ConfigurationManagementConditionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified NetworkIPv6ConfigurationManagementCondition using PATCH and returns a <see cref="GraphResponse{NetworkIPv6ConfigurationManagementCondition}"/> object.
        /// </summary>
        /// <param name="networkIPv6ConfigurationManagementConditionToUpdate">The NetworkIPv6ConfigurationManagementCondition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{NetworkIPv6ConfigurationManagementCondition}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<NetworkIPv6ConfigurationManagementCondition>> UpdateResponseAsync(NetworkIPv6ConfigurationManagementCondition networkIPv6ConfigurationManagementConditionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<NetworkIPv6ConfigurationManagementCondition>(networkIPv6ConfigurationManagementConditionToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public INetworkIPv6ConfigurationManagementConditionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public INetworkIPv6ConfigurationManagementConditionRequest Expand(Expression<Func<NetworkIPv6ConfigurationManagementCondition, object>> expandExpression)
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
        public INetworkIPv6ConfigurationManagementConditionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public INetworkIPv6ConfigurationManagementConditionRequest Select(Expression<Func<NetworkIPv6ConfigurationManagementCondition, object>> selectExpression)
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
        /// <param name="networkIPv6ConfigurationManagementConditionToInitialize">The <see cref="NetworkIPv6ConfigurationManagementCondition"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(NetworkIPv6ConfigurationManagementCondition networkIPv6ConfigurationManagementConditionToInitialize)
        {

        }
    }
}
