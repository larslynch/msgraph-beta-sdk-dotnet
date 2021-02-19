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
    /// The interface IDeviceManagementIntentUserStateSummaryRequest.
    /// </summary>
    public partial interface IDeviceManagementIntentUserStateSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementIntentUserStateSummary using POST.
        /// </summary>
        /// <param name="deviceManagementIntentUserStateSummaryToCreate">The DeviceManagementIntentUserStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementIntentUserStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentUserStateSummary> CreateAsync(DeviceManagementIntentUserStateSummary deviceManagementIntentUserStateSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceManagementIntentUserStateSummary using POST and returns a <see cref="GraphResponse{DeviceManagementIntentUserStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentUserStateSummaryToCreate">The DeviceManagementIntentUserStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentUserStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentUserStateSummary>> CreateResponseAsync(DeviceManagementIntentUserStateSummary deviceManagementIntentUserStateSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementIntentUserStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementIntentUserStateSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementIntentUserStateSummary.
        /// </summary>
        /// <returns>The DeviceManagementIntentUserStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentUserStateSummary> GetAsync();

        /// <summary>
        /// Gets the specified DeviceManagementIntentUserStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementIntentUserStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentUserStateSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceManagementIntentUserStateSummary and returns a <see cref="GraphResponse{DeviceManagementIntentUserStateSummary}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentUserStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentUserStateSummary>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceManagementIntentUserStateSummary and returns a <see cref="GraphResponse{DeviceManagementIntentUserStateSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentUserStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentUserStateSummary>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceManagementIntentUserStateSummary using PATCH.
        /// </summary>
        /// <param name="deviceManagementIntentUserStateSummaryToUpdate">The DeviceManagementIntentUserStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementIntentUserStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceManagementIntentUserStateSummary> UpdateAsync(DeviceManagementIntentUserStateSummary deviceManagementIntentUserStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementIntentUserStateSummary using PATCH and returns a <see cref="GraphResponse{DeviceManagementIntentUserStateSummary}"/> object.
        /// </summary>
        /// <param name="deviceManagementIntentUserStateSummaryToUpdate">The DeviceManagementIntentUserStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementIntentUserStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementIntentUserStateSummary>> UpdateResponseAsync(DeviceManagementIntentUserStateSummary deviceManagementIntentUserStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentUserStateSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentUserStateSummaryRequest Expand(Expression<Func<DeviceManagementIntentUserStateSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentUserStateSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementIntentUserStateSummaryRequest Select(Expression<Func<DeviceManagementIntentUserStateSummary, object>> selectExpression);

    }
}
