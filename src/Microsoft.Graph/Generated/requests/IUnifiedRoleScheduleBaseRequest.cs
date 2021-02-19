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
    /// The interface IUnifiedRoleScheduleBaseRequest.
    /// </summary>
    public partial interface IUnifiedRoleScheduleBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRoleScheduleBase using POST.
        /// </summary>
        /// <param name="unifiedRoleScheduleBaseToCreate">The UnifiedRoleScheduleBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleScheduleBase.</returns>
        System.Threading.Tasks.Task<UnifiedRoleScheduleBase> CreateAsync(UnifiedRoleScheduleBase unifiedRoleScheduleBaseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UnifiedRoleScheduleBase using POST and returns a <see cref="GraphResponse{UnifiedRoleScheduleBase}"/> object.
        /// </summary>
        /// <param name="unifiedRoleScheduleBaseToCreate">The UnifiedRoleScheduleBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleScheduleBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleScheduleBase>> CreateResponseAsync(UnifiedRoleScheduleBase unifiedRoleScheduleBaseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleScheduleBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleScheduleBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnifiedRoleScheduleBase.
        /// </summary>
        /// <returns>The UnifiedRoleScheduleBase.</returns>
        System.Threading.Tasks.Task<UnifiedRoleScheduleBase> GetAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleScheduleBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleScheduleBase.</returns>
        System.Threading.Tasks.Task<UnifiedRoleScheduleBase> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnifiedRoleScheduleBase and returns a <see cref="GraphResponse{UnifiedRoleScheduleBase}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleScheduleBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleScheduleBase>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleScheduleBase and returns a <see cref="GraphResponse{UnifiedRoleScheduleBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleScheduleBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleScheduleBase>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnifiedRoleScheduleBase using PATCH.
        /// </summary>
        /// <param name="unifiedRoleScheduleBaseToUpdate">The UnifiedRoleScheduleBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleScheduleBase.</returns>
        System.Threading.Tasks.Task<UnifiedRoleScheduleBase> UpdateAsync(UnifiedRoleScheduleBase unifiedRoleScheduleBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRoleScheduleBase using PATCH and returns a <see cref="GraphResponse{UnifiedRoleScheduleBase}"/> object.
        /// </summary>
        /// <param name="unifiedRoleScheduleBaseToUpdate">The UnifiedRoleScheduleBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleScheduleBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleScheduleBase>> UpdateResponseAsync(UnifiedRoleScheduleBase unifiedRoleScheduleBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleScheduleBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleScheduleBaseRequest Expand(Expression<Func<UnifiedRoleScheduleBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleScheduleBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleScheduleBaseRequest Select(Expression<Func<UnifiedRoleScheduleBase, object>> selectExpression);

    }
}
