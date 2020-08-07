// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IB2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IB2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IB2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IB2cIdentityUserFlowIdentityProvidersCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IIdentityProviderWithReferenceRequestBuilder"/> for the specified IdentityProvider.
        /// </summary>
        /// <param name="id">The ID for the IdentityProvider.</param>
        /// <returns>The <see cref="IIdentityProviderWithReferenceRequestBuilder"/>.</returns>
        IIdentityProviderWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IB2cIdentityUserFlowIdentityProvidersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IB2cIdentityUserFlowIdentityProvidersCollectionReferencesRequestBuilder"/>.</returns>
        IB2cIdentityUserFlowIdentityProvidersCollectionReferencesRequestBuilder References { get; }

    }
}
