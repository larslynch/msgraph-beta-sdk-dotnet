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
    /// The interface IWindowsAutopilotDeploymentProfileRequest.
    /// </summary>
    public partial interface IWindowsAutopilotDeploymentProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsAutopilotDeploymentProfile using POST.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfileToCreate">The WindowsAutopilotDeploymentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfile> CreateAsync(WindowsAutopilotDeploymentProfile windowsAutopilotDeploymentProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WindowsAutopilotDeploymentProfile using POST and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfileToCreate">The WindowsAutopilotDeploymentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfile>> CreateResponseAsync(WindowsAutopilotDeploymentProfile windowsAutopilotDeploymentProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsAutopilotDeploymentProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <returns>The WindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfile> GetAsync();

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfile and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified WindowsAutopilotDeploymentProfile and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfile using PATCH.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfileToUpdate">The WindowsAutopilotDeploymentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsAutopilotDeploymentProfile.</returns>
        System.Threading.Tasks.Task<WindowsAutopilotDeploymentProfile> UpdateAsync(WindowsAutopilotDeploymentProfile windowsAutopilotDeploymentProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsAutopilotDeploymentProfile using PATCH and returns a <see cref="GraphResponse{WindowsAutopilotDeploymentProfile}"/> object.
        /// </summary>
        /// <param name="windowsAutopilotDeploymentProfileToUpdate">The WindowsAutopilotDeploymentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsAutopilotDeploymentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsAutopilotDeploymentProfile>> UpdateResponseAsync(WindowsAutopilotDeploymentProfile windowsAutopilotDeploymentProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfileRequest Expand(Expression<Func<WindowsAutopilotDeploymentProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsAutopilotDeploymentProfileRequest Select(Expression<Func<WindowsAutopilotDeploymentProfile, object>> selectExpression);

    }
}
