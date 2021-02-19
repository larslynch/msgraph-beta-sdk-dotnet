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
    /// The type DeviceManagementCachedReportConfigurationRequest.
    /// </summary>
    public partial class DeviceManagementCachedReportConfigurationRequest : BaseRequest, IDeviceManagementCachedReportConfigurationRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementCachedReportConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementCachedReportConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementCachedReportConfiguration using POST.
        /// </summary>
        /// <param name="deviceManagementCachedReportConfigurationToCreate">The DeviceManagementCachedReportConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementCachedReportConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementCachedReportConfiguration> CreateAsync(DeviceManagementCachedReportConfiguration deviceManagementCachedReportConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceManagementCachedReportConfiguration>(deviceManagementCachedReportConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementCachedReportConfiguration using POST and returns a <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceManagementCachedReportConfigurationToCreate">The DeviceManagementCachedReportConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementCachedReportConfiguration>> CreateResponseAsync(DeviceManagementCachedReportConfiguration deviceManagementCachedReportConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceManagementCachedReportConfiguration>(deviceManagementCachedReportConfigurationToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementCachedReportConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceManagementCachedReportConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementCachedReportConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceManagementCachedReportConfiguration.
        /// </summary>
        /// <returns>The DeviceManagementCachedReportConfiguration.</returns>
        public System.Threading.Tasks.Task<DeviceManagementCachedReportConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementCachedReportConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementCachedReportConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementCachedReportConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceManagementCachedReportConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementCachedReportConfiguration and returns a <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementCachedReportConfiguration>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceManagementCachedReportConfiguration and returns a <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementCachedReportConfiguration>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DeviceManagementCachedReportConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DeviceManagementCachedReportConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceManagementCachedReportConfigurationToUpdate">The DeviceManagementCachedReportConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementCachedReportConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementCachedReportConfiguration> UpdateAsync(DeviceManagementCachedReportConfiguration deviceManagementCachedReportConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceManagementCachedReportConfiguration>(deviceManagementCachedReportConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementCachedReportConfiguration using PATCH and returns a <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceManagementCachedReportConfigurationToUpdate">The DeviceManagementCachedReportConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceManagementCachedReportConfiguration>> UpdateResponseAsync(DeviceManagementCachedReportConfiguration deviceManagementCachedReportConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceManagementCachedReportConfiguration>(deviceManagementCachedReportConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementCachedReportConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementCachedReportConfigurationRequest Expand(Expression<Func<DeviceManagementCachedReportConfiguration, object>> expandExpression)
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
        public IDeviceManagementCachedReportConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementCachedReportConfigurationRequest Select(Expression<Func<DeviceManagementCachedReportConfiguration, object>> selectExpression)
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
        /// <param name="deviceManagementCachedReportConfigurationToInitialize">The <see cref="DeviceManagementCachedReportConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementCachedReportConfiguration deviceManagementCachedReportConfigurationToInitialize)
        {

        }
    }
}
