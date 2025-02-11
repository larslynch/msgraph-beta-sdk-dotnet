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
    /// The interface IMobileAppInstallSummaryRequest.
    /// </summary>
    public partial interface IMobileAppInstallSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MobileAppInstallSummary using POST.
        /// </summary>
        /// <param name="mobileAppInstallSummaryToCreate">The MobileAppInstallSummary to create.</param>
        /// <returns>The created MobileAppInstallSummary.</returns>
        System.Threading.Tasks.Task<MobileAppInstallSummary> CreateAsync(MobileAppInstallSummary mobileAppInstallSummaryToCreate);        /// <summary>
        /// Creates the specified MobileAppInstallSummary using POST.
        /// </summary>
        /// <param name="mobileAppInstallSummaryToCreate">The MobileAppInstallSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppInstallSummary.</returns>
        System.Threading.Tasks.Task<MobileAppInstallSummary> CreateAsync(MobileAppInstallSummary mobileAppInstallSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MobileAppInstallSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MobileAppInstallSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MobileAppInstallSummary.
        /// </summary>
        /// <returns>The MobileAppInstallSummary.</returns>
        System.Threading.Tasks.Task<MobileAppInstallSummary> GetAsync();

        /// <summary>
        /// Gets the specified MobileAppInstallSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppInstallSummary.</returns>
        System.Threading.Tasks.Task<MobileAppInstallSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MobileAppInstallSummary using PATCH.
        /// </summary>
        /// <param name="mobileAppInstallSummaryToUpdate">The MobileAppInstallSummary to update.</param>
        /// <returns>The updated MobileAppInstallSummary.</returns>
        System.Threading.Tasks.Task<MobileAppInstallSummary> UpdateAsync(MobileAppInstallSummary mobileAppInstallSummaryToUpdate);

        /// <summary>
        /// Updates the specified MobileAppInstallSummary using PATCH.
        /// </summary>
        /// <param name="mobileAppInstallSummaryToUpdate">The MobileAppInstallSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppInstallSummary.</returns>
        System.Threading.Tasks.Task<MobileAppInstallSummary> UpdateAsync(MobileAppInstallSummary mobileAppInstallSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppInstallSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppInstallSummaryRequest Expand(Expression<Func<MobileAppInstallSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppInstallSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppInstallSummaryRequest Select(Expression<Func<MobileAppInstallSummary, object>> selectExpression);

    }
}
