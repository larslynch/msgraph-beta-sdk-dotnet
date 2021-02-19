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
    /// The type PlannerRosterRequest.
    /// </summary>
    public partial class PlannerRosterRequest : BaseRequest, IPlannerRosterRequest
    {
        /// <summary>
        /// Constructs a new PlannerRosterRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PlannerRosterRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PlannerRoster using POST.
        /// </summary>
        /// <param name="plannerRosterToCreate">The PlannerRoster to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerRoster.</returns>
        public async System.Threading.Tasks.Task<PlannerRoster> CreateAsync(PlannerRoster plannerRosterToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<PlannerRoster>(plannerRosterToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PlannerRoster using POST and returns a <see cref="GraphResponse{PlannerRoster}"/> object.
        /// </summary>
        /// <param name="plannerRosterToCreate">The PlannerRoster to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerRoster}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PlannerRoster>> CreateResponseAsync(PlannerRoster plannerRosterToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<PlannerRoster>(plannerRosterToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PlannerRoster.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<PlannerRoster>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PlannerRoster and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified PlannerRoster.
        /// </summary>
        /// <returns>The PlannerRoster.</returns>
        public System.Threading.Tasks.Task<PlannerRoster> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PlannerRoster.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerRoster.</returns>
        public async System.Threading.Tasks.Task<PlannerRoster> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<PlannerRoster>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PlannerRoster and returns a <see cref="GraphResponse{PlannerRoster}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PlannerRoster}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PlannerRoster>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified PlannerRoster and returns a <see cref="GraphResponse{PlannerRoster}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerRoster}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PlannerRoster>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<PlannerRoster>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified PlannerRoster using PATCH.
        /// </summary>
        /// <param name="plannerRosterToUpdate">The PlannerRoster to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerRoster.</returns>
        public async System.Threading.Tasks.Task<PlannerRoster> UpdateAsync(PlannerRoster plannerRosterToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<PlannerRoster>(plannerRosterToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PlannerRoster using PATCH and returns a <see cref="GraphResponse{PlannerRoster}"/> object.
        /// </summary>
        /// <param name="plannerRosterToUpdate">The PlannerRoster to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PlannerRoster}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<PlannerRoster>> UpdateResponseAsync(PlannerRoster plannerRosterToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<PlannerRoster>(plannerRosterToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerRosterRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerRosterRequest Expand(Expression<Func<PlannerRoster, object>> expandExpression)
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
        public IPlannerRosterRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPlannerRosterRequest Select(Expression<Func<PlannerRoster, object>> selectExpression)
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
        /// <param name="plannerRosterToInitialize">The <see cref="PlannerRoster"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PlannerRoster plannerRosterToInitialize)
        {

            if (plannerRosterToInitialize != null && plannerRosterToInitialize.AdditionalData != null)
            {

                if (plannerRosterToInitialize.Members != null && plannerRosterToInitialize.Members.CurrentPage != null)
                {
                    plannerRosterToInitialize.Members.AdditionalData = plannerRosterToInitialize.AdditionalData;

                    object nextPageLink;
                    plannerRosterToInitialize.AdditionalData.TryGetValue("members@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        plannerRosterToInitialize.Members.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (plannerRosterToInitialize.Plans != null && plannerRosterToInitialize.Plans.CurrentPage != null)
                {
                    plannerRosterToInitialize.Plans.AdditionalData = plannerRosterToInitialize.AdditionalData;

                    object nextPageLink;
                    plannerRosterToInitialize.AdditionalData.TryGetValue("plans@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        plannerRosterToInitialize.Plans.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
