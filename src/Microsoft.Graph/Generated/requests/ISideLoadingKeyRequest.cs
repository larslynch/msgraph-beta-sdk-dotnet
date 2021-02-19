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
    /// The interface ISideLoadingKeyRequest.
    /// </summary>
    public partial interface ISideLoadingKeyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SideLoadingKey using POST.
        /// </summary>
        /// <param name="sideLoadingKeyToCreate">The SideLoadingKey to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SideLoadingKey.</returns>
        System.Threading.Tasks.Task<SideLoadingKey> CreateAsync(SideLoadingKey sideLoadingKeyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SideLoadingKey using POST and returns a <see cref="GraphResponse{SideLoadingKey}"/> object.
        /// </summary>
        /// <param name="sideLoadingKeyToCreate">The SideLoadingKey to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> CreateResponseAsync(SideLoadingKey sideLoadingKeyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SideLoadingKey.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SideLoadingKey and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SideLoadingKey.
        /// </summary>
        /// <returns>The SideLoadingKey.</returns>
        System.Threading.Tasks.Task<SideLoadingKey> GetAsync();

        /// <summary>
        /// Gets the specified SideLoadingKey.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SideLoadingKey.</returns>
        System.Threading.Tasks.Task<SideLoadingKey> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SideLoadingKey and returns a <see cref="GraphResponse{SideLoadingKey}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SideLoadingKey and returns a <see cref="GraphResponse{SideLoadingKey}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SideLoadingKey using PATCH.
        /// </summary>
        /// <param name="sideLoadingKeyToUpdate">The SideLoadingKey to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SideLoadingKey.</returns>
        System.Threading.Tasks.Task<SideLoadingKey> UpdateAsync(SideLoadingKey sideLoadingKeyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SideLoadingKey using PATCH and returns a <see cref="GraphResponse{SideLoadingKey}"/> object.
        /// </summary>
        /// <param name="sideLoadingKeyToUpdate">The SideLoadingKey to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SideLoadingKey}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SideLoadingKey>> UpdateResponseAsync(SideLoadingKey sideLoadingKeyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISideLoadingKeyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISideLoadingKeyRequest Expand(Expression<Func<SideLoadingKey, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISideLoadingKeyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISideLoadingKeyRequest Select(Expression<Func<SideLoadingKey, object>> selectExpression);

    }
}
