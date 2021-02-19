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
    /// The interface IDeviceShellScriptRequest.
    /// </summary>
    public partial interface IDeviceShellScriptRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceShellScript using POST.
        /// </summary>
        /// <param name="deviceShellScriptToCreate">The DeviceShellScript to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceShellScript.</returns>
        System.Threading.Tasks.Task<DeviceShellScript> CreateAsync(DeviceShellScript deviceShellScriptToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceShellScript using POST and returns a <see cref="GraphResponse{DeviceShellScript}"/> object.
        /// </summary>
        /// <param name="deviceShellScriptToCreate">The DeviceShellScript to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceShellScript}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceShellScript>> CreateResponseAsync(DeviceShellScript deviceShellScriptToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceShellScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceShellScript and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceShellScript.
        /// </summary>
        /// <returns>The DeviceShellScript.</returns>
        System.Threading.Tasks.Task<DeviceShellScript> GetAsync();

        /// <summary>
        /// Gets the specified DeviceShellScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceShellScript.</returns>
        System.Threading.Tasks.Task<DeviceShellScript> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceShellScript and returns a <see cref="GraphResponse{DeviceShellScript}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceShellScript}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceShellScript>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceShellScript and returns a <see cref="GraphResponse{DeviceShellScript}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceShellScript}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceShellScript>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceShellScript using PATCH.
        /// </summary>
        /// <param name="deviceShellScriptToUpdate">The DeviceShellScript to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceShellScript.</returns>
        System.Threading.Tasks.Task<DeviceShellScript> UpdateAsync(DeviceShellScript deviceShellScriptToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceShellScript using PATCH and returns a <see cref="GraphResponse{DeviceShellScript}"/> object.
        /// </summary>
        /// <param name="deviceShellScriptToUpdate">The DeviceShellScript to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceShellScript}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceShellScript>> UpdateResponseAsync(DeviceShellScript deviceShellScriptToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceShellScriptRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceShellScriptRequest Expand(Expression<Func<DeviceShellScript, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceShellScriptRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceShellScriptRequest Select(Expression<Func<DeviceShellScript, object>> selectExpression);

    }
}
