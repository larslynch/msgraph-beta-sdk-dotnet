// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IWorkbookTablesCollectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookTablesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWorkbookTablesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookTablesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWorkbookTableRequestBuilder"/> for the specified WorkbookTable.
        /// </summary>
        /// <param name="id">The ID for the WorkbookTable.</param>
        /// <returns>The <see cref="IWorkbookTableRequestBuilder"/>.</returns>
        IWorkbookTableRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for WorkbookTableAdd.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableAddRequestBuilder"/>.</returns>
        IWorkbookTableAddRequestBuilder Add(
            bool hasHeaders,
            string address = null);

        /// <summary>
        /// Gets the request builder for WorkbookTableCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableCountRequestBuilder"/>.</returns>
        IWorkbookTableCountRequestBuilder Count();

        /// <summary>
        /// Gets the request builder for WorkbookTableItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookTableItemAtRequestBuilder"/>.</returns>
        IWorkbookTableItemAtRequestBuilder ItemAt(
            Int32 index);
    }
}
