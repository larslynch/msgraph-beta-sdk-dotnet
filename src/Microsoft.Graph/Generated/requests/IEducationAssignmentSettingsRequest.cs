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
    /// The interface IEducationAssignmentSettingsRequest.
    /// </summary>
    public partial interface IEducationAssignmentSettingsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EducationAssignmentSettings using POST.
        /// </summary>
        /// <param name="educationAssignmentSettingsToCreate">The EducationAssignmentSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationAssignmentSettings.</returns>
        System.Threading.Tasks.Task<EducationAssignmentSettings> CreateAsync(EducationAssignmentSettings educationAssignmentSettingsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified EducationAssignmentSettings using POST and returns a <see cref="GraphResponse{EducationAssignmentSettings}"/> object.
        /// </summary>
        /// <param name="educationAssignmentSettingsToCreate">The EducationAssignmentSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignmentSettings>> CreateResponseAsync(EducationAssignmentSettings educationAssignmentSettingsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EducationAssignmentSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EducationAssignmentSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EducationAssignmentSettings.
        /// </summary>
        /// <returns>The EducationAssignmentSettings.</returns>
        System.Threading.Tasks.Task<EducationAssignmentSettings> GetAsync();

        /// <summary>
        /// Gets the specified EducationAssignmentSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationAssignmentSettings.</returns>
        System.Threading.Tasks.Task<EducationAssignmentSettings> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EducationAssignmentSettings and returns a <see cref="GraphResponse{EducationAssignmentSettings}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignmentSettings>> GetResponseAsync();

        /// <summary>
        /// Gets the specified EducationAssignmentSettings and returns a <see cref="GraphResponse{EducationAssignmentSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignmentSettings>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EducationAssignmentSettings using PATCH.
        /// </summary>
        /// <param name="educationAssignmentSettingsToUpdate">The EducationAssignmentSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EducationAssignmentSettings.</returns>
        System.Threading.Tasks.Task<EducationAssignmentSettings> UpdateAsync(EducationAssignmentSettings educationAssignmentSettingsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EducationAssignmentSettings using PATCH and returns a <see cref="GraphResponse{EducationAssignmentSettings}"/> object.
        /// </summary>
        /// <param name="educationAssignmentSettingsToUpdate">The EducationAssignmentSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EducationAssignmentSettings}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EducationAssignmentSettings>> UpdateResponseAsync(EducationAssignmentSettings educationAssignmentSettingsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentSettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentSettingsRequest Expand(Expression<Func<EducationAssignmentSettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentSettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEducationAssignmentSettingsRequest Select(Expression<Func<EducationAssignmentSettings, object>> selectExpression);

    }
}
