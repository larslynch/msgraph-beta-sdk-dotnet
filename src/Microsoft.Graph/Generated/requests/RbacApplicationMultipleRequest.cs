// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type RbacApplicationMultipleRequest.
    /// </summary>
    public partial class RbacApplicationMultipleRequest : BaseRequest, IRbacApplicationMultipleRequest
    {
        /// <summary>
        /// Constructs a new RbacApplicationMultipleRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public RbacApplicationMultipleRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified RbacApplicationMultiple using POST.
        /// </summary>
        /// <param name="rbacApplicationMultipleToCreate">The RbacApplicationMultiple to create.</param>
        /// <returns>The created RbacApplicationMultiple.</returns>
        public System.Threading.Tasks.Task<RbacApplicationMultiple> CreateAsync(RbacApplicationMultiple rbacApplicationMultipleToCreate)
        {
            return this.CreateAsync(rbacApplicationMultipleToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RbacApplicationMultiple using POST.
        /// </summary>
        /// <param name="rbacApplicationMultipleToCreate">The RbacApplicationMultiple to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RbacApplicationMultiple.</returns>
        public async System.Threading.Tasks.Task<RbacApplicationMultiple> CreateAsync(RbacApplicationMultiple rbacApplicationMultipleToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<RbacApplicationMultiple>(rbacApplicationMultipleToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified RbacApplicationMultiple.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified RbacApplicationMultiple.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<RbacApplicationMultiple>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified RbacApplicationMultiple.
        /// </summary>
        /// <returns>The RbacApplicationMultiple.</returns>
        public System.Threading.Tasks.Task<RbacApplicationMultiple> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified RbacApplicationMultiple.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RbacApplicationMultiple.</returns>
        public async System.Threading.Tasks.Task<RbacApplicationMultiple> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<RbacApplicationMultiple>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified RbacApplicationMultiple using PATCH.
        /// </summary>
        /// <param name="rbacApplicationMultipleToUpdate">The RbacApplicationMultiple to update.</param>
        /// <returns>The updated RbacApplicationMultiple.</returns>
        public System.Threading.Tasks.Task<RbacApplicationMultiple> UpdateAsync(RbacApplicationMultiple rbacApplicationMultipleToUpdate)
        {
            return this.UpdateAsync(rbacApplicationMultipleToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified RbacApplicationMultiple using PATCH.
        /// </summary>
        /// <param name="rbacApplicationMultipleToUpdate">The RbacApplicationMultiple to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RbacApplicationMultiple.</returns>
        public async System.Threading.Tasks.Task<RbacApplicationMultiple> UpdateAsync(RbacApplicationMultiple rbacApplicationMultipleToUpdate, CancellationToken cancellationToken)
        {
			if (rbacApplicationMultipleToUpdate.AdditionalData != null)
			{
				if (rbacApplicationMultipleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					rbacApplicationMultipleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, rbacApplicationMultipleToUpdate.GetType().Name)
						});
				}
			}
            if (rbacApplicationMultipleToUpdate.AdditionalData != null)
            {
                if (rbacApplicationMultipleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    rbacApplicationMultipleToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, rbacApplicationMultipleToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<RbacApplicationMultiple>(rbacApplicationMultipleToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRbacApplicationMultipleRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRbacApplicationMultipleRequest Expand(Expression<Func<RbacApplicationMultiple, object>> expandExpression)
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
        public IRbacApplicationMultipleRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IRbacApplicationMultipleRequest Select(Expression<Func<RbacApplicationMultiple, object>> selectExpression)
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
        /// <param name="rbacApplicationMultipleToInitialize">The <see cref="RbacApplicationMultiple"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(RbacApplicationMultiple rbacApplicationMultipleToInitialize)
        {

            if (rbacApplicationMultipleToInitialize != null && rbacApplicationMultipleToInitialize.AdditionalData != null)
            {

                if (rbacApplicationMultipleToInitialize.ResourceNamespaces != null && rbacApplicationMultipleToInitialize.ResourceNamespaces.CurrentPage != null)
                {
                    rbacApplicationMultipleToInitialize.ResourceNamespaces.AdditionalData = rbacApplicationMultipleToInitialize.AdditionalData;

                    object nextPageLink;
                    rbacApplicationMultipleToInitialize.AdditionalData.TryGetValue("resourceNamespaces@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        rbacApplicationMultipleToInitialize.ResourceNamespaces.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (rbacApplicationMultipleToInitialize.RoleAssignments != null && rbacApplicationMultipleToInitialize.RoleAssignments.CurrentPage != null)
                {
                    rbacApplicationMultipleToInitialize.RoleAssignments.AdditionalData = rbacApplicationMultipleToInitialize.AdditionalData;

                    object nextPageLink;
                    rbacApplicationMultipleToInitialize.AdditionalData.TryGetValue("roleAssignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        rbacApplicationMultipleToInitialize.RoleAssignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (rbacApplicationMultipleToInitialize.RoleDefinitions != null && rbacApplicationMultipleToInitialize.RoleDefinitions.CurrentPage != null)
                {
                    rbacApplicationMultipleToInitialize.RoleDefinitions.AdditionalData = rbacApplicationMultipleToInitialize.AdditionalData;

                    object nextPageLink;
                    rbacApplicationMultipleToInitialize.AdditionalData.TryGetValue("roleDefinitions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        rbacApplicationMultipleToInitialize.RoleDefinitions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
