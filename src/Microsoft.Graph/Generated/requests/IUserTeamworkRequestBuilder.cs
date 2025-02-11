// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IUserTeamworkRequestBuilder.
    /// </summary>
    public partial interface IUserTeamworkRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IUserTeamworkRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IUserTeamworkRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for InstalledApps.
        /// </summary>
        /// <returns>The <see cref="IUserTeamworkInstalledAppsCollectionRequestBuilder"/>.</returns>
        IUserTeamworkInstalledAppsCollectionRequestBuilder InstalledApps { get; }
    
        /// <summary>
        /// Gets the request builder for UserTeamworkSendActivityNotification.
        /// </summary>
        /// <returns>The <see cref="IUserTeamworkSendActivityNotificationRequestBuilder"/>.</returns>
        IUserTeamworkSendActivityNotificationRequestBuilder SendActivityNotification(
            TeamworkActivityTopic topic = null,
            string activityType = null,
            Int64? chainId = null,
            ItemBody previewText = null,
            IEnumerable<KeyValuePair> templateParameters = null,
            string teamsAppId = null);
    
    }
}
