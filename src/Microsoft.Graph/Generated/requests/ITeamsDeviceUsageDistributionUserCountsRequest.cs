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
    /// The interface ITeamsDeviceUsageDistributionUserCountsRequest.
    /// </summary>
    public partial interface ITeamsDeviceUsageDistributionUserCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TeamsDeviceUsageDistributionUserCounts using POST.
        /// </summary>
        /// <param name="teamsDeviceUsageDistributionUserCountsToCreate">The TeamsDeviceUsageDistributionUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TeamsDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsDeviceUsageDistributionUserCounts> CreateAsync(TeamsDeviceUsageDistributionUserCounts teamsDeviceUsageDistributionUserCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified TeamsDeviceUsageDistributionUserCounts using POST and returns a <see cref="GraphResponse{TeamsDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="teamsDeviceUsageDistributionUserCountsToCreate">The TeamsDeviceUsageDistributionUserCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsDeviceUsageDistributionUserCounts>> CreateResponseAsync(TeamsDeviceUsageDistributionUserCounts teamsDeviceUsageDistributionUserCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamsDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified TeamsDeviceUsageDistributionUserCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified TeamsDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <returns>The TeamsDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsDeviceUsageDistributionUserCounts> GetAsync();

        /// <summary>
        /// Gets the specified TeamsDeviceUsageDistributionUserCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TeamsDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsDeviceUsageDistributionUserCounts> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TeamsDeviceUsageDistributionUserCounts and returns a <see cref="GraphResponse{TeamsDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{TeamsDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsDeviceUsageDistributionUserCounts>> GetResponseAsync();

        /// <summary>
        /// Gets the specified TeamsDeviceUsageDistributionUserCounts and returns a <see cref="GraphResponse{TeamsDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TeamsDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsDeviceUsageDistributionUserCounts>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TeamsDeviceUsageDistributionUserCounts using PATCH.
        /// </summary>
        /// <param name="teamsDeviceUsageDistributionUserCountsToUpdate">The TeamsDeviceUsageDistributionUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TeamsDeviceUsageDistributionUserCounts.</returns>
        System.Threading.Tasks.Task<TeamsDeviceUsageDistributionUserCounts> UpdateAsync(TeamsDeviceUsageDistributionUserCounts teamsDeviceUsageDistributionUserCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified TeamsDeviceUsageDistributionUserCounts using PATCH and returns a <see cref="GraphResponse{TeamsDeviceUsageDistributionUserCounts}"/> object.
        /// </summary>
        /// <param name="teamsDeviceUsageDistributionUserCountsToUpdate">The TeamsDeviceUsageDistributionUserCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TeamsDeviceUsageDistributionUserCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TeamsDeviceUsageDistributionUserCounts>> UpdateResponseAsync(TeamsDeviceUsageDistributionUserCounts teamsDeviceUsageDistributionUserCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsDeviceUsageDistributionUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsDeviceUsageDistributionUserCountsRequest Expand(Expression<Func<TeamsDeviceUsageDistributionUserCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsDeviceUsageDistributionUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITeamsDeviceUsageDistributionUserCountsRequest Select(Expression<Func<TeamsDeviceUsageDistributionUserCounts, object>> selectExpression);

    }
}
