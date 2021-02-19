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
    /// The interface IDeviceCompliancePolicyPolicySetItemRequest.
    /// </summary>
    public partial interface IDeviceCompliancePolicyPolicySetItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceCompliancePolicyPolicySetItem using POST.
        /// </summary>
        /// <param name="deviceCompliancePolicyPolicySetItemToCreate">The DeviceCompliancePolicyPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCompliancePolicyPolicySetItem.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyPolicySetItem> CreateAsync(DeviceCompliancePolicyPolicySetItem deviceCompliancePolicyPolicySetItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceCompliancePolicyPolicySetItem using POST and returns a <see cref="GraphResponse{DeviceCompliancePolicyPolicySetItem}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyPolicySetItemToCreate">The DeviceCompliancePolicyPolicySetItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicyPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicyPolicySetItem>> CreateResponseAsync(DeviceCompliancePolicyPolicySetItem deviceCompliancePolicyPolicySetItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicyPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicyPolicySetItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceCompliancePolicyPolicySetItem.
        /// </summary>
        /// <returns>The DeviceCompliancePolicyPolicySetItem.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyPolicySetItem> GetAsync();

        /// <summary>
        /// Gets the specified DeviceCompliancePolicyPolicySetItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceCompliancePolicyPolicySetItem.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyPolicySetItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceCompliancePolicyPolicySetItem and returns a <see cref="GraphResponse{DeviceCompliancePolicyPolicySetItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicyPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicyPolicySetItem>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DeviceCompliancePolicyPolicySetItem and returns a <see cref="GraphResponse{DeviceCompliancePolicyPolicySetItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicyPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicyPolicySetItem>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicyPolicySetItem using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyPolicySetItemToUpdate">The DeviceCompliancePolicyPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceCompliancePolicyPolicySetItem.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyPolicySetItem> UpdateAsync(DeviceCompliancePolicyPolicySetItem deviceCompliancePolicyPolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceCompliancePolicyPolicySetItem using PATCH and returns a <see cref="GraphResponse{DeviceCompliancePolicyPolicySetItem}"/> object.
        /// </summary>
        /// <param name="deviceCompliancePolicyPolicySetItemToUpdate">The DeviceCompliancePolicyPolicySetItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceCompliancePolicyPolicySetItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicyPolicySetItem>> UpdateResponseAsync(DeviceCompliancePolicyPolicySetItem deviceCompliancePolicyPolicySetItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyPolicySetItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyPolicySetItemRequest Expand(Expression<Func<DeviceCompliancePolicyPolicySetItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyPolicySetItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyPolicySetItemRequest Select(Expression<Func<DeviceCompliancePolicyPolicySetItem, object>> selectExpression);

    }
}
