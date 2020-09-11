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
    /// The type AccessPackageAssignmentRequestBuilder.
    /// </summary>
    public partial class AccessPackageAssignmentRequestBuilder : EntityRequestBuilder, IAccessPackageAssignmentRequestBuilder
    {

        /// <summary>
        /// Constructs a new AccessPackageAssignmentRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessPackageAssignmentRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAccessPackageAssignmentRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAccessPackageAssignmentRequest Request(IEnumerable<Option> options)
        {
            return new AccessPackageAssignmentRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AccessPackage.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageRequestBuilder"/>.</returns>
        public IAccessPackageRequestBuilder AccessPackage
        {
            get
            {
                return new AccessPackageRequestBuilder(this.AppendSegmentToRequestUrl("accessPackage"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentPolicy.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentPolicyRequestBuilder"/>.</returns>
        public IAccessPackageAssignmentPolicyRequestBuilder AccessPackageAssignmentPolicy
        {
            get
            {
                return new AccessPackageAssignmentPolicyRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageAssignmentPolicy"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentRequests.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequestBuilder"/>.</returns>
        public IAccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequestBuilder AccessPackageAssignmentRequests
        {
            get
            {
                return new AccessPackageAssignmentAccessPackageAssignmentRequestsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageAssignmentRequests"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentResourceRoles.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentAccessPackageAssignmentResourceRolesCollectionRequestBuilder"/>.</returns>
        public IAccessPackageAssignmentAccessPackageAssignmentResourceRolesCollectionRequestBuilder AccessPackageAssignmentResourceRoles
        {
            get
            {
                return new AccessPackageAssignmentAccessPackageAssignmentResourceRolesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageAssignmentResourceRoles"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Target.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageSubjectRequestBuilder"/>.</returns>
        public IAccessPackageSubjectRequestBuilder Target
        {
            get
            {
                return new AccessPackageSubjectRequestBuilder(this.AppendSegmentToRequestUrl("target"), this.Client);
            }
        }
    
        
    
    }
}
