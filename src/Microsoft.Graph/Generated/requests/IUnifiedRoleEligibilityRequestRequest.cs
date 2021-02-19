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
    /// The interface IUnifiedRoleEligibilityRequestRequest.
    /// </summary>
    public partial interface IUnifiedRoleEligibilityRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRoleEligibilityRequestObject using POST.
        /// </summary>
        /// <param name="unifiedRoleEligibilityRequestObjectToCreate">The UnifiedRoleEligibilityRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleEligibilityRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilityRequestObject> CreateAsync(UnifiedRoleEligibilityRequestObject unifiedRoleEligibilityRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UnifiedRoleEligibilityRequestObject using POST and returns a <see cref="GraphResponse{UnifiedRoleEligibilityRequestObject}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityRequestObjectToCreate">The UnifiedRoleEligibilityRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilityRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityRequestObject>> CreateResponseAsync(UnifiedRoleEligibilityRequestObject unifiedRoleEligibilityRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleEligibilityRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleEligibilityRequestObject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilityRequestObject.
        /// </summary>
        /// <returns>The UnifiedRoleEligibilityRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilityRequestObject> GetAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilityRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleEligibilityRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilityRequestObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilityRequestObject and returns a <see cref="GraphResponse{UnifiedRoleEligibilityRequestObject}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilityRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityRequestObject>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleEligibilityRequestObject and returns a <see cref="GraphResponse{UnifiedRoleEligibilityRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilityRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityRequestObject>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilityRequestObject using PATCH.
        /// </summary>
        /// <param name="unifiedRoleEligibilityRequestObjectToUpdate">The UnifiedRoleEligibilityRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleEligibilityRequestObject.</returns>
        System.Threading.Tasks.Task<UnifiedRoleEligibilityRequestObject> UpdateAsync(UnifiedRoleEligibilityRequestObject unifiedRoleEligibilityRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRoleEligibilityRequestObject using PATCH and returns a <see cref="GraphResponse{UnifiedRoleEligibilityRequestObject}"/> object.
        /// </summary>
        /// <param name="unifiedRoleEligibilityRequestObjectToUpdate">The UnifiedRoleEligibilityRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleEligibilityRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleEligibilityRequestObject>> UpdateResponseAsync(UnifiedRoleEligibilityRequestObject unifiedRoleEligibilityRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityRequestRequest Expand(Expression<Func<UnifiedRoleEligibilityRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleEligibilityRequestRequest Select(Expression<Func<UnifiedRoleEligibilityRequestObject, object>> selectExpression);

    }
}
