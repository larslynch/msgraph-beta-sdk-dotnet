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
    /// The interface IUnifiedRoleAssignmentRequestRequest.
    /// </summary>
    public partial interface IUnifiedRoleAssignmentRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRoleAssignmentRequestObject using POST.
        /// </summary>
        /// <param name="unifiedRoleAssignmentRequestObjectToCreate">The UnifiedRoleAssignmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleAssignmentRequestObject> CreateAsync(UnifiedRoleAssignmentRequestObject unifiedRoleAssignmentRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UnifiedRoleAssignmentRequestObject using POST and returns a <see cref="GraphResponse{UnifiedRoleAssignmentRequestObject}"/> object.
        /// </summary>
        /// <param name="unifiedRoleAssignmentRequestObjectToCreate">The UnifiedRoleAssignmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignmentRequestObject>> CreateResponseAsync(UnifiedRoleAssignmentRequestObject unifiedRoleAssignmentRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleAssignmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleAssignmentRequestObject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnifiedRoleAssignmentRequestObject.
        /// </summary>
        /// <returns>The UnifiedRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleAssignmentRequestObject> GetAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleAssignmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleAssignmentRequestObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnifiedRoleAssignmentRequestObject and returns a <see cref="GraphResponse{UnifiedRoleAssignmentRequestObject}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignmentRequestObject>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleAssignmentRequestObject and returns a <see cref="GraphResponse{UnifiedRoleAssignmentRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignmentRequestObject>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnifiedRoleAssignmentRequestObject using PATCH.
        /// </summary>
        /// <param name="unifiedRoleAssignmentRequestObjectToUpdate">The UnifiedRoleAssignmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleAssignmentRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleAssignmentRequestObject> UpdateAsync(UnifiedRoleAssignmentRequestObject unifiedRoleAssignmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRoleAssignmentRequestObject using PATCH and returns a <see cref="GraphResponse{UnifiedRoleAssignmentRequestObject}"/> object.
        /// </summary>
        /// <param name="unifiedRoleAssignmentRequestObjectToUpdate">The UnifiedRoleAssignmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleAssignmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleAssignmentRequestObject>> UpdateResponseAsync(UnifiedRoleAssignmentRequestObject unifiedRoleAssignmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentRequestRequest Expand(Expression<Func<UnifiedRoleAssignmentRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleAssignmentRequestRequest Select(Expression<Func<UnifiedRoleAssignmentRequestObject, object>> selectExpression);

    }
}
