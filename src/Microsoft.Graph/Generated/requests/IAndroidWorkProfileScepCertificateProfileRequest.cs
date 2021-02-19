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
    /// The interface IAndroidWorkProfileScepCertificateProfileRequest.
    /// </summary>
    public partial interface IAndroidWorkProfileScepCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidWorkProfileScepCertificateProfile using POST.
        /// </summary>
        /// <param name="androidWorkProfileScepCertificateProfileToCreate">The AndroidWorkProfileScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidWorkProfileScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileScepCertificateProfile> CreateAsync(AndroidWorkProfileScepCertificateProfile androidWorkProfileScepCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidWorkProfileScepCertificateProfile using POST and returns a <see cref="GraphResponse{AndroidWorkProfileScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileScepCertificateProfileToCreate">The AndroidWorkProfileScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileScepCertificateProfile>> CreateResponseAsync(AndroidWorkProfileScepCertificateProfile androidWorkProfileScepCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidWorkProfileScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidWorkProfileScepCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidWorkProfileScepCertificateProfile.
        /// </summary>
        /// <returns>The AndroidWorkProfileScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileScepCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified AndroidWorkProfileScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidWorkProfileScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileScepCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidWorkProfileScepCertificateProfile and returns a <see cref="GraphResponse{AndroidWorkProfileScepCertificateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileScepCertificateProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AndroidWorkProfileScepCertificateProfile and returns a <see cref="GraphResponse{AndroidWorkProfileScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileScepCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidWorkProfileScepCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidWorkProfileScepCertificateProfileToUpdate">The AndroidWorkProfileScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidWorkProfileScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidWorkProfileScepCertificateProfile> UpdateAsync(AndroidWorkProfileScepCertificateProfile androidWorkProfileScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidWorkProfileScepCertificateProfile using PATCH and returns a <see cref="GraphResponse{AndroidWorkProfileScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidWorkProfileScepCertificateProfileToUpdate">The AndroidWorkProfileScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidWorkProfileScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidWorkProfileScepCertificateProfile>> UpdateResponseAsync(AndroidWorkProfileScepCertificateProfile androidWorkProfileScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileScepCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileScepCertificateProfileRequest Expand(Expression<Func<AndroidWorkProfileScepCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileScepCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidWorkProfileScepCertificateProfileRequest Select(Expression<Func<AndroidWorkProfileScepCertificateProfile, object>> selectExpression);

    }
}
