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
    /// The interface IReportRootApplicationSignInDetailedSummaryCollectionRequest.
    /// </summary>
    public partial interface IReportRootApplicationSignInDetailedSummaryCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified ApplicationSignInDetailedSummary to the collection via POST.
        /// </summary>
        /// <param name="applicationSignInDetailedSummary">The ApplicationSignInDetailedSummary to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ApplicationSignInDetailedSummary.</returns>
        System.Threading.Tasks.Task<ApplicationSignInDetailedSummary> AddAsync(ApplicationSignInDetailedSummary applicationSignInDetailedSummary, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified ApplicationSignInDetailedSummary to the collection via POST and returns a <see cref="GraphResponse{ApplicationSignInDetailedSummary}"/> object of the request.
        /// </summary>
        /// <param name="applicationSignInDetailedSummary">The ApplicationSignInDetailedSummary to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ApplicationSignInDetailedSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ApplicationSignInDetailedSummary>> AddResponseAsync(ApplicationSignInDetailedSummary applicationSignInDetailedSummary, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IReportRootApplicationSignInDetailedSummaryCollectionPage> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{ReportRootApplicationSignInDetailedSummaryCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ReportRootApplicationSignInDetailedSummaryCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRootApplicationSignInDetailedSummaryCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootApplicationSignInDetailedSummaryCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootApplicationSignInDetailedSummaryCollectionRequest Expand(Expression<Func<ApplicationSignInDetailedSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootApplicationSignInDetailedSummaryCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootApplicationSignInDetailedSummaryCollectionRequest Select(Expression<Func<ApplicationSignInDetailedSummary, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootApplicationSignInDetailedSummaryCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootApplicationSignInDetailedSummaryCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootApplicationSignInDetailedSummaryCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootApplicationSignInDetailedSummaryCollectionRequest OrderBy(string value);
    }
}
