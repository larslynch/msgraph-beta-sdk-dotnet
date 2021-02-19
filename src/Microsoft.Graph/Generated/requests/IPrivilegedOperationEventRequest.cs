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
    /// The interface IPrivilegedOperationEventRequest.
    /// </summary>
    public partial interface IPrivilegedOperationEventRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrivilegedOperationEvent using POST.
        /// </summary>
        /// <param name="privilegedOperationEventToCreate">The PrivilegedOperationEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivilegedOperationEvent.</returns>
        System.Threading.Tasks.Task<PrivilegedOperationEvent> CreateAsync(PrivilegedOperationEvent privilegedOperationEventToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified PrivilegedOperationEvent using POST and returns a <see cref="GraphResponse{PrivilegedOperationEvent}"/> object.
        /// </summary>
        /// <param name="privilegedOperationEventToCreate">The PrivilegedOperationEvent to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrivilegedOperationEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrivilegedOperationEvent>> CreateResponseAsync(PrivilegedOperationEvent privilegedOperationEventToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PrivilegedOperationEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PrivilegedOperationEvent and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PrivilegedOperationEvent.
        /// </summary>
        /// <returns>The PrivilegedOperationEvent.</returns>
        System.Threading.Tasks.Task<PrivilegedOperationEvent> GetAsync();

        /// <summary>
        /// Gets the specified PrivilegedOperationEvent.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivilegedOperationEvent.</returns>
        System.Threading.Tasks.Task<PrivilegedOperationEvent> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrivilegedOperationEvent and returns a <see cref="GraphResponse{PrivilegedOperationEvent}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PrivilegedOperationEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrivilegedOperationEvent>> GetResponseAsync();

        /// <summary>
        /// Gets the specified PrivilegedOperationEvent and returns a <see cref="GraphResponse{PrivilegedOperationEvent}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrivilegedOperationEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrivilegedOperationEvent>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PrivilegedOperationEvent using PATCH.
        /// </summary>
        /// <param name="privilegedOperationEventToUpdate">The PrivilegedOperationEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrivilegedOperationEvent.</returns>
        System.Threading.Tasks.Task<PrivilegedOperationEvent> UpdateAsync(PrivilegedOperationEvent privilegedOperationEventToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PrivilegedOperationEvent using PATCH and returns a <see cref="GraphResponse{PrivilegedOperationEvent}"/> object.
        /// </summary>
        /// <param name="privilegedOperationEventToUpdate">The PrivilegedOperationEvent to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrivilegedOperationEvent}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrivilegedOperationEvent>> UpdateResponseAsync(PrivilegedOperationEvent privilegedOperationEventToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedOperationEventRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedOperationEventRequest Expand(Expression<Func<PrivilegedOperationEvent, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedOperationEventRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrivilegedOperationEventRequest Select(Expression<Func<PrivilegedOperationEvent, object>> selectExpression);

    }
}
