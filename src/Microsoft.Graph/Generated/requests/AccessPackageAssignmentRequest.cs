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
    /// The type AccessPackageAssignmentRequest.
    /// </summary>
    public partial class AccessPackageAssignmentRequest : BaseRequest, IAccessPackageAssignmentRequest
    {
        /// <summary>
        /// Constructs a new AccessPackageAssignmentRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AccessPackageAssignmentRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AccessPackageAssignment using POST.
        /// </summary>
        /// <param name="accessPackageAssignmentToCreate">The AccessPackageAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessPackageAssignment.</returns>
        public async System.Threading.Tasks.Task<AccessPackageAssignment> CreateAsync(AccessPackageAssignment accessPackageAssignmentToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<AccessPackageAssignment>(accessPackageAssignmentToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AccessPackageAssignment using POST and returns a <see cref="GraphResponse{AccessPackageAssignment}"/> object.
        /// </summary>
        /// <param name="accessPackageAssignmentToCreate">The AccessPackageAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignment>> CreateResponseAsync(AccessPackageAssignment accessPackageAssignmentToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<AccessPackageAssignment>(accessPackageAssignmentToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AccessPackageAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<AccessPackageAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AccessPackageAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AccessPackageAssignment.
        /// </summary>
        /// <returns>The AccessPackageAssignment.</returns>
        public System.Threading.Tasks.Task<AccessPackageAssignment> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AccessPackageAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessPackageAssignment.</returns>
        public async System.Threading.Tasks.Task<AccessPackageAssignment> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AccessPackageAssignment>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AccessPackageAssignment and returns a <see cref="GraphResponse{AccessPackageAssignment}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AccessPackageAssignment}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignment>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AccessPackageAssignment and returns a <see cref="GraphResponse{AccessPackageAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessPackageAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignment>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<AccessPackageAssignment>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified AccessPackageAssignment using PATCH.
        /// </summary>
        /// <param name="accessPackageAssignmentToUpdate">The AccessPackageAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessPackageAssignment.</returns>
        public async System.Threading.Tasks.Task<AccessPackageAssignment> UpdateAsync(AccessPackageAssignment accessPackageAssignmentToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AccessPackageAssignment>(accessPackageAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AccessPackageAssignment using PATCH and returns a <see cref="GraphResponse{AccessPackageAssignment}"/> object.
        /// </summary>
        /// <param name="accessPackageAssignmentToUpdate">The AccessPackageAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessPackageAssignment}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AccessPackageAssignment>> UpdateResponseAsync(AccessPackageAssignment accessPackageAssignmentToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<AccessPackageAssignment>(accessPackageAssignmentToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageAssignmentRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageAssignmentRequest Expand(Expression<Func<AccessPackageAssignment, object>> expandExpression)
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
        public IAccessPackageAssignmentRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAccessPackageAssignmentRequest Select(Expression<Func<AccessPackageAssignment, object>> selectExpression)
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
        /// <param name="accessPackageAssignmentToInitialize">The <see cref="AccessPackageAssignment"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AccessPackageAssignment accessPackageAssignmentToInitialize)
        {

            if (accessPackageAssignmentToInitialize != null && accessPackageAssignmentToInitialize.AdditionalData != null)
            {

                if (accessPackageAssignmentToInitialize.AccessPackageAssignmentRequests != null && accessPackageAssignmentToInitialize.AccessPackageAssignmentRequests.CurrentPage != null)
                {
                    accessPackageAssignmentToInitialize.AccessPackageAssignmentRequests.AdditionalData = accessPackageAssignmentToInitialize.AdditionalData;

                    object nextPageLink;
                    accessPackageAssignmentToInitialize.AdditionalData.TryGetValue("accessPackageAssignmentRequests@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        accessPackageAssignmentToInitialize.AccessPackageAssignmentRequests.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (accessPackageAssignmentToInitialize.AccessPackageAssignmentResourceRoles != null && accessPackageAssignmentToInitialize.AccessPackageAssignmentResourceRoles.CurrentPage != null)
                {
                    accessPackageAssignmentToInitialize.AccessPackageAssignmentResourceRoles.AdditionalData = accessPackageAssignmentToInitialize.AdditionalData;

                    object nextPageLink;
                    accessPackageAssignmentToInitialize.AdditionalData.TryGetValue("accessPackageAssignmentResourceRoles@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        accessPackageAssignmentToInitialize.AccessPackageAssignmentResourceRoles.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
