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
    /// The interface ISkypeForBusinessActivityCountsRequest.
    /// </summary>
    public partial interface ISkypeForBusinessActivityCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SkypeForBusinessActivityCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessActivityCountsToCreate">The SkypeForBusinessActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessActivityCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessActivityCounts> CreateAsync(SkypeForBusinessActivityCounts skypeForBusinessActivityCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SkypeForBusinessActivityCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessActivityCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessActivityCountsToCreate">The SkypeForBusinessActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessActivityCounts>> CreateResponseAsync(SkypeForBusinessActivityCounts skypeForBusinessActivityCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SkypeForBusinessActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SkypeForBusinessActivityCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SkypeForBusinessActivityCounts.
        /// </summary>
        /// <returns>The SkypeForBusinessActivityCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessActivityCounts> GetAsync();

        /// <summary>
        /// Gets the specified SkypeForBusinessActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessActivityCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessActivityCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SkypeForBusinessActivityCounts and returns a <see cref="GraphResponse{SkypeForBusinessActivityCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessActivityCounts>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SkypeForBusinessActivityCounts and returns a <see cref="GraphResponse{SkypeForBusinessActivityCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessActivityCounts>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SkypeForBusinessActivityCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessActivityCountsToUpdate">The SkypeForBusinessActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeForBusinessActivityCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessActivityCounts> UpdateAsync(SkypeForBusinessActivityCounts skypeForBusinessActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SkypeForBusinessActivityCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessActivityCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessActivityCountsToUpdate">The SkypeForBusinessActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessActivityCounts>> UpdateResponseAsync(SkypeForBusinessActivityCounts skypeForBusinessActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessActivityCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessActivityCountsRequest Expand(Expression<Func<SkypeForBusinessActivityCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessActivityCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessActivityCountsRequest Select(Expression<Func<SkypeForBusinessActivityCounts, object>> selectExpression);

    }
}
