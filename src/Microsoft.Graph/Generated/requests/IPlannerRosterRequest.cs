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
    /// The interface IPlannerRosterRequest.
    /// </summary>
    public partial interface IPlannerRosterRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlannerRoster using POST.
        /// </summary>
        /// <param name="plannerRosterToCreate">The PlannerRoster to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerRoster.</returns>
        System.Threading.Tasks.Task<PlannerRoster> CreateAsync(PlannerRoster plannerRosterToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified PlannerRoster using POST and returns a <see cref="GraphResponse{PlannerRoster}"/> object.
        /// </summary>
        /// <param name="plannerRosterToCreate">The PlannerRoster to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerRoster}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerRoster>> CreateResponseAsync(PlannerRoster plannerRosterToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PlannerRoster.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PlannerRoster and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PlannerRoster.
        /// </summary>
        /// <returns>The PlannerRoster.</returns>
        System.Threading.Tasks.Task<PlannerRoster> GetAsync();

        /// <summary>
        /// Gets the specified PlannerRoster.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerRoster.</returns>
        System.Threading.Tasks.Task<PlannerRoster> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlannerRoster and returns a <see cref="GraphResponse{PlannerRoster}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PlannerRoster}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerRoster>> GetResponseAsync();

        /// <summary>
        /// Gets the specified PlannerRoster and returns a <see cref="GraphResponse{PlannerRoster}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PlannerRoster}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerRoster>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlannerRoster using PATCH.
        /// </summary>
        /// <param name="plannerRosterToUpdate">The PlannerRoster to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerRoster.</returns>
        System.Threading.Tasks.Task<PlannerRoster> UpdateAsync(PlannerRoster plannerRosterToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PlannerRoster using PATCH and returns a <see cref="GraphResponse{PlannerRoster}"/> object.
        /// </summary>
        /// <param name="plannerRosterToUpdate">The PlannerRoster to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PlannerRoster}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PlannerRoster>> UpdateResponseAsync(PlannerRoster plannerRosterToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRosterRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRosterRequest Expand(Expression<Func<PlannerRoster, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRosterRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerRosterRequest Select(Expression<Func<PlannerRoster, object>> selectExpression);

    }
}
