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
    /// The interface IGovernancePolicyTemplateRequest.
    /// </summary>
    public partial interface IGovernancePolicyTemplateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GovernancePolicyTemplate using POST.
        /// </summary>
        /// <param name="governancePolicyTemplateToCreate">The GovernancePolicyTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernancePolicyTemplate.</returns>
        System.Threading.Tasks.Task<GovernancePolicyTemplate> CreateAsync(GovernancePolicyTemplate governancePolicyTemplateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified GovernancePolicyTemplate using POST and returns a <see cref="GraphResponse{GovernancePolicyTemplate}"/> object.
        /// </summary>
        /// <param name="governancePolicyTemplateToCreate">The GovernancePolicyTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernancePolicyTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernancePolicyTemplate>> CreateResponseAsync(GovernancePolicyTemplate governancePolicyTemplateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified GovernancePolicyTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified GovernancePolicyTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified GovernancePolicyTemplate.
        /// </summary>
        /// <returns>The GovernancePolicyTemplate.</returns>
        System.Threading.Tasks.Task<GovernancePolicyTemplate> GetAsync();

        /// <summary>
        /// Gets the specified GovernancePolicyTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernancePolicyTemplate.</returns>
        System.Threading.Tasks.Task<GovernancePolicyTemplate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GovernancePolicyTemplate and returns a <see cref="GraphResponse{GovernancePolicyTemplate}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GovernancePolicyTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernancePolicyTemplate>> GetResponseAsync();

        /// <summary>
        /// Gets the specified GovernancePolicyTemplate and returns a <see cref="GraphResponse{GovernancePolicyTemplate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernancePolicyTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernancePolicyTemplate>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GovernancePolicyTemplate using PATCH.
        /// </summary>
        /// <param name="governancePolicyTemplateToUpdate">The GovernancePolicyTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GovernancePolicyTemplate.</returns>
        System.Threading.Tasks.Task<GovernancePolicyTemplate> UpdateAsync(GovernancePolicyTemplate governancePolicyTemplateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified GovernancePolicyTemplate using PATCH and returns a <see cref="GraphResponse{GovernancePolicyTemplate}"/> object.
        /// </summary>
        /// <param name="governancePolicyTemplateToUpdate">The GovernancePolicyTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GovernancePolicyTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernancePolicyTemplate>> UpdateResponseAsync(GovernancePolicyTemplate governancePolicyTemplateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernancePolicyTemplateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernancePolicyTemplateRequest Expand(Expression<Func<GovernancePolicyTemplate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernancePolicyTemplateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernancePolicyTemplateRequest Select(Expression<Func<GovernancePolicyTemplate, object>> selectExpression);

    }
}
