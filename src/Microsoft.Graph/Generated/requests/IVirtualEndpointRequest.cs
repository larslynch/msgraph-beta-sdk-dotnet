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
    /// The interface IVirtualEndpointRequest.
    /// </summary>
    public partial interface IVirtualEndpointRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified VirtualEndpoint using POST.
        /// </summary>
        /// <param name="virtualEndpointToCreate">The VirtualEndpoint to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created VirtualEndpoint.</returns>
        System.Threading.Tasks.Task<VirtualEndpoint> CreateAsync(VirtualEndpoint virtualEndpointToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified VirtualEndpoint using POST and returns a <see cref="GraphResponse{VirtualEndpoint}"/> object.
        /// </summary>
        /// <param name="virtualEndpointToCreate">The VirtualEndpoint to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{VirtualEndpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VirtualEndpoint>> CreateResponseAsync(VirtualEndpoint virtualEndpointToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified VirtualEndpoint.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified VirtualEndpoint and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified VirtualEndpoint.
        /// </summary>
        /// <returns>The VirtualEndpoint.</returns>
        System.Threading.Tasks.Task<VirtualEndpoint> GetAsync();

        /// <summary>
        /// Gets the specified VirtualEndpoint.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The VirtualEndpoint.</returns>
        System.Threading.Tasks.Task<VirtualEndpoint> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified VirtualEndpoint and returns a <see cref="GraphResponse{VirtualEndpoint}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{VirtualEndpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VirtualEndpoint>> GetResponseAsync();

        /// <summary>
        /// Gets the specified VirtualEndpoint and returns a <see cref="GraphResponse{VirtualEndpoint}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{VirtualEndpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VirtualEndpoint>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified VirtualEndpoint using PATCH.
        /// </summary>
        /// <param name="virtualEndpointToUpdate">The VirtualEndpoint to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated VirtualEndpoint.</returns>
        System.Threading.Tasks.Task<VirtualEndpoint> UpdateAsync(VirtualEndpoint virtualEndpointToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified VirtualEndpoint using PATCH and returns a <see cref="GraphResponse{VirtualEndpoint}"/> object.
        /// </summary>
        /// <param name="virtualEndpointToUpdate">The VirtualEndpoint to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{VirtualEndpoint}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<VirtualEndpoint>> UpdateResponseAsync(VirtualEndpoint virtualEndpointToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointRequest Expand(Expression<Func<VirtualEndpoint, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IVirtualEndpointRequest Select(Expression<Func<VirtualEndpoint, object>> selectExpression);

    }
}
