// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICompanySalesOrderLinesCollectionRequest.
    /// </summary>
    public partial interface ICompanySalesOrderLinesCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified SalesOrderLine to the collection via POST.
        /// </summary>
        /// <param name="salesOrderLine">The SalesOrderLine to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SalesOrderLine.</returns>
        System.Threading.Tasks.Task<SalesOrderLine> AddAsync(SalesOrderLine salesOrderLine, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified SalesOrderLine to the collection via POST and returns a <see cref="GraphResponse{SalesOrderLine}"/> object of the request.
        /// </summary>
        /// <param name="salesOrderLine">The SalesOrderLine to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SalesOrderLine}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SalesOrderLine>> AddResponseAsync(SalesOrderLine salesOrderLine, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICompanySalesOrderLinesCollectionPage> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CompanySalesOrderLinesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CompanySalesOrderLinesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CompanySalesOrderLinesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesOrderLinesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesOrderLinesCollectionRequest Expand(Expression<Func<SalesOrderLine, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesOrderLinesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesOrderLinesCollectionRequest Select(Expression<Func<SalesOrderLine, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesOrderLinesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesOrderLinesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesOrderLinesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ICompanySalesOrderLinesCollectionRequest OrderBy(string value);
    }
}
