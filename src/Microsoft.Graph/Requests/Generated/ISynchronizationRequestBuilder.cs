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
    /// The interface ISynchronizationRequestBuilder.
    /// </summary>
    public partial interface ISynchronizationRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ISynchronizationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ISynchronizationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Jobs.
        /// </summary>
        /// <returns>The <see cref="ISynchronizationJobsCollectionRequestBuilder"/>.</returns>
        ISynchronizationJobsCollectionRequestBuilder Jobs { get; }

        /// <summary>
        /// Gets the request builder for Templates.
        /// </summary>
        /// <returns>The <see cref="ISynchronizationTemplatesCollectionRequestBuilder"/>.</returns>
        ISynchronizationTemplatesCollectionRequestBuilder Templates { get; }
    
        /// <summary>
        /// Gets the request builder for SynchronizationAcquireAccessToken.
        /// </summary>
        /// <returns>The <see cref="ISynchronizationAcquireAccessTokenRequestBuilder"/>.</returns>
        ISynchronizationAcquireAccessTokenRequestBuilder AcquireAccessToken(
            IEnumerable<SynchronizationSecretKeyStringValuePair> credentials = null);

        /// <summary>
        /// Gets the request builder for SynchronizationPing.
        /// </summary>
        /// <returns>The <see cref="ISynchronizationPingRequestBuilder"/>.</returns>
        ISynchronizationPingRequestBuilder Ping();
    
    }
}
