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
    /// The type TeamRequest.
    /// </summary>
    public partial class TeamRequest : BaseRequest, ITeamRequest
    {
        /// <summary>
        /// Constructs a new TeamRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TeamRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Team using POST.
        /// </summary>
        /// <param name="teamToCreate">The Team to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Team.</returns>
        public async System.Threading.Tasks.Task<Team> CreateAsync(Team teamToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<Team>(teamToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Team using POST and returns a <see cref="GraphResponse{Team}"/> object.
        /// </summary>
        /// <param name="teamToCreate">The Team to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Team}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Team>> CreateResponseAsync(Team teamToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Team>(teamToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Team.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<Team>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Team and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Team.
        /// </summary>
        /// <returns>The Team.</returns>
        public System.Threading.Tasks.Task<Team> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Team.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Team.</returns>
        public async System.Threading.Tasks.Task<Team> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Team>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Team and returns a <see cref="GraphResponse{Team}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Team}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Team>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Team and returns a <see cref="GraphResponse{Team}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Team}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Team>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<Team>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified Team using PATCH.
        /// </summary>
        /// <param name="teamToUpdate">The Team to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Team.</returns>
        public async System.Threading.Tasks.Task<Team> UpdateAsync(Team teamToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Team>(teamToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Team using PATCH and returns a <see cref="GraphResponse{Team}"/> object.
        /// </summary>
        /// <param name="teamToUpdate">The Team to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Team}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Team>> UpdateResponseAsync(Team teamToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<Team>(teamToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamRequest Expand(Expression<Func<Team, object>> expandExpression)
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
        public ITeamRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITeamRequest Select(Expression<Func<Team, object>> selectExpression)
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
        /// <param name="teamToInitialize">The <see cref="Team"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Team teamToInitialize)
        {

            if (teamToInitialize != null && teamToInitialize.AdditionalData != null)
            {

                if (teamToInitialize.Channels != null && teamToInitialize.Channels.CurrentPage != null)
                {
                    teamToInitialize.Channels.AdditionalData = teamToInitialize.AdditionalData;

                    object nextPageLink;
                    teamToInitialize.AdditionalData.TryGetValue("channels@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        teamToInitialize.Channels.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (teamToInitialize.InstalledApps != null && teamToInitialize.InstalledApps.CurrentPage != null)
                {
                    teamToInitialize.InstalledApps.AdditionalData = teamToInitialize.AdditionalData;

                    object nextPageLink;
                    teamToInitialize.AdditionalData.TryGetValue("installedApps@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        teamToInitialize.InstalledApps.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (teamToInitialize.Members != null && teamToInitialize.Members.CurrentPage != null)
                {
                    teamToInitialize.Members.AdditionalData = teamToInitialize.AdditionalData;

                    object nextPageLink;
                    teamToInitialize.AdditionalData.TryGetValue("members@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        teamToInitialize.Members.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (teamToInitialize.Operations != null && teamToInitialize.Operations.CurrentPage != null)
                {
                    teamToInitialize.Operations.AdditionalData = teamToInitialize.AdditionalData;

                    object nextPageLink;
                    teamToInitialize.AdditionalData.TryGetValue("operations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        teamToInitialize.Operations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (teamToInitialize.Owners != null && teamToInitialize.Owners.CurrentPage != null)
                {
                    teamToInitialize.Owners.AdditionalData = teamToInitialize.AdditionalData;

                    object nextPageLink;
                    teamToInitialize.AdditionalData.TryGetValue("owners@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        teamToInitialize.Owners.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (teamToInitialize.Tags != null && teamToInitialize.Tags.CurrentPage != null)
                {
                    teamToInitialize.Tags.AdditionalData = teamToInitialize.AdditionalData;

                    object nextPageLink;
                    teamToInitialize.AdditionalData.TryGetValue("tags@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        teamToInitialize.Tags.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
