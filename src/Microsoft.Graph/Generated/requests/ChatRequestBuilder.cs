// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ChatRequestBuilder.
    /// </summary>
    public partial class ChatRequestBuilder : EntityRequestBuilder, IChatRequestBuilder
    {

        /// <summary>
        /// Constructs a new ChatRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ChatRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IChatRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IChatRequest Request(IEnumerable<Option> options)
        {
            return new ChatRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for InstalledApps.
        /// </summary>
        /// <returns>The <see cref="IChatInstalledAppsCollectionRequestBuilder"/>.</returns>
        public IChatInstalledAppsCollectionRequestBuilder InstalledApps
        {
            get
            {
                return new ChatInstalledAppsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("installedApps"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="IChatMembersCollectionRequestBuilder"/>.</returns>
        public IChatMembersCollectionRequestBuilder Members
        {
            get
            {
                return new ChatMembersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("members"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Messages.
        /// </summary>
        /// <returns>The <see cref="IChatMessagesCollectionRequestBuilder"/>.</returns>
        public IChatMessagesCollectionRequestBuilder Messages
        {
            get
            {
                return new ChatMessagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("messages"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Tabs.
        /// </summary>
        /// <returns>The <see cref="IChatTabsCollectionRequestBuilder"/>.</returns>
        public IChatTabsCollectionRequestBuilder Tabs
        {
            get
            {
                return new ChatTabsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tabs"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ChatSendActivityNotification.
        /// </summary>
        /// <returns>The <see cref="IChatSendActivityNotificationRequestBuilder"/>.</returns>
        public IChatSendActivityNotificationRequestBuilder SendActivityNotification(
            TeamworkActivityTopic topic = null,
            string activityType = null,
            Int64? chainId = null,
            ItemBody previewText = null,
            IEnumerable<KeyValuePair> templateParameters = null,
            TeamworkNotificationRecipient recipient = null)
        {
            return new ChatSendActivityNotificationRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.sendActivityNotification"),
                this.Client,
                topic,
                activityType,
                chainId,
                previewText,
                templateParameters,
                recipient);
        }
    
    }
}
