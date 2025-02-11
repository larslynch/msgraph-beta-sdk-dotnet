// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ITagChildTagsCollectionReferencesRequestBuilder.
    /// </summary>
    public partial interface ITagChildTagsCollectionReferencesRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ITagChildTagsCollectionReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ITagChildTagsCollectionReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    }
}
