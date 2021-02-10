// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type TeamworkTagMembersCollectionRequestBuilder.
    /// </summary>
    public partial class TeamworkTagMembersCollectionRequestBuilder : BaseRequestBuilder, ITeamworkTagMembersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TeamworkTagMembersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TeamworkTagMembersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITeamworkTagMembersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITeamworkTagMembersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new TeamworkTagMembersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITeamworkTagMemberRequestBuilder"/> for the specified TeamworkTagTeamworkTagMember.
        /// </summary>
        /// <param name="id">The ID for the TeamworkTagTeamworkTagMember.</param>
        /// <returns>The <see cref="ITeamworkTagMemberRequestBuilder"/>.</returns>
        public ITeamworkTagMemberRequestBuilder this[string id]
        {
            get
            {
                return new TeamworkTagMemberRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
