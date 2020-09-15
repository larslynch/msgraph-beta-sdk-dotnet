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
    /// The type DirectoryDeletedItemsCollectionRequestBuilder.
    /// </summary>
    public partial class DirectoryDeletedItemsCollectionRequestBuilder : BaseRequestBuilder, IDirectoryDeletedItemsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DirectoryDeletedItemsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DirectoryDeletedItemsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDirectoryDeletedItemsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDirectoryDeletedItemsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DirectoryDeletedItemsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectRequestBuilder"/> for the specified DirectoryDirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the DirectoryDirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectRequestBuilder"/>.</returns>
        public IDirectoryObjectRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryObjectRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectValidateProperties.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectValidatePropertiesRequestBuilder"/>.</returns>
        public IDirectoryObjectValidatePropertiesRequestBuilder ValidateProperties(
            string entityType = null,
            string displayName = null,
            string mailNickname = null,
            Guid? onBehalfOfUserId = null)
        {
            return new DirectoryObjectValidatePropertiesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.validateProperties"),
                this.Client,
                entityType,
                displayName,
                mailNickname,
                onBehalfOfUserId);
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetByIds.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetByIdsRequestBuilder"/>.</returns>
        public IDirectoryObjectGetByIdsRequestBuilder GetByIds(
            IEnumerable<string> ids,
            IEnumerable<string> types = null)
        {
            return new DirectoryObjectGetByIdsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getByIds"),
                this.Client,
                ids,
                types);
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetUserOwnedObjects.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetUserOwnedObjectsRequestBuilder"/>.</returns>
        public IDirectoryObjectGetUserOwnedObjectsRequestBuilder GetUserOwnedObjects(
            string userId = null,
            string type = null)
        {
            return new DirectoryObjectGetUserOwnedObjectsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getUserOwnedObjects"),
                this.Client,
                userId,
                type);
        }
    }
}
