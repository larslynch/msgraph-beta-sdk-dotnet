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
    /// The interface IListItemRequestBuilder.
    /// </summary>
    public partial interface IListItemRequestBuilder : IBaseItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IListItemRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IListItemRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Activities.
        /// </summary>
        /// <returns>The <see cref="IListItemActivitiesCollectionRequestBuilder"/>.</returns>
        IListItemActivitiesCollectionRequestBuilder Activities { get; }

        /// <summary>
        /// Gets the request builder for Analytics.
        /// </summary>
        /// <returns>The <see cref="IItemAnalyticsWithReferenceRequestBuilder"/>.</returns>
        IItemAnalyticsWithReferenceRequestBuilder Analytics { get; }

        /// <summary>
        /// Gets the request builder for DriveItem.
        /// </summary>
        /// <returns>The <see cref="IDriveItemRequestBuilder"/>.</returns>
        IDriveItemRequestBuilder DriveItem { get; }

        /// <summary>
        /// Gets the request builder for Fields.
        /// </summary>
        /// <returns>The <see cref="IFieldValueSetRequestBuilder"/>.</returns>
        IFieldValueSetRequestBuilder Fields { get; }

        /// <summary>
        /// Gets the request builder for Versions.
        /// </summary>
        /// <returns>The <see cref="IListItemVersionsCollectionRequestBuilder"/>.</returns>
        IListItemVersionsCollectionRequestBuilder Versions { get; }
    
        /// <summary>
        /// Gets the request builder for ListItemCreateLink.
        /// </summary>
        /// <returns>The <see cref="IListItemCreateLinkRequestBuilder"/>.</returns>
        IListItemCreateLinkRequestBuilder CreateLink(
            string type,
            string scope = null,
            DateTimeOffset? expirationDateTime = null,
            string password = null,
            IEnumerable<DriveRecipient> recipients = null);

        /// <summary>
        /// Gets the request builder for ListItemGetActivitiesByInterval.
        /// </summary>
        /// <returns>The <see cref="IListItemGetActivitiesByIntervalRequestBuilder"/>.</returns>
        IListItemGetActivitiesByIntervalRequestBuilder GetActivitiesByInterval(
            string startDateTime = null,
            string endDateTime = null,
            string interval = null);
    
    }
}
