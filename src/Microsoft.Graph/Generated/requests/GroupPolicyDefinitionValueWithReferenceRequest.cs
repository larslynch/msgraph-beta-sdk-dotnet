// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type GroupPolicyDefinitionValueWithReferenceRequest.
    /// </summary>
    public partial class GroupPolicyDefinitionValueWithReferenceRequest : BaseRequest, IGroupPolicyDefinitionValueWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyDefinitionValueWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyDefinitionValueWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified GroupPolicyDefinitionValue.
        /// </summary>
        /// <returns>The GroupPolicyDefinitionValue.</returns>
        public System.Threading.Tasks.Task<GroupPolicyDefinitionValue> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GroupPolicyDefinitionValue.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyDefinitionValue.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyDefinitionValue> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<GroupPolicyDefinitionValue>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupPolicyDefinitionValue and returns a <see cref="GraphResponse{GroupPolicyDefinitionValue}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GroupPolicyDefinitionValue}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyDefinitionValue>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified GroupPolicyDefinitionValue and returns a <see cref="GraphResponse{GroupPolicyDefinitionValue}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyDefinitionValue}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GroupPolicyDefinitionValue>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<GroupPolicyDefinitionValue>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Creates the specified GroupPolicyDefinitionValue using POST.
        /// </summary>
        /// <param name="groupPolicyDefinitionValueToCreate">The GroupPolicyDefinitionValue to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyDefinitionValue.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyDefinitionValue> CreateAsync(GroupPolicyDefinitionValue groupPolicyDefinitionValueToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<GroupPolicyDefinitionValue>(groupPolicyDefinitionValueToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified GroupPolicyDefinitionValue using POST and returns a <see cref="GraphResponse{GroupPolicyDefinitionValue}"/> object.
        /// </summary>
        /// <param name="groupPolicyDefinitionValueToCreate">The GroupPolicyDefinitionValue to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyDefinitionValue}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GroupPolicyDefinitionValue>> CreateResponseAsync(GroupPolicyDefinitionValue groupPolicyDefinitionValueToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<GroupPolicyDefinitionValue>(groupPolicyDefinitionValueToCreate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Updates the specified GroupPolicyDefinitionValue using PATCH.
        /// </summary>
        /// <param name="groupPolicyDefinitionValueToUpdate">The GroupPolicyDefinitionValue to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyDefinitionValue.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyDefinitionValue> UpdateAsync(GroupPolicyDefinitionValue groupPolicyDefinitionValueToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<GroupPolicyDefinitionValue>(groupPolicyDefinitionValueToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified GroupPolicyDefinitionValue using PATCH and returns a <see cref="GraphResponse{GroupPolicyDefinitionValue}"/> object.
        /// </summary>
        /// <param name="groupPolicyDefinitionValueToUpdate">The GroupPolicyDefinitionValue to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyDefinitionValue}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<GroupPolicyDefinitionValue>> UpdateResponseAsync(GroupPolicyDefinitionValue groupPolicyDefinitionValueToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<GroupPolicyDefinitionValue>(groupPolicyDefinitionValueToUpdate, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified GroupPolicyDefinitionValue.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<GroupPolicyDefinitionValue>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified GroupPolicyDefinitionValue and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyDefinitionValueWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyDefinitionValueWithReferenceRequest Expand(Expression<Func<GroupPolicyDefinitionValue, object>> expandExpression)
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
        public IGroupPolicyDefinitionValueWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyDefinitionValueWithReferenceRequest Select(Expression<Func<GroupPolicyDefinitionValue, object>> selectExpression)
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

    }
}
