// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IRbacApplicationRoleAssignmentRequestsCollectionRequestBuilder.
    /// </summary>
    public partial interface IRbacApplicationRoleAssignmentRequestsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IRbacApplicationRoleAssignmentRequestsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IRbacApplicationRoleAssignmentRequestsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUnifiedRoleAssignmentRequestRequestBuilder"/> for the specified UnifiedRoleAssignmentRequest.
        /// </summary>
        /// <param name="id">The ID for the UnifiedRoleAssignmentRequest.</param>
        /// <returns>The <see cref="IUnifiedRoleAssignmentRequestRequestBuilder"/>.</returns>
        IUnifiedRoleAssignmentRequestRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for UnifiedRoleAssignmentRequestFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IUnifiedRoleAssignmentRequestFilterByCurrentUserRequestBuilder"/>.</returns>
        IUnifiedRoleAssignmentRequestFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            RoleAssignmentRequestFilterByCurrentUserOptions on);
    }
}
