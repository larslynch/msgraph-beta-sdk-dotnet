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
    /// The interface IUnsupportedDeviceConfigurationRequest.
    /// </summary>
    public partial interface IUnsupportedDeviceConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnsupportedDeviceConfiguration using POST.
        /// </summary>
        /// <param name="unsupportedDeviceConfigurationToCreate">The UnsupportedDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnsupportedDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<UnsupportedDeviceConfiguration> CreateAsync(UnsupportedDeviceConfiguration unsupportedDeviceConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UnsupportedDeviceConfiguration using POST and returns a <see cref="GraphResponse{UnsupportedDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="unsupportedDeviceConfigurationToCreate">The UnsupportedDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnsupportedDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnsupportedDeviceConfiguration>> CreateResponseAsync(UnsupportedDeviceConfiguration unsupportedDeviceConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnsupportedDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnsupportedDeviceConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnsupportedDeviceConfiguration.
        /// </summary>
        /// <returns>The UnsupportedDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<UnsupportedDeviceConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified UnsupportedDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnsupportedDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<UnsupportedDeviceConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnsupportedDeviceConfiguration and returns a <see cref="GraphResponse{UnsupportedDeviceConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UnsupportedDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnsupportedDeviceConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UnsupportedDeviceConfiguration and returns a <see cref="GraphResponse{UnsupportedDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnsupportedDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnsupportedDeviceConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnsupportedDeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="unsupportedDeviceConfigurationToUpdate">The UnsupportedDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnsupportedDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<UnsupportedDeviceConfiguration> UpdateAsync(UnsupportedDeviceConfiguration unsupportedDeviceConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnsupportedDeviceConfiguration using PATCH and returns a <see cref="GraphResponse{UnsupportedDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="unsupportedDeviceConfigurationToUpdate">The UnsupportedDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnsupportedDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnsupportedDeviceConfiguration>> UpdateResponseAsync(UnsupportedDeviceConfiguration unsupportedDeviceConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnsupportedDeviceConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnsupportedDeviceConfigurationRequest Expand(Expression<Func<UnsupportedDeviceConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnsupportedDeviceConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnsupportedDeviceConfigurationRequest Select(Expression<Func<UnsupportedDeviceConfiguration, object>> selectExpression);

    }
}
