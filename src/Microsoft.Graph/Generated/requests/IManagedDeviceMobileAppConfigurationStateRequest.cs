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
    /// The interface IManagedDeviceMobileAppConfigurationStateRequest.
    /// </summary>
    public partial interface IManagedDeviceMobileAppConfigurationStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationState using POST.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationStateToCreate">The ManagedDeviceMobileAppConfigurationState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDeviceMobileAppConfigurationState.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationState> CreateAsync(ManagedDeviceMobileAppConfigurationState managedDeviceMobileAppConfigurationStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationState using POST and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationState}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationStateToCreate">The ManagedDeviceMobileAppConfigurationState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationState>> CreateResponseAsync(ManagedDeviceMobileAppConfigurationState managedDeviceMobileAppConfigurationStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationState.
        /// </summary>
        /// <returns>The ManagedDeviceMobileAppConfigurationState.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationState> GetAsync();

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDeviceMobileAppConfigurationState.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationState> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationState and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationState}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationState>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationState and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationState>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationState using PATCH.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationStateToUpdate">The ManagedDeviceMobileAppConfigurationState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDeviceMobileAppConfigurationState.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationState> UpdateAsync(ManagedDeviceMobileAppConfigurationState managedDeviceMobileAppConfigurationStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationState using PATCH and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationState}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationStateToUpdate">The ManagedDeviceMobileAppConfigurationState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationState>> UpdateResponseAsync(ManagedDeviceMobileAppConfigurationState managedDeviceMobileAppConfigurationStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationStateRequest Expand(Expression<Func<ManagedDeviceMobileAppConfigurationState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationStateRequest Select(Expression<Func<ManagedDeviceMobileAppConfigurationState, object>> selectExpression);

    }
}
