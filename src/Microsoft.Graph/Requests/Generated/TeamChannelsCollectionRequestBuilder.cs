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
    /// The type TeamChannelsCollectionRequestBuilder.
    /// </summary>
    public partial class TeamChannelsCollectionRequestBuilder : BaseRequestBuilder, ITeamChannelsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TeamChannelsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TeamChannelsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITeamChannelsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITeamChannelsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new TeamChannelsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IChannelRequestBuilder"/> for the specified TeamChannel.
        /// </summary>
        /// <param name="id">The ID for the TeamChannel.</param>
        /// <returns>The <see cref="IChannelRequestBuilder"/>.</returns>
        public IChannelRequestBuilder this[string id]
        {
            get
            {
                return new ChannelRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ChannelAllMessages.
        /// </summary>
        /// <returns>The <see cref="IChannelAllMessagesRequestBuilder"/>.</returns>
        public IChannelAllMessagesRequestBuilder AllMessages()
        {
            return new ChannelAllMessagesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.allMessages"),
                this.Client);
        }
    }
}
