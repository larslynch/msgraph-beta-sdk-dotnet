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
    /// The type CloudPcProvisioningPolicyRequest.
    /// </summary>
    public partial class CloudPcProvisioningPolicyRequest : BaseRequest, ICloudPcProvisioningPolicyRequest
    {
        /// <summary>
        /// Constructs a new CloudPcProvisioningPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public CloudPcProvisioningPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified CloudPcProvisioningPolicy using POST.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyToCreate">The CloudPcProvisioningPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcProvisioningPolicy.</returns>
        public async System.Threading.Tasks.Task<CloudPcProvisioningPolicy> CreateAsync(CloudPcProvisioningPolicy cloudPcProvisioningPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<CloudPcProvisioningPolicy>(cloudPcProvisioningPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified CloudPcProvisioningPolicy using POST and returns a <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyToCreate">The CloudPcProvisioningPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicy>> CreateResponseAsync(CloudPcProvisioningPolicy cloudPcProvisioningPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<CloudPcProvisioningPolicy>(cloudPcProvisioningPolicyToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CloudPcProvisioningPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<CloudPcProvisioningPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified CloudPcProvisioningPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicy.
        /// </summary>
        /// <returns>The CloudPcProvisioningPolicy.</returns>
        public System.Threading.Tasks.Task<CloudPcProvisioningPolicy> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcProvisioningPolicy.</returns>
        public async System.Threading.Tasks.Task<CloudPcProvisioningPolicy> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<CloudPcProvisioningPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicy and returns a <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicy>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicy and returns a <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicy>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<CloudPcProvisioningPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified CloudPcProvisioningPolicy using PATCH.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyToUpdate">The CloudPcProvisioningPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcProvisioningPolicy.</returns>
        public async System.Threading.Tasks.Task<CloudPcProvisioningPolicy> UpdateAsync(CloudPcProvisioningPolicy cloudPcProvisioningPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<CloudPcProvisioningPolicy>(cloudPcProvisioningPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified CloudPcProvisioningPolicy using PATCH and returns a <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyToUpdate">The CloudPcProvisioningPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicy>> UpdateResponseAsync(CloudPcProvisioningPolicy cloudPcProvisioningPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<CloudPcProvisioningPolicy>(cloudPcProvisioningPolicyToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcProvisioningPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcProvisioningPolicyRequest Expand(Expression<Func<CloudPcProvisioningPolicy, object>> expandExpression)
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
        public ICloudPcProvisioningPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ICloudPcProvisioningPolicyRequest Select(Expression<Func<CloudPcProvisioningPolicy, object>> selectExpression)
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
        /// <param name="cloudPcProvisioningPolicyToInitialize">The <see cref="CloudPcProvisioningPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(CloudPcProvisioningPolicy cloudPcProvisioningPolicyToInitialize)
        {

            if (cloudPcProvisioningPolicyToInitialize != null && cloudPcProvisioningPolicyToInitialize.AdditionalData != null)
            {

                if (cloudPcProvisioningPolicyToInitialize.Assignments != null && cloudPcProvisioningPolicyToInitialize.Assignments.CurrentPage != null)
                {
                    cloudPcProvisioningPolicyToInitialize.Assignments.AdditionalData = cloudPcProvisioningPolicyToInitialize.AdditionalData;

                    object nextPageLink;
                    cloudPcProvisioningPolicyToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        cloudPcProvisioningPolicyToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
