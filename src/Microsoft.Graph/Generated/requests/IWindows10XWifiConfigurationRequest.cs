// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindows10XWifiConfigurationRequest.
    /// </summary>
    public partial interface IWindows10XWifiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows10XWifiConfiguration using POST.
        /// </summary>
        /// <param name="windows10XWifiConfigurationToCreate">The Windows10XWifiConfiguration to create.</param>
        /// <returns>The created Windows10XWifiConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10XWifiConfiguration> CreateAsync(Windows10XWifiConfiguration windows10XWifiConfigurationToCreate);        /// <summary>
        /// Creates the specified Windows10XWifiConfiguration using POST.
        /// </summary>
        /// <param name="windows10XWifiConfigurationToCreate">The Windows10XWifiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10XWifiConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10XWifiConfiguration> CreateAsync(Windows10XWifiConfiguration windows10XWifiConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows10XWifiConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows10XWifiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows10XWifiConfiguration.
        /// </summary>
        /// <returns>The Windows10XWifiConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10XWifiConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified Windows10XWifiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10XWifiConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10XWifiConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows10XWifiConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10XWifiConfigurationToUpdate">The Windows10XWifiConfiguration to update.</param>
        /// <returns>The updated Windows10XWifiConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10XWifiConfiguration> UpdateAsync(Windows10XWifiConfiguration windows10XWifiConfigurationToUpdate);

        /// <summary>
        /// Updates the specified Windows10XWifiConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10XWifiConfigurationToUpdate">The Windows10XWifiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10XWifiConfiguration.</returns>
        System.Threading.Tasks.Task<Windows10XWifiConfiguration> UpdateAsync(Windows10XWifiConfiguration windows10XWifiConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10XWifiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10XWifiConfigurationRequest Expand(Expression<Func<Windows10XWifiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10XWifiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows10XWifiConfigurationRequest Select(Expression<Func<Windows10XWifiConfiguration, object>> selectExpression);

    }
}
