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
    /// The interface IIdentityContainerRequestBuilder.
    /// </summary>
    public partial interface IIdentityContainerRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IIdentityContainerRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IIdentityContainerRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ConditionalAccess.
        /// </summary>
        /// <returns>The <see cref="IConditionalAccessRootRequestBuilder"/>.</returns>
        IConditionalAccessRootRequestBuilder ConditionalAccess { get; }

        /// <summary>
        /// Gets the request builder for B2cUserFlows.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerB2cUserFlowsCollectionRequestBuilder"/>.</returns>
        IIdentityContainerB2cUserFlowsCollectionRequestBuilder B2cUserFlows { get; }

        /// <summary>
        /// Gets the request builder for B2xUserFlows.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerB2xUserFlowsCollectionRequestBuilder"/>.</returns>
        IIdentityContainerB2xUserFlowsCollectionRequestBuilder B2xUserFlows { get; }

        /// <summary>
        /// Gets the request builder for UserFlows.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerUserFlowsCollectionRequestBuilder"/>.</returns>
        IIdentityContainerUserFlowsCollectionRequestBuilder UserFlows { get; }

        /// <summary>
        /// Gets the request builder for ContinuousAccessEvaluationPolicy.
        /// </summary>
        /// <returns>The <see cref="IContinuousAccessEvaluationPolicyRequestBuilder"/>.</returns>
        IContinuousAccessEvaluationPolicyRequestBuilder ContinuousAccessEvaluationPolicy { get; }
    
    }
}
