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
    /// The interface IUnifiedRoleAssignmentRequest.
    /// </summary>
    public partial interface IUnifiedRoleAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRoleAssignment using POST.
        /// </summary>
        /// <param name="unifiedRoleAssignmentToCreate">The UnifiedRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleAssignment.</returns>
        System.Threading.Tasks.Task<UnifiedRoleAssignment> CreateAsync(UnifiedRoleAssignment unifiedRoleAssignmentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UnifiedRoleAssignment using POST and returns a <see cref="GraphResponse{UnifiedRoleAssignment}"/> object.
        /// </summary>
        /// <param name="unifiedRoleAssignmentToCreate">The UnifiedRoleAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignment>> CreateResponseAsync(UnifiedRoleAssignment unifiedRoleAssignmentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnifiedRoleAssignment.
        /// </summary>
        /// <returns>The UnifiedRoleAssignment.</returns>
        System.Threading.Tasks.Task<UnifiedRoleAssignment> GetAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleAssignment.</returns>
        System.Threading.Tasks.Task<UnifiedRoleAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnifiedRoleAssignment and returns a <see cref="GraphResponse{UnifiedRoleAssignment}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignment>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleAssignment and returns a <see cref="GraphResponse{UnifiedRoleAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignment>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnifiedRoleAssignment using PATCH.
        /// </summary>
        /// <param name="unifiedRoleAssignmentToUpdate">The UnifiedRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleAssignment.</returns>
        System.Threading.Tasks.Task<UnifiedRoleAssignment> UpdateAsync(UnifiedRoleAssignment unifiedRoleAssignmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRoleAssignment using PATCH and returns a <see cref="GraphResponse{UnifiedRoleAssignment}"/> object.
        /// </summary>
        /// <param name="unifiedRoleAssignmentToUpdate">The UnifiedRoleAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignment>> UpdateResponseAsync(UnifiedRoleAssignment unifiedRoleAssignmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentRequest Expand(Expression<Func<UnifiedRoleAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentRequest Select(Expression<Func<UnifiedRoleAssignment, object>> selectExpression);

    }
}
