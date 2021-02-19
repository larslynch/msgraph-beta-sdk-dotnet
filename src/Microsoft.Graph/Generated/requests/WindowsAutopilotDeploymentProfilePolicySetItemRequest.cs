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
    /// The type WindowsAutopilotDeploymentProfilePolicySetItemRequest.
    /// </summary>
    public partial class WindowsAutopilotDeploymentProfilePolicySetItemRequest : BaseRequest, IWindowsAutopilotDeploymentProfilePolicySetItemRequest
    {
        /// <summary>
        /// Constructs a new WindowsAutopilotDeploymentProfilePolicySetItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsAutopilotDeploymentProfilePolicySetItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsAutopilotDeploymentProfilePolicySetItem using POST.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToCreate">The WindowsAutopilotDeploymentProfilePolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        public async System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> CreateAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<WindowsAutopilotDeploymentProfilePolicySetItem>(windowsAutopilotDeploymentProfilePolicySetItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WindowsAutopilotDeploymentProfilePolicySetItem using POST and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToCreate">The WindowsAutopilotDeploymentProfilePolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>> CreateResponseAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>(windowsAutopilotDeploymentProfilePolicySetItemToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsAutopilotDeploymentProfilePolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<WindowsAutopilotDeploymentProfilePolicySetItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsAutopilotDeploymentProfilePolicySetItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfilePolicySetItem.
        /// </summary>
        /// <returns>The WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        public System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfilePolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        public async System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WindowsAutopilotDeploymentProfilePolicySetItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfilePolicySetItem and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfilePolicySetItem and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfilePolicySetItem using PATCH.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToUpdate">The WindowsAutopilotDeploymentProfilePolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsAutopilotDeploymentProfilePolicySetItem.</returns>
        public async System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfilePolicySetItem> UpdateAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WindowsAutopilotDeploymentProfilePolicySetItem>(windowsAutopilotDeploymentProfilePolicySetItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfilePolicySetItem using PATCH and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToUpdate">The WindowsAutopilotDeploymentProfilePolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfilePolicySetItem}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>> UpdateResponseAsync(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<WindowsAutopilotDeploymentProfilePolicySetItem>(windowsAutopilotDeploymentProfilePolicySetItemToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsAutopilotDeploymentProfilePolicySetItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsAutopilotDeploymentProfilePolicySetItemRequest Expand(Expression<Func<WindowsAutopilotDeploymentProfilePolicySetItem, object>> expandExpression)
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
        public IWindowsAutopilotDeploymentProfilePolicySetItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsAutopilotDeploymentProfilePolicySetItemRequest Select(Expression<Func<WindowsAutopilotDeploymentProfilePolicySetItem, object>> selectExpression)
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
        /// <param name="windowsAutopilotDeploymentProfilePolicySetItemToInitialize">The <see cref="WindowsAutopilotDeploymentProfilePolicySetItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsAutopilotDeploymentProfilePolicySetItem windowsAutopilotDeploymentProfilePolicySetItemToInitialize)
        {

        }
    }
}
