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
    /// The interface IUnifiedRoleManagementPolicyExpirationRuleRequest.
    /// </summary>
    public partial interface IUnifiedRoleManagementPolicyExpirationRuleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRoleManagementPolicyExpirationRule using POST.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyExpirationRuleToCreate">The UnifiedRoleManagementPolicyExpirationRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleManagementPolicyExpirationRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyExpirationRule> CreateAsync(UnifiedRoleManagementPolicyExpirationRule unifiedRoleManagementPolicyExpirationRuleToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UnifiedRoleManagementPolicyExpirationRule using POST and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyExpirationRule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyExpirationRuleToCreate">The UnifiedRoleManagementPolicyExpirationRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicyExpirationRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyExpirationRule>> CreateResponseAsync(UnifiedRoleManagementPolicyExpirationRule unifiedRoleManagementPolicyExpirationRuleToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleManagementPolicyExpirationRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleManagementPolicyExpirationRule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicyExpirationRule.
        /// </summary>
        /// <returns>The UnifiedRoleManagementPolicyExpirationRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyExpirationRule> GetAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicyExpirationRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleManagementPolicyExpirationRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyExpirationRule> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicyExpirationRule and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyExpirationRule}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicyExpirationRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyExpirationRule>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicyExpirationRule and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyExpirationRule}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicyExpirationRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyExpirationRule>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnifiedRoleManagementPolicyExpirationRule using PATCH.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyExpirationRuleToUpdate">The UnifiedRoleManagementPolicyExpirationRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleManagementPolicyExpirationRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyExpirationRule> UpdateAsync(UnifiedRoleManagementPolicyExpirationRule unifiedRoleManagementPolicyExpirationRuleToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRoleManagementPolicyExpirationRule using PATCH and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyExpirationRule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyExpirationRuleToUpdate">The UnifiedRoleManagementPolicyExpirationRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicyExpirationRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyExpirationRule>> UpdateResponseAsync(UnifiedRoleManagementPolicyExpirationRule unifiedRoleManagementPolicyExpirationRuleToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyExpirationRuleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyExpirationRuleRequest Expand(Expression<Func<UnifiedRoleManagementPolicyExpirationRule, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyExpirationRuleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyExpirationRuleRequest Select(Expression<Func<UnifiedRoleManagementPolicyExpirationRule, object>> selectExpression);

    }
}
