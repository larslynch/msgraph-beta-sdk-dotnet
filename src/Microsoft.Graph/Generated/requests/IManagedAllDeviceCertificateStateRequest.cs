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
    /// The interface IManagedAllDeviceCertificateStateRequest.
    /// </summary>
    public partial interface IManagedAllDeviceCertificateStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedAllDeviceCertificateState using POST.
        /// </summary>
        /// <param name="managedAllDeviceCertificateStateToCreate">The ManagedAllDeviceCertificateState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAllDeviceCertificateState.</returns>
        System.Threading.Tasks.Task<ManagedAllDeviceCertificateState> CreateAsync(ManagedAllDeviceCertificateState managedAllDeviceCertificateStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ManagedAllDeviceCertificateState using POST and returns a <see cref="GraphResponse{ManagedAllDeviceCertificateState}"/> object.
        /// </summary>
        /// <param name="managedAllDeviceCertificateStateToCreate">The ManagedAllDeviceCertificateState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAllDeviceCertificateState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAllDeviceCertificateState>> CreateResponseAsync(ManagedAllDeviceCertificateState managedAllDeviceCertificateStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedAllDeviceCertificateState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedAllDeviceCertificateState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ManagedAllDeviceCertificateState.
        /// </summary>
        /// <returns>The ManagedAllDeviceCertificateState.</returns>
        System.Threading.Tasks.Task<ManagedAllDeviceCertificateState> GetAsync();

        /// <summary>
        /// Gets the specified ManagedAllDeviceCertificateState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAllDeviceCertificateState.</returns>
        System.Threading.Tasks.Task<ManagedAllDeviceCertificateState> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedAllDeviceCertificateState and returns a <see cref="GraphResponse{ManagedAllDeviceCertificateState}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ManagedAllDeviceCertificateState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAllDeviceCertificateState>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ManagedAllDeviceCertificateState and returns a <see cref="GraphResponse{ManagedAllDeviceCertificateState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAllDeviceCertificateState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAllDeviceCertificateState>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedAllDeviceCertificateState using PATCH.
        /// </summary>
        /// <param name="managedAllDeviceCertificateStateToUpdate">The ManagedAllDeviceCertificateState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedAllDeviceCertificateState.</returns>
        System.Threading.Tasks.Task<ManagedAllDeviceCertificateState> UpdateAsync(ManagedAllDeviceCertificateState managedAllDeviceCertificateStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagedAllDeviceCertificateState using PATCH and returns a <see cref="GraphResponse{ManagedAllDeviceCertificateState}"/> object.
        /// </summary>
        /// <param name="managedAllDeviceCertificateStateToUpdate">The ManagedAllDeviceCertificateState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedAllDeviceCertificateState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAllDeviceCertificateState>> UpdateResponseAsync(ManagedAllDeviceCertificateState managedAllDeviceCertificateStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAllDeviceCertificateStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAllDeviceCertificateStateRequest Expand(Expression<Func<ManagedAllDeviceCertificateState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAllDeviceCertificateStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAllDeviceCertificateStateRequest Select(Expression<Func<ManagedAllDeviceCertificateState, object>> selectExpression);

    }
}
