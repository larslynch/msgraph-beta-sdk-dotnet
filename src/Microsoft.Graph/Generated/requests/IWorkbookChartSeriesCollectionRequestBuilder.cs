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
    /// The interface IWorkbookChartSeriesCollectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookChartSeriesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWorkbookChartSeriesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookChartSeriesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWorkbookChartSeriesRequestBuilder"/> for the specified WorkbookChartSeries.
        /// </summary>
        /// <param name="id">The ID for the WorkbookChartSeries.</param>
        /// <returns>The <see cref="IWorkbookChartSeriesRequestBuilder"/>.</returns>
        IWorkbookChartSeriesRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for WorkbookChartSeriesCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesCountRequestBuilder"/>.</returns>
        IWorkbookChartSeriesCountRequestBuilder Count();

        /// <summary>
        /// Gets the request builder for WorkbookChartSeriesItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesItemAtRequestBuilder"/>.</returns>
        IWorkbookChartSeriesItemAtRequestBuilder ItemAt(
            Int32 index);
    }
}
