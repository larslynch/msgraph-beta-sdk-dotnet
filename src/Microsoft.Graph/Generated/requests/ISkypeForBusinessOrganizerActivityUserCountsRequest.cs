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
    /// The interface ISkypeForBusinessOrganizerActivityUserCountsRequest.
    /// </summary>
    public partial interface ISkypeForBusinessOrganizerActivityUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SkypeForBusinessOrganizerActivityUserCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityUserCountsToCreate">The SkypeForBusinessOrganizerActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessOrganizerActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityUserCounts> CreateAsync(SkypeForBusinessOrganizerActivityUserCounts skypeForBusinessOrganizerActivityUserCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SkypeForBusinessOrganizerActivityUserCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessOrganizerActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityUserCountsToCreate">The SkypeForBusinessOrganizerActivityUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessOrganizerActivityUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessOrganizerActivityUserCounts>> CreateResponseAsync(SkypeForBusinessOrganizerActivityUserCounts skypeForBusinessOrganizerActivityUserCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SkypeForBusinessOrganizerActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SkypeForBusinessOrganizerActivityUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SkypeForBusinessOrganizerActivityUserCounts.
        /// </summary>
        /// <returns>The SkypeForBusinessOrganizerActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityUserCounts> GetAsync();

        /// <summary>
        /// Gets the specified SkypeForBusinessOrganizerActivityUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessOrganizerActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityUserCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SkypeForBusinessOrganizerActivityUserCounts and returns a <see cref="GraphResponse{SkypeForBusinessOrganizerActivityUserCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessOrganizerActivityUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessOrganizerActivityUserCounts>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SkypeForBusinessOrganizerActivityUserCounts and returns a <see cref="GraphResponse{SkypeForBusinessOrganizerActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessOrganizerActivityUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessOrganizerActivityUserCounts>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SkypeForBusinessOrganizerActivityUserCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityUserCountsToUpdate">The SkypeForBusinessOrganizerActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeForBusinessOrganizerActivityUserCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityUserCounts> UpdateAsync(SkypeForBusinessOrganizerActivityUserCounts skypeForBusinessOrganizerActivityUserCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SkypeForBusinessOrganizerActivityUserCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessOrganizerActivityUserCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityUserCountsToUpdate">The SkypeForBusinessOrganizerActivityUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessOrganizerActivityUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessOrganizerActivityUserCounts>> UpdateResponseAsync(SkypeForBusinessOrganizerActivityUserCounts skypeForBusinessOrganizerActivityUserCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityUserCountsRequest Expand(Expression<Func<SkypeForBusinessOrganizerActivityUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityUserCountsRequest Select(Expression<Func<SkypeForBusinessOrganizerActivityUserCounts, object>> selectExpression);

    }
}
