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
    /// The type DeviceManagementTemplateRequest.
    /// </summary>
    public partial class DeviceManagementTemplateRequest : BaseRequest, IDeviceManagementTemplateRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementTemplateRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementTemplateRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementTemplate using POST.
        /// </summary>
        /// <param name="deviceManagementTemplateToCreate">The DeviceManagementTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementTemplate.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementTemplate> CreateAsync(DeviceManagementTemplate deviceManagementTemplateToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceManagementTemplate>(deviceManagementTemplateToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementTemplate using POST and returns a <see cref="GraphResponse{DeviceManagementTemplate}"/> object.
        /// </summary>
        /// <param name="deviceManagementTemplateToCreate">The DeviceManagementTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplate}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplate>> CreateResponseAsync(DeviceManagementTemplate deviceManagementTemplateToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceManagementTemplate>(deviceManagementTemplateToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceManagementTemplate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceManagementTemplate.
        /// </summary>
        /// <returns>The DeviceManagementTemplate.</returns>
        public System.Threading.Tasks.Task<DeviceManagementTemplate> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementTemplate.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementTemplate> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceManagementTemplate>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementTemplate and returns a <see cref="GraphResponse{DeviceManagementTemplate}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplate}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplate>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementTemplate and returns a <see cref="GraphResponse{DeviceManagementTemplate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplate}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplate>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DeviceManagementTemplate>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DeviceManagementTemplate using PATCH.
        /// </summary>
        /// <param name="deviceManagementTemplateToUpdate">The DeviceManagementTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementTemplate.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementTemplate> UpdateAsync(DeviceManagementTemplate deviceManagementTemplateToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceManagementTemplate>(deviceManagementTemplateToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementTemplate using PATCH and returns a <see cref="GraphResponse{DeviceManagementTemplate}"/> object.
        /// </summary>
        /// <param name="deviceManagementTemplateToUpdate">The DeviceManagementTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementTemplate}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementTemplate>> UpdateResponseAsync(DeviceManagementTemplate deviceManagementTemplateToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceManagementTemplate>(deviceManagementTemplateToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementTemplateRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementTemplateRequest Expand(Expression<Func<DeviceManagementTemplate, object>> expandExpression)
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
        public IDeviceManagementTemplateRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementTemplateRequest Select(Expression<Func<DeviceManagementTemplate, object>> selectExpression)
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
        /// <param name="deviceManagementTemplateToInitialize">The <see cref="DeviceManagementTemplate"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementTemplate deviceManagementTemplateToInitialize)
        {

            if (deviceManagementTemplateToInitialize != null && deviceManagementTemplateToInitialize.AdditionalData != null)
            {

                if (deviceManagementTemplateToInitialize.Categories != null && deviceManagementTemplateToInitialize.Categories.CurrentPage != null)
                {
                    deviceManagementTemplateToInitialize.Categories.AdditionalData = deviceManagementTemplateToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementTemplateToInitialize.AdditionalData.TryGetValue("categories@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementTemplateToInitialize.Categories.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementTemplateToInitialize.MigratableTo != null && deviceManagementTemplateToInitialize.MigratableTo.CurrentPage != null)
                {
                    deviceManagementTemplateToInitialize.MigratableTo.AdditionalData = deviceManagementTemplateToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementTemplateToInitialize.AdditionalData.TryGetValue("migratableTo@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementTemplateToInitialize.MigratableTo.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceManagementTemplateToInitialize.Settings != null && deviceManagementTemplateToInitialize.Settings.CurrentPage != null)
                {
                    deviceManagementTemplateToInitialize.Settings.AdditionalData = deviceManagementTemplateToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementTemplateToInitialize.AdditionalData.TryGetValue("settings@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementTemplateToInitialize.Settings.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
