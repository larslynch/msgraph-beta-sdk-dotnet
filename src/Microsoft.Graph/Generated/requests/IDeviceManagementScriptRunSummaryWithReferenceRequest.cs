// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceManagementScriptRunSummaryWithReferenceRequest.
    /// </summary>
    public partial interface IDeviceManagementScriptRunSummaryWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified DeviceManagementScriptRunSummary.
        /// </summary>
        /// <returns>The DeviceManagementScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptRunSummary> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementScriptRunSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptRunSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementScriptRunSummary and returns a <see cref="GraphResponse{DeviceManagementScriptRunSummary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptRunSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptRunSummary>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceManagementScriptRunSummary and returns a <see cref="GraphResponse{DeviceManagementScriptRunSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptRunSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptRunSummary>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified DeviceManagementScriptRunSummary using POST.
        /// </summary>
        /// <param name="deviceManagementScriptRunSummaryToCreate">The DeviceManagementScriptRunSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptRunSummary> CreateAsync(DeviceManagementScriptRunSummary deviceManagementScriptRunSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified DeviceManagementScriptRunSummary using POST and returns a <see cref="GraphResponse{DeviceManagementScriptRunSummary}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptRunSummaryToCreate">The DeviceManagementScriptRunSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptRunSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptRunSummary>> CreateResponseAsync(DeviceManagementScriptRunSummary deviceManagementScriptRunSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified DeviceManagementScriptRunSummary using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptRunSummaryToUpdate">The DeviceManagementScriptRunSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementScriptRunSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptRunSummary> UpdateAsync(DeviceManagementScriptRunSummary deviceManagementScriptRunSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified DeviceManagementScriptRunSummary using PATCH and returns a <see cref="GraphResponse{DeviceManagementScriptRunSummary}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptRunSummaryToUpdate">The DeviceManagementScriptRunSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptRunSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptRunSummary>> UpdateResponseAsync(DeviceManagementScriptRunSummary deviceManagementScriptRunSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified DeviceManagementScriptRunSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified DeviceManagementScriptRunSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRunSummaryWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRunSummaryWithReferenceRequest Expand(Expression<Func<DeviceManagementScriptRunSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRunSummaryWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptRunSummaryWithReferenceRequest Select(Expression<Func<DeviceManagementScriptRunSummary, object>> selectExpression);

    }
}
