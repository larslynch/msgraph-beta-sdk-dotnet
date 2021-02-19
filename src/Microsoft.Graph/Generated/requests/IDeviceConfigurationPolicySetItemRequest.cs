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
    /// The interface IDeviceConfigurationPolicySetItemRequest.
    /// </summary>
    public partial interface IDeviceConfigurationPolicySetItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceConfigurationPolicySetItem using POST.
        /// </summary>
        /// <param name="deviceConfigurationPolicySetItemToCreate">The DeviceConfigurationPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationPolicySetItem> CreateAsync(DeviceConfigurationPolicySetItem deviceConfigurationPolicySetItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceConfigurationPolicySetItem using POST and returns a <see cref="GraphResponse{DeviceConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationPolicySetItemToCreate">The DeviceConfigurationPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationPolicySetItem>> CreateResponseAsync(DeviceConfigurationPolicySetItem deviceConfigurationPolicySetItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceConfigurationPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceConfigurationPolicySetItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceConfigurationPolicySetItem.
        /// </summary>
        /// <returns>The DeviceConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationPolicySetItem> GetAsync();

        /// <summary>
        /// Gets the specified DeviceConfigurationPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationPolicySetItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceConfigurationPolicySetItem and returns a <see cref="GraphResponse{DeviceConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationPolicySetItem>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceConfigurationPolicySetItem and returns a <see cref="GraphResponse{DeviceConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationPolicySetItem>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceConfigurationPolicySetItem using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationPolicySetItemToUpdate">The DeviceConfigurationPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceConfigurationPolicySetItem.</returns>
        System.Threading.Tasks.Task<DeviceConfigurationPolicySetItem> UpdateAsync(DeviceConfigurationPolicySetItem deviceConfigurationPolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceConfigurationPolicySetItem using PATCH and returns a <see cref="GraphResponse{DeviceConfigurationPolicySetItem}"/> object.
        /// </summary>
        /// <param name="deviceConfigurationPolicySetItemToUpdate">The DeviceConfigurationPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceConfigurationPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceConfigurationPolicySetItem>> UpdateResponseAsync(DeviceConfigurationPolicySetItem deviceConfigurationPolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationPolicySetItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationPolicySetItemRequest Expand(Expression<Func<DeviceConfigurationPolicySetItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationPolicySetItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceConfigurationPolicySetItemRequest Select(Expression<Func<DeviceConfigurationPolicySetItem, object>> selectExpression);

    }
}
