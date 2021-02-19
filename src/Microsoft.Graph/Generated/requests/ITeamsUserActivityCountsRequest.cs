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
    /// The interface ITeamsUserActivityCountsRequest.
    /// </summary>
    public partial interface ITeamsUserActivityCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamsUserActivityCounts using POST.
        /// </summary>
        /// <param name="teamsUserActivityCountsToCreate">The TeamsUserActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsUserActivityCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityCounts> CreateAsync(TeamsUserActivityCounts teamsUserActivityCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified TeamsUserActivityCounts using POST and returns a <see cref="GraphResponse{TeamsUserActivityCounts}"/> object.
        /// </summary>
        /// <param name="teamsUserActivityCountsToCreate">The TeamsUserActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityCounts>> CreateResponseAsync(TeamsUserActivityCounts teamsUserActivityCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamsUserActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamsUserActivityCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TeamsUserActivityCounts.
        /// </summary>
        /// <returns>The TeamsUserActivityCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityCounts> GetAsync();

        /// <summary>
        /// Gets the specified TeamsUserActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsUserActivityCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TeamsUserActivityCounts and returns a <see cref="GraphResponse{TeamsUserActivityCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityCounts>> GetResponseAsync();

        /// <summary>
        /// Gets the specified TeamsUserActivityCounts and returns a <see cref="GraphResponse{TeamsUserActivityCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityCounts>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TeamsUserActivityCounts using PATCH.
        /// </summary>
        /// <param name="teamsUserActivityCountsToUpdate">The TeamsUserActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsUserActivityCounts.</returns>
        System.Threading.Tasks.Task<TeamsUserActivityCounts> UpdateAsync(TeamsUserActivityCounts teamsUserActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamsUserActivityCounts using PATCH and returns a <see cref="GraphResponse{TeamsUserActivityCounts}"/> object.
        /// </summary>
        /// <param name="teamsUserActivityCountsToUpdate">The TeamsUserActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsUserActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsUserActivityCounts>> UpdateResponseAsync(TeamsUserActivityCounts teamsUserActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityCountsRequest Expand(Expression<Func<TeamsUserActivityCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsUserActivityCountsRequest Select(Expression<Func<TeamsUserActivityCounts, object>> selectExpression);

    }
}
