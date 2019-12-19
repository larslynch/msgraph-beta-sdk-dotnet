// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserJoinedTeamsCollectionRequestBuilder.
    /// </summary>
    public partial class UserJoinedTeamsCollectionRequestBuilder : BaseRequestBuilder, IUserJoinedTeamsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserJoinedTeamsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserJoinedTeamsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserJoinedTeamsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserJoinedTeamsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserJoinedTeamsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITeamRequestBuilder"/> for the specified UserTeam.
        /// </summary>
        /// <param name="id">The ID for the UserTeam.</param>
        /// <returns>The <see cref="ITeamRequestBuilder"/>.</returns>
        public ITeamRequestBuilder this[string id]
        {
            get
            {
                return new TeamRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TeamAllMessages.
        /// </summary>
        /// <returns>The <see cref="ITeamAllMessagesRequestBuilder"/>.</returns>
        public ITeamAllMessagesRequestBuilder AllMessages()
        {
            return new TeamAllMessagesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.allMessages"),
                this.Client);
        }
    }
}
