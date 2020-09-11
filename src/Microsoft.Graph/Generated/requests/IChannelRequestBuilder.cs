// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IChannelRequestBuilder.
    /// </summary>
    public partial interface IChannelRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IChannelRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IChannelRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for FilesFolder.
        /// </summary>
        /// <returns>The <see cref="IDriveItemRequestBuilder"/>.</returns>
        IDriveItemRequestBuilder FilesFolder { get; }

        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="IChannelMembersCollectionRequestBuilder"/>.</returns>
        IChannelMembersCollectionRequestBuilder Members { get; }

        /// <summary>
        /// Gets the request builder for Messages.
        /// </summary>
        /// <returns>The <see cref="IChannelMessagesCollectionRequestBuilder"/>.</returns>
        IChannelMessagesCollectionRequestBuilder Messages { get; }

        /// <summary>
        /// Gets the request builder for Tabs.
        /// </summary>
        /// <returns>The <see cref="IChannelTabsCollectionRequestBuilder"/>.</returns>
        IChannelTabsCollectionRequestBuilder Tabs { get; }
    
        /// <summary>
        /// Gets the request builder for ChannelCompleteMigration.
        /// </summary>
        /// <returns>The <see cref="IChannelCompleteMigrationRequestBuilder"/>.</returns>
        IChannelCompleteMigrationRequestBuilder CompleteMigration();
    
    }
}
