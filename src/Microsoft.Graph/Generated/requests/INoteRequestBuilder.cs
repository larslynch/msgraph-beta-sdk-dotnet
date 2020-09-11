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
    /// The interface INoteRequestBuilder.
    /// </summary>
    public partial interface INoteRequestBuilder : IOutlookItemRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new INoteRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new INoteRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Attachments.
        /// </summary>
        /// <returns>The <see cref="INoteAttachmentsCollectionRequestBuilder"/>.</returns>
        INoteAttachmentsCollectionRequestBuilder Attachments { get; }

        /// <summary>
        /// Gets the request builder for Extensions.
        /// </summary>
        /// <returns>The <see cref="INoteExtensionsCollectionRequestBuilder"/>.</returns>
        INoteExtensionsCollectionRequestBuilder Extensions { get; }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="INoteMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        INoteMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties { get; }

        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="INoteSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        INoteSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties { get; }
    
        
    
    }
}
