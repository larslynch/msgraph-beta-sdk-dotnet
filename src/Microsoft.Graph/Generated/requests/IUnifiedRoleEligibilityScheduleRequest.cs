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
    /// The interface IUnifiedRoleEligibilityScheduleRequest.
    /// </summary>
    public partial interface IUnifiedRoleEligibilityScheduleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRoleEligibilitySchedule using POST.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToCreate">The UnifiedRoleEligibilitySchedule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleEligibilitySchedule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilitySchedule> CreateAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UnifiedRoleEligibilitySchedule using POST and returns a <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToCreate">The UnifiedRoleEligibilitySchedule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilitySchedule>> CreateResponseAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleEligibilitySchedule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleEligibilitySchedule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilitySchedule.
        /// </summary>
        /// <returns>The UnifiedRoleEligibilitySchedule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilitySchedule> GetAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilitySchedule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleEligibilitySchedule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilitySchedule> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilitySchedule and returns a <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilitySchedule>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilitySchedule and returns a <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilitySchedule>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilitySchedule using PATCH.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToUpdate">The UnifiedRoleEligibilitySchedule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleEligibilitySchedule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilitySchedule> UpdateAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilitySchedule using PATCH and returns a <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityScheduleToUpdate">The UnifiedRoleEligibilitySchedule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilitySchedule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilitySchedule>> UpdateResponseAsync(UnifiedRoleEligibilitySchedule unifiedRoleEligibilityScheduleToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityScheduleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityScheduleRequest Expand(Expression<Func<UnifiedRoleEligibilitySchedule, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityScheduleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityScheduleRequest Select(Expression<Func<UnifiedRoleEligibilitySchedule, object>> selectExpression);

    }
}
