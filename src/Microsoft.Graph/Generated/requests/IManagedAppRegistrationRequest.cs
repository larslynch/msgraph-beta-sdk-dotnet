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
    /// The interface IManagedAppRegistrationRequest.
    /// </summary>
    public partial interface IManagedAppRegistrationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedAppRegistration using POST.
        /// </summary>
        /// <param name="managedAppRegistrationToCreate">The ManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<ManagedAppRegistration> CreateAsync(ManagedAppRegistration managedAppRegistrationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ManagedAppRegistration using POST and returns a <see cref="GraphResponse{ManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="managedAppRegistrationToCreate">The ManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAppRegistration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppRegistration>> CreateResponseAsync(ManagedAppRegistration managedAppRegistrationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedAppRegistration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ManagedAppRegistration.
        /// </summary>
        /// <returns>The ManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<ManagedAppRegistration> GetAsync();

        /// <summary>
        /// Gets the specified ManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<ManagedAppRegistration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ManagedAppRegistration and returns a <see cref="GraphResponse{ManagedAppRegistration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ManagedAppRegistration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppRegistration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ManagedAppRegistration and returns a <see cref="GraphResponse{ManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedAppRegistration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppRegistration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<ManagedAppRegistration> UpdateAsync(ManagedAppRegistration managedAppRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagedAppRegistration using PATCH and returns a <see cref="GraphResponse{ManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="managedAppRegistrationToUpdate">The ManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedAppRegistration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedAppRegistration>> UpdateResponseAsync(ManagedAppRegistration managedAppRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRegistrationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRegistrationRequest Expand(Expression<Func<ManagedAppRegistration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRegistrationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedAppRegistrationRequest Select(Expression<Func<ManagedAppRegistration, object>> selectExpression);

    }
}
