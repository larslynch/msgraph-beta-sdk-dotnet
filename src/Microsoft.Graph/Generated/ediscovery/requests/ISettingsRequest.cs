// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISettingsRequest.
    /// </summary>
    public partial interface ISettingsRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified Settings using POST.
        /// </summary>
        /// <param name="settingsToCreate">The Settings to create.</param>
        /// <returns>The created Settings.</returns>
        System.Threading.Tasks.Task<Settings> CreateAsync(Settings settingsToCreate);        /// <summary>
        /// Creates the specified Settings using POST.
        /// </summary>
        /// <param name="settingsToCreate">The Settings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Settings.</returns>
        System.Threading.Tasks.Task<Settings> CreateAsync(Settings settingsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Settings.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Settings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Settings.
        /// </summary>
        /// <returns>The Settings.</returns>
        System.Threading.Tasks.Task<Settings> GetAsync();

        /// <summary>
        /// Gets the specified Settings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Settings.</returns>
        System.Threading.Tasks.Task<Settings> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Settings using PATCH.
        /// </summary>
        /// <param name="settingsToUpdate">The Settings to update.</param>
        /// <returns>The updated Settings.</returns>
        System.Threading.Tasks.Task<Settings> UpdateAsync(Settings settingsToUpdate);

        /// <summary>
        /// Updates the specified Settings using PATCH.
        /// </summary>
        /// <param name="settingsToUpdate">The Settings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Settings.</returns>
        System.Threading.Tasks.Task<Settings> UpdateAsync(Settings settingsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISettingsRequest Expand(Expression<Func<Settings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISettingsRequest Select(Expression<Func<Settings, object>> selectExpression);

    }
}
