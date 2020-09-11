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
    /// The type PrivilegedRoleAssignmentRequestBuilder.
    /// </summary>
    public partial class PrivilegedRoleAssignmentRequestBuilder : EntityRequestBuilder, IPrivilegedRoleAssignmentRequestBuilder
    {

        /// <summary>
        /// Constructs a new PrivilegedRoleAssignmentRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrivilegedRoleAssignmentRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPrivilegedRoleAssignmentRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPrivilegedRoleAssignmentRequest Request(IEnumerable<Option> options)
        {
            return new PrivilegedRoleAssignmentRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RoleInfo.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleRequestBuilder"/>.</returns>
        public IPrivilegedRoleRequestBuilder RoleInfo
        {
            get
            {
                return new PrivilegedRoleRequestBuilder(this.AppendSegmentToRequestUrl("roleInfo"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for PrivilegedRoleAssignmentMakeEligible.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentMakeEligibleRequestBuilder"/>.</returns>
        public IPrivilegedRoleAssignmentMakeEligibleRequestBuilder MakeEligible()
        {
            return new PrivilegedRoleAssignmentMakeEligibleRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.makeEligible"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for PrivilegedRoleAssignmentMakePermanent.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedRoleAssignmentMakePermanentRequestBuilder"/>.</returns>
        public IPrivilegedRoleAssignmentMakePermanentRequestBuilder MakePermanent(
            string reason = null,
            string ticketNumber = null,
            string ticketSystem = null)
        {
            return new PrivilegedRoleAssignmentMakePermanentRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.makePermanent"),
                this.Client,
                reason,
                ticketNumber,
                ticketSystem);
        }
    
    }
}
