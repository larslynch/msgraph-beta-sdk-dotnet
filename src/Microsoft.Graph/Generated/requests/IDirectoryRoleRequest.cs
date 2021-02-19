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
    /// The interface IDirectoryRoleRequest.
    /// </summary>
    public partial interface IDirectoryRoleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DirectoryRole using POST.
        /// </summary>
        /// <param name="directoryRoleToCreate">The DirectoryRole to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryRole.</returns>
        System.Threading.Tasks.Task<DirectoryRole> CreateAsync(DirectoryRole directoryRoleToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DirectoryRole using POST and returns a <see cref="GraphResponse{DirectoryRole}"/> object.
        /// </summary>
        /// <param name="directoryRoleToCreate">The DirectoryRole to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryRole}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryRole>> CreateResponseAsync(DirectoryRole directoryRoleToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DirectoryRole.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DirectoryRole and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DirectoryRole.
        /// </summary>
        /// <returns>The DirectoryRole.</returns>
        System.Threading.Tasks.Task<DirectoryRole> GetAsync();

        /// <summary>
        /// Gets the specified DirectoryRole.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectoryRole.</returns>
        System.Threading.Tasks.Task<DirectoryRole> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DirectoryRole and returns a <see cref="GraphResponse{DirectoryRole}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DirectoryRole}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryRole>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DirectoryRole and returns a <see cref="GraphResponse{DirectoryRole}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryRole}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryRole>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DirectoryRole using PATCH.
        /// </summary>
        /// <param name="directoryRoleToUpdate">The DirectoryRole to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DirectoryRole.</returns>
        System.Threading.Tasks.Task<DirectoryRole> UpdateAsync(DirectoryRole directoryRoleToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DirectoryRole using PATCH and returns a <see cref="GraphResponse{DirectoryRole}"/> object.
        /// </summary>
        /// <param name="directoryRoleToUpdate">The DirectoryRole to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DirectoryRole}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryRole>> UpdateResponseAsync(DirectoryRole directoryRoleToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleRequest Expand(Expression<Func<DirectoryRole, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryRoleRequest Select(Expression<Func<DirectoryRole, object>> selectExpression);

    }
}
