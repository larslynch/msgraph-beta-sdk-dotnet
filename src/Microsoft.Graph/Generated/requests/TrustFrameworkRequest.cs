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
    /// The type TrustFrameworkRequest.
    /// </summary>
    public partial class TrustFrameworkRequest : BaseRequest, ITrustFrameworkRequest
    {
        /// <summary>
        /// Constructs a new TrustFrameworkRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TrustFrameworkRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified TrustFramework using POST.
        /// </summary>
        /// <param name="trustFrameworkToCreate">The TrustFramework to create.</param>
        /// <returns>The created TrustFramework.</returns>
        public System.Threading.Tasks.Task<TrustFramework> CreateAsync(TrustFramework trustFrameworkToCreate)
        {
            return this.CreateAsync(trustFrameworkToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TrustFramework using POST.
        /// </summary>
        /// <param name="trustFrameworkToCreate">The TrustFramework to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TrustFramework.</returns>
        public async System.Threading.Tasks.Task<TrustFramework> CreateAsync(TrustFramework trustFrameworkToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<TrustFramework>(trustFrameworkToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified TrustFramework.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TrustFramework.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<TrustFramework>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified TrustFramework.
        /// </summary>
        /// <returns>The TrustFramework.</returns>
        public System.Threading.Tasks.Task<TrustFramework> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TrustFramework.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TrustFramework.</returns>
        public async System.Threading.Tasks.Task<TrustFramework> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<TrustFramework>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified TrustFramework using PATCH.
        /// </summary>
        /// <param name="trustFrameworkToUpdate">The TrustFramework to update.</param>
        /// <returns>The updated TrustFramework.</returns>
        public System.Threading.Tasks.Task<TrustFramework> UpdateAsync(TrustFramework trustFrameworkToUpdate)
        {
            return this.UpdateAsync(trustFrameworkToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TrustFramework using PATCH.
        /// </summary>
        /// <param name="trustFrameworkToUpdate">The TrustFramework to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TrustFramework.</returns>
        public async System.Threading.Tasks.Task<TrustFramework> UpdateAsync(TrustFramework trustFrameworkToUpdate, CancellationToken cancellationToken)
        {
			if (trustFrameworkToUpdate.AdditionalData != null)
			{
				if (trustFrameworkToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					trustFrameworkToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, trustFrameworkToUpdate.GetType().Name)
						});
				}
			}
            if (trustFrameworkToUpdate.AdditionalData != null)
            {
                if (trustFrameworkToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    trustFrameworkToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, trustFrameworkToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<TrustFramework>(trustFrameworkToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITrustFrameworkRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITrustFrameworkRequest Expand(Expression<Func<TrustFramework, object>> expandExpression)
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
        public ITrustFrameworkRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITrustFrameworkRequest Select(Expression<Func<TrustFramework, object>> selectExpression)
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
        /// <param name="trustFrameworkToInitialize">The <see cref="TrustFramework"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(TrustFramework trustFrameworkToInitialize)
        {

            if (trustFrameworkToInitialize != null && trustFrameworkToInitialize.AdditionalData != null)
            {

                if (trustFrameworkToInitialize.KeySets != null && trustFrameworkToInitialize.KeySets.CurrentPage != null)
                {
                    trustFrameworkToInitialize.KeySets.AdditionalData = trustFrameworkToInitialize.AdditionalData;

                    object nextPageLink;
                    trustFrameworkToInitialize.AdditionalData.TryGetValue("keySets@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        trustFrameworkToInitialize.KeySets.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (trustFrameworkToInitialize.Policies != null && trustFrameworkToInitialize.Policies.CurrentPage != null)
                {
                    trustFrameworkToInitialize.Policies.AdditionalData = trustFrameworkToInitialize.AdditionalData;

                    object nextPageLink;
                    trustFrameworkToInitialize.AdditionalData.TryGetValue("policies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        trustFrameworkToInitialize.Policies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
