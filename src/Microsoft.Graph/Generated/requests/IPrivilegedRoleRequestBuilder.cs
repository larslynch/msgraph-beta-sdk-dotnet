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
    /// The interface IPrivilegedRoleRequestBuilder.
    /// </summary>
    public partial interface IPrivilegedRoleRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IPrivilegedRoleRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IPrivilegedRoleRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentsCollectionWithReferencesRequestBuilder"/>.</returns>
        IPrivilegedRoleAssignmentsCollectionWithReferencesRequestBuilder Assignments { get; }

        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleSettingsRequestBuilder"/>.</returns>
        IPrivilegedRoleSettingsRequestBuilder Settings { get; }

        /// <summary>
        /// Gets the request builder for Summary.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleSummaryRequestBuilder"/>.</returns>
        IPrivilegedRoleSummaryRequestBuilder Summary { get; }
    
        /// <summary>
        /// Gets the request builder for PrivilegedRoleSelfActivate.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleSelfActivateRequestBuilder"/>.</returns>
        IPrivilegedRoleSelfActivateRequestBuilder SelfActivate(
            string reason = null,
            string duration = null,
            string ticketNumber = null,
            string ticketSystem = null);

        /// <summary>
        /// Gets the request builder for PrivilegedRoleSelfDeactivate.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleSelfDeactivateRequestBuilder"/>.</returns>
        IPrivilegedRoleSelfDeactivateRequestBuilder SelfDeactivate();
    
    }
}
