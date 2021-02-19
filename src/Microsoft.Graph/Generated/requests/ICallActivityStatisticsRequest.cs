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
    /// The interface ICallActivityStatisticsRequest.
    /// </summary>
    public partial interface ICallActivityStatisticsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CallActivityStatistics using POST.
        /// </summary>
        /// <param name="callActivityStatisticsToCreate">The CallActivityStatistics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CallActivityStatistics.</returns>
        System.Threading.Tasks.Task<CallActivityStatistics> CreateAsync(CallActivityStatistics callActivityStatisticsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified CallActivityStatistics using POST and returns a <see cref="GraphResponse{CallActivityStatistics}"/> object.
        /// </summary>
        /// <param name="callActivityStatisticsToCreate">The CallActivityStatistics to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CallActivityStatistics}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CallActivityStatistics>> CreateResponseAsync(CallActivityStatistics callActivityStatisticsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CallActivityStatistics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CallActivityStatistics and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified CallActivityStatistics.
        /// </summary>
        /// <returns>The CallActivityStatistics.</returns>
        System.Threading.Tasks.Task<CallActivityStatistics> GetAsync();

        /// <summary>
        /// Gets the specified CallActivityStatistics.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CallActivityStatistics.</returns>
        System.Threading.Tasks.Task<CallActivityStatistics> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CallActivityStatistics and returns a <see cref="GraphResponse{CallActivityStatistics}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{CallActivityStatistics}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CallActivityStatistics>> GetResponseAsync();

        /// <summary>
        /// Gets the specified CallActivityStatistics and returns a <see cref="GraphResponse{CallActivityStatistics}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CallActivityStatistics}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CallActivityStatistics>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CallActivityStatistics using PATCH.
        /// </summary>
        /// <param name="callActivityStatisticsToUpdate">The CallActivityStatistics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CallActivityStatistics.</returns>
        System.Threading.Tasks.Task<CallActivityStatistics> UpdateAsync(CallActivityStatistics callActivityStatisticsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified CallActivityStatistics using PATCH and returns a <see cref="GraphResponse{CallActivityStatistics}"/> object.
        /// </summary>
        /// <param name="callActivityStatisticsToUpdate">The CallActivityStatistics to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CallActivityStatistics}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CallActivityStatistics>> UpdateResponseAsync(CallActivityStatistics callActivityStatisticsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICallActivityStatisticsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICallActivityStatisticsRequest Expand(Expression<Func<CallActivityStatistics, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICallActivityStatisticsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICallActivityStatisticsRequest Select(Expression<Func<CallActivityStatistics, object>> selectExpression);

    }
}
