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
    /// The interface IIdentityProtectionRootRequestBuilder.
    /// </summary>
    public partial interface IIdentityProtectionRootRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IIdentityProtectionRootRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IIdentityProtectionRootRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for RiskDetections.
        /// </summary>
        /// <returns>The <see cref="IIdentityProtectionRootRiskDetectionsCollectionRequestBuilder"/>.</returns>
        IIdentityProtectionRootRiskDetectionsCollectionRequestBuilder RiskDetections { get; }

        /// <summary>
        /// Gets the request builder for RiskyUsers.
        /// </summary>
        /// <returns>The <see cref="IIdentityProtectionRootRiskyUsersCollectionRequestBuilder"/>.</returns>
        IIdentityProtectionRootRiskyUsersCollectionRequestBuilder RiskyUsers { get; }
    
    }
}
