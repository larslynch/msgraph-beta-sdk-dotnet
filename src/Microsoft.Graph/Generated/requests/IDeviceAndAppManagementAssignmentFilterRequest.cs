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
    /// The interface IDeviceAndAppManagementAssignmentFilterRequest.
    /// </summary>
    public partial interface IDeviceAndAppManagementAssignmentFilterRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceAndAppManagementAssignmentFilter using POST.
        /// </summary>
        /// <param name="deviceAndAppManagementAssignmentFilterToCreate">The DeviceAndAppManagementAssignmentFilter to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceAndAppManagementAssignmentFilter.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementAssignmentFilter> CreateAsync(DeviceAndAppManagementAssignmentFilter deviceAndAppManagementAssignmentFilterToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceAndAppManagementAssignmentFilter using POST and returns a <see cref="GraphResponse{DeviceAndAppManagementAssignmentFilter}"/> object.
        /// </summary>
        /// <param name="deviceAndAppManagementAssignmentFilterToCreate">The DeviceAndAppManagementAssignmentFilter to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAndAppManagementAssignmentFilter}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAndAppManagementAssignmentFilter>> CreateResponseAsync(DeviceAndAppManagementAssignmentFilter deviceAndAppManagementAssignmentFilterToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceAndAppManagementAssignmentFilter.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceAndAppManagementAssignmentFilter and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceAndAppManagementAssignmentFilter.
        /// </summary>
        /// <returns>The DeviceAndAppManagementAssignmentFilter.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementAssignmentFilter> GetAsync();

        /// <summary>
        /// Gets the specified DeviceAndAppManagementAssignmentFilter.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceAndAppManagementAssignmentFilter.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementAssignmentFilter> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceAndAppManagementAssignmentFilter and returns a <see cref="GraphResponse{DeviceAndAppManagementAssignmentFilter}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceAndAppManagementAssignmentFilter}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAndAppManagementAssignmentFilter>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceAndAppManagementAssignmentFilter and returns a <see cref="GraphResponse{DeviceAndAppManagementAssignmentFilter}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceAndAppManagementAssignmentFilter}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAndAppManagementAssignmentFilter>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceAndAppManagementAssignmentFilter using PATCH.
        /// </summary>
        /// <param name="deviceAndAppManagementAssignmentFilterToUpdate">The DeviceAndAppManagementAssignmentFilter to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceAndAppManagementAssignmentFilter.</returns>
        System.Threading.Tasks.Task<DeviceAndAppManagementAssignmentFilter> UpdateAsync(DeviceAndAppManagementAssignmentFilter deviceAndAppManagementAssignmentFilterToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceAndAppManagementAssignmentFilter using PATCH and returns a <see cref="GraphResponse{DeviceAndAppManagementAssignmentFilter}"/> object.
        /// </summary>
        /// <param name="deviceAndAppManagementAssignmentFilterToUpdate">The DeviceAndAppManagementAssignmentFilter to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceAndAppManagementAssignmentFilter}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceAndAppManagementAssignmentFilter>> UpdateResponseAsync(DeviceAndAppManagementAssignmentFilter deviceAndAppManagementAssignmentFilterToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAndAppManagementAssignmentFilterRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAndAppManagementAssignmentFilterRequest Expand(Expression<Func<DeviceAndAppManagementAssignmentFilter, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAndAppManagementAssignmentFilterRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceAndAppManagementAssignmentFilterRequest Select(Expression<Func<DeviceAndAppManagementAssignmentFilter, object>> selectExpression);

    }
}
