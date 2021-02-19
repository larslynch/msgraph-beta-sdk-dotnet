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
    /// The type DeviceCompliancePolicyRequest.
    /// </summary>
    public partial class DeviceCompliancePolicyRequest : BaseRequest, IDeviceCompliancePolicyRequest
    {
        /// <summary>
        /// Constructs a new DeviceCompliancePolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceCompliancePolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceCompliancePolicy using POST.
        /// </summary>
        /// <param name="deviceCompliancePolicyToCreate">The DeviceCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<DeviceCompliancePolicy> CreateAsync(DeviceCompliancePolicy deviceCompliancePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceCompliancePolicy>(deviceCompliancePolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceCompliancePolicy using POST and returns a <see cref="GraphResponse{DeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyToCreate">The DeviceCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicy>> CreateResponseAsync(DeviceCompliancePolicy deviceCompliancePolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<DeviceCompliancePolicy>(deviceCompliancePolicyToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceCompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceCompliancePolicy.
        /// </summary>
        /// <returns>The DeviceCompliancePolicy.</returns>
        public System.Threading.Tasks.Task<DeviceCompliancePolicy> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<DeviceCompliancePolicy> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceCompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceCompliancePolicy and returns a <see cref="GraphResponse{DeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicy>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceCompliancePolicy and returns a <see cref="GraphResponse{DeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicy>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<DeviceCompliancePolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified DeviceCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyToUpdate">The DeviceCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceCompliancePolicy.</returns>
        public async System.Threading.Tasks.Task<DeviceCompliancePolicy> UpdateAsync(DeviceCompliancePolicy deviceCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceCompliancePolicy>(deviceCompliancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceCompliancePolicy using PATCH and returns a <see cref="GraphResponse{DeviceCompliancePolicy}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyToUpdate">The DeviceCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicy}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicy>> UpdateResponseAsync(DeviceCompliancePolicy deviceCompliancePolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<DeviceCompliancePolicy>(deviceCompliancePolicyToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyRequest Expand(Expression<Func<DeviceCompliancePolicy, object>> expandExpression)
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
        public IDeviceCompliancePolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyRequest Select(Expression<Func<DeviceCompliancePolicy, object>> selectExpression)
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
        /// <param name="deviceCompliancePolicyToInitialize">The <see cref="DeviceCompliancePolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceCompliancePolicy deviceCompliancePolicyToInitialize)
        {

            if (deviceCompliancePolicyToInitialize != null && deviceCompliancePolicyToInitialize.AdditionalData != null)
            {

                if (deviceCompliancePolicyToInitialize.Assignments != null && deviceCompliancePolicyToInitialize.Assignments.CurrentPage != null)
                {
                    deviceCompliancePolicyToInitialize.Assignments.AdditionalData = deviceCompliancePolicyToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceCompliancePolicyToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceCompliancePolicyToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceCompliancePolicyToInitialize.DeviceSettingStateSummaries != null && deviceCompliancePolicyToInitialize.DeviceSettingStateSummaries.CurrentPage != null)
                {
                    deviceCompliancePolicyToInitialize.DeviceSettingStateSummaries.AdditionalData = deviceCompliancePolicyToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceCompliancePolicyToInitialize.AdditionalData.TryGetValue("deviceSettingStateSummaries@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceCompliancePolicyToInitialize.DeviceSettingStateSummaries.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceCompliancePolicyToInitialize.DeviceStatuses != null && deviceCompliancePolicyToInitialize.DeviceStatuses.CurrentPage != null)
                {
                    deviceCompliancePolicyToInitialize.DeviceStatuses.AdditionalData = deviceCompliancePolicyToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceCompliancePolicyToInitialize.AdditionalData.TryGetValue("deviceStatuses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceCompliancePolicyToInitialize.DeviceStatuses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceCompliancePolicyToInitialize.ScheduledActionsForRule != null && deviceCompliancePolicyToInitialize.ScheduledActionsForRule.CurrentPage != null)
                {
                    deviceCompliancePolicyToInitialize.ScheduledActionsForRule.AdditionalData = deviceCompliancePolicyToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceCompliancePolicyToInitialize.AdditionalData.TryGetValue("scheduledActionsForRule@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceCompliancePolicyToInitialize.ScheduledActionsForRule.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceCompliancePolicyToInitialize.UserStatuses != null && deviceCompliancePolicyToInitialize.UserStatuses.CurrentPage != null)
                {
                    deviceCompliancePolicyToInitialize.UserStatuses.AdditionalData = deviceCompliancePolicyToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceCompliancePolicyToInitialize.AdditionalData.TryGetValue("userStatuses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceCompliancePolicyToInitialize.UserStatuses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
