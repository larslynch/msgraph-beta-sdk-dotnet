// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceManagementAuditEventsCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementAuditEventsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceManagementAuditEventsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceManagementAuditEventsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAuditEventRequestBuilder"/> for the specified AuditEvent.
        /// </summary>
        /// <param name="id">The ID for the AuditEvent.</param>
        /// <returns>The <see cref="IAuditEventRequestBuilder"/>.</returns>
        IAuditEventRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for AuditEventGetAuditActivityTypes.
        /// </summary>
        /// <returns>The <see cref="IAuditEventGetAuditActivityTypesRequestBuilder"/>.</returns>
        IAuditEventGetAuditActivityTypesRequestBuilder GetAuditActivityTypes(
            string category = null);

        /// <summary>
        /// Gets the request builder for AuditEventGetAuditCategories.
        /// </summary>
        /// <returns>The <see cref="IAuditEventGetAuditCategoriesRequestBuilder"/>.</returns>
        IAuditEventGetAuditCategoriesRequestBuilder GetAuditCategories();
    }
}
