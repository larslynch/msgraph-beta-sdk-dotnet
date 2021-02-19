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
    /// The interface IAndroidForWorkGeneralDeviceConfigurationRequest.
    /// </summary>
    public partial interface IAndroidForWorkGeneralDeviceConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidForWorkGeneralDeviceConfiguration using POST.
        /// </summary>
        /// <param name="androidForWorkGeneralDeviceConfigurationToCreate">The AndroidForWorkGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkGeneralDeviceConfiguration> CreateAsync(AndroidForWorkGeneralDeviceConfiguration androidForWorkGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidForWorkGeneralDeviceConfiguration using POST and returns a <see cref="GraphResponse{AndroidForWorkGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="androidForWorkGeneralDeviceConfigurationToCreate">The AndroidForWorkGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkGeneralDeviceConfiguration>> CreateResponseAsync(AndroidForWorkGeneralDeviceConfiguration androidForWorkGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidForWorkGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidForWorkGeneralDeviceConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidForWorkGeneralDeviceConfiguration.
        /// </summary>
        /// <returns>The AndroidForWorkGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkGeneralDeviceConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified AndroidForWorkGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkGeneralDeviceConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidForWorkGeneralDeviceConfiguration and returns a <see cref="GraphResponse{AndroidForWorkGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkGeneralDeviceConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AndroidForWorkGeneralDeviceConfiguration and returns a <see cref="GraphResponse{AndroidForWorkGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkGeneralDeviceConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidForWorkGeneralDeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="androidForWorkGeneralDeviceConfigurationToUpdate">The AndroidForWorkGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidForWorkGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<AndroidForWorkGeneralDeviceConfiguration> UpdateAsync(AndroidForWorkGeneralDeviceConfiguration androidForWorkGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidForWorkGeneralDeviceConfiguration using PATCH and returns a <see cref="GraphResponse{AndroidForWorkGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="androidForWorkGeneralDeviceConfigurationToUpdate">The AndroidForWorkGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkGeneralDeviceConfiguration>> UpdateResponseAsync(AndroidForWorkGeneralDeviceConfiguration androidForWorkGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkGeneralDeviceConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkGeneralDeviceConfigurationRequest Expand(Expression<Func<AndroidForWorkGeneralDeviceConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkGeneralDeviceConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkGeneralDeviceConfigurationRequest Select(Expression<Func<AndroidForWorkGeneralDeviceConfiguration, object>> selectExpression);

    }
}
