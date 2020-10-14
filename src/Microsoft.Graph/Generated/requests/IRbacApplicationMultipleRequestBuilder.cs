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
    /// The interface IRbacApplicationMultipleRequestBuilder.
    /// </summary>
    public partial interface IRbacApplicationMultipleRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IRbacApplicationMultipleRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IRbacApplicationMultipleRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ResourceNamespaces.
        /// </summary>
        /// <returns>The <see cref="IRbacApplicationMultipleResourceNamespacesCollectionRequestBuilder"/>.</returns>
        IRbacApplicationMultipleResourceNamespacesCollectionRequestBuilder ResourceNamespaces { get; }

        /// <summary>
        /// Gets the request builder for RoleAssignments.
        /// </summary>
        /// <returns>The <see cref="IRbacApplicationMultipleRoleAssignmentsCollectionRequestBuilder"/>.</returns>
        IRbacApplicationMultipleRoleAssignmentsCollectionRequestBuilder RoleAssignments { get; }

        /// <summary>
        /// Gets the request builder for RoleDefinitions.
        /// </summary>
        /// <returns>The <see cref="IRbacApplicationMultipleRoleDefinitionsCollectionRequestBuilder"/>.</returns>
        IRbacApplicationMultipleRoleDefinitionsCollectionRequestBuilder RoleDefinitions { get; }
    
    }
}
