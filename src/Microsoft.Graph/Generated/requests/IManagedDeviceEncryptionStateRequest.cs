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
    /// The interface IManagedDeviceEncryptionStateRequest.
    /// </summary>
    public partial interface IManagedDeviceEncryptionStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedDeviceEncryptionState using POST.
        /// </summary>
        /// <param name="managedDeviceEncryptionStateToCreate">The ManagedDeviceEncryptionState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDeviceEncryptionState.</returns>
        System.Threading.Tasks.Task<ManagedDeviceEncryptionState> CreateAsync(ManagedDeviceEncryptionState managedDeviceEncryptionStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ManagedDeviceEncryptionState using POST and returns a <see cref="GraphResponse{ManagedDeviceEncryptionState}"/> object.
        /// </summary>
        /// <param name="managedDeviceEncryptionStateToCreate">The ManagedDeviceEncryptionState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceEncryptionState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceEncryptionState>> CreateResponseAsync(ManagedDeviceEncryptionState managedDeviceEncryptionStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedDeviceEncryptionState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedDeviceEncryptionState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ManagedDeviceEncryptionState.
        /// </summary>
        /// <returns>The ManagedDeviceEncryptionState.</returns>
        System.Threading.Tasks.Task<ManagedDeviceEncryptionState> GetAsync();

        /// <summary>
        /// Gets the specified ManagedDeviceEncryptionState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDeviceEncryptionState.</returns>
        System.Threading.Tasks.Task<ManagedDeviceEncryptionState> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedDeviceEncryptionState and returns a <see cref="GraphResponse{ManagedDeviceEncryptionState}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceEncryptionState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceEncryptionState>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ManagedDeviceEncryptionState and returns a <see cref="GraphResponse{ManagedDeviceEncryptionState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceEncryptionState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceEncryptionState>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedDeviceEncryptionState using PATCH.
        /// </summary>
        /// <param name="managedDeviceEncryptionStateToUpdate">The ManagedDeviceEncryptionState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDeviceEncryptionState.</returns>
        System.Threading.Tasks.Task<ManagedDeviceEncryptionState> UpdateAsync(ManagedDeviceEncryptionState managedDeviceEncryptionStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagedDeviceEncryptionState using PATCH and returns a <see cref="GraphResponse{ManagedDeviceEncryptionState}"/> object.
        /// </summary>
        /// <param name="managedDeviceEncryptionStateToUpdate">The ManagedDeviceEncryptionState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceEncryptionState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceEncryptionState>> UpdateResponseAsync(ManagedDeviceEncryptionState managedDeviceEncryptionStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceEncryptionStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceEncryptionStateRequest Expand(Expression<Func<ManagedDeviceEncryptionState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceEncryptionStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceEncryptionStateRequest Select(Expression<Func<ManagedDeviceEncryptionState, object>> selectExpression);

    }
}
