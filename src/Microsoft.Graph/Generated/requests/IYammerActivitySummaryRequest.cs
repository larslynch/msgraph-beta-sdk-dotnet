// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IYammerActivitySummaryRequest.
    /// </summary>
    public partial interface IYammerActivitySummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified YammerActivitySummary using POST.
        /// </summary>
        /// <param name="yammerActivitySummaryToCreate">The YammerActivitySummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created YammerActivitySummary.</returns>
        System.Threading.Tasks.Task<YammerActivitySummary> CreateAsync(YammerActivitySummary yammerActivitySummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified YammerActivitySummary using POST and returns a <see cref="GraphResponse{YammerActivitySummary}"/> object.
        /// </summary>
        /// <param name="yammerActivitySummaryToCreate">The YammerActivitySummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{YammerActivitySummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerActivitySummary>> CreateResponseAsync(YammerActivitySummary yammerActivitySummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified YammerActivitySummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified YammerActivitySummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified YammerActivitySummary.
        /// </summary>
        /// <returns>The YammerActivitySummary.</returns>
        System.Threading.Tasks.Task<YammerActivitySummary> GetAsync();

        /// <summary>
        /// Gets the specified YammerActivitySummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The YammerActivitySummary.</returns>
        System.Threading.Tasks.Task<YammerActivitySummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified YammerActivitySummary and returns a <see cref="GraphResponse{YammerActivitySummary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{YammerActivitySummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerActivitySummary>> GetResponseAsync();

        /// <summary>
        /// Gets the specified YammerActivitySummary and returns a <see cref="GraphResponse{YammerActivitySummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{YammerActivitySummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerActivitySummary>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified YammerActivitySummary using PATCH.
        /// </summary>
        /// <param name="yammerActivitySummaryToUpdate">The YammerActivitySummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated YammerActivitySummary.</returns>
        System.Threading.Tasks.Task<YammerActivitySummary> UpdateAsync(YammerActivitySummary yammerActivitySummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified YammerActivitySummary using PATCH and returns a <see cref="GraphResponse{YammerActivitySummary}"/> object.
        /// </summary>
        /// <param name="yammerActivitySummaryToUpdate">The YammerActivitySummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{YammerActivitySummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<YammerActivitySummary>> UpdateResponseAsync(YammerActivitySummary yammerActivitySummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IYammerActivitySummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IYammerActivitySummaryRequest Expand(Expression<Func<YammerActivitySummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IYammerActivitySummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IYammerActivitySummaryRequest Select(Expression<Func<YammerActivitySummary, object>> selectExpression);

    }
}
