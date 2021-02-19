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
    /// The interface IDepEnrollmentBaseProfileRequest.
    /// </summary>
    public partial interface IDepEnrollmentBaseProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DepEnrollmentBaseProfile using POST.
        /// </summary>
        /// <param name="depEnrollmentBaseProfileToCreate">The DepEnrollmentBaseProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DepEnrollmentBaseProfile.</returns>
        System.Threading.Tasks.Task<DepEnrollmentBaseProfile> CreateAsync(DepEnrollmentBaseProfile depEnrollmentBaseProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DepEnrollmentBaseProfile using POST and returns a <see cref="GraphResponse{DepEnrollmentBaseProfile}"/> object.
        /// </summary>
        /// <param name="depEnrollmentBaseProfileToCreate">The DepEnrollmentBaseProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DepEnrollmentBaseProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DepEnrollmentBaseProfile>> CreateResponseAsync(DepEnrollmentBaseProfile depEnrollmentBaseProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DepEnrollmentBaseProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DepEnrollmentBaseProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DepEnrollmentBaseProfile.
        /// </summary>
        /// <returns>The DepEnrollmentBaseProfile.</returns>
        System.Threading.Tasks.Task<DepEnrollmentBaseProfile> GetAsync();

        /// <summary>
        /// Gets the specified DepEnrollmentBaseProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DepEnrollmentBaseProfile.</returns>
        System.Threading.Tasks.Task<DepEnrollmentBaseProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DepEnrollmentBaseProfile and returns a <see cref="GraphResponse{DepEnrollmentBaseProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DepEnrollmentBaseProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DepEnrollmentBaseProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DepEnrollmentBaseProfile and returns a <see cref="GraphResponse{DepEnrollmentBaseProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DepEnrollmentBaseProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DepEnrollmentBaseProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DepEnrollmentBaseProfile using PATCH.
        /// </summary>
        /// <param name="depEnrollmentBaseProfileToUpdate">The DepEnrollmentBaseProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DepEnrollmentBaseProfile.</returns>
        System.Threading.Tasks.Task<DepEnrollmentBaseProfile> UpdateAsync(DepEnrollmentBaseProfile depEnrollmentBaseProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DepEnrollmentBaseProfile using PATCH and returns a <see cref="GraphResponse{DepEnrollmentBaseProfile}"/> object.
        /// </summary>
        /// <param name="depEnrollmentBaseProfileToUpdate">The DepEnrollmentBaseProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DepEnrollmentBaseProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DepEnrollmentBaseProfile>> UpdateResponseAsync(DepEnrollmentBaseProfile depEnrollmentBaseProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDepEnrollmentBaseProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDepEnrollmentBaseProfileRequest Expand(Expression<Func<DepEnrollmentBaseProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDepEnrollmentBaseProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDepEnrollmentBaseProfileRequest Select(Expression<Func<DepEnrollmentBaseProfile, object>> selectExpression);

    }
}
