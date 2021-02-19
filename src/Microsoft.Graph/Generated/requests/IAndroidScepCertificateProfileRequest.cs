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
    /// The interface IAndroidScepCertificateProfileRequest.
    /// </summary>
    public partial interface IAndroidScepCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidScepCertificateProfile using POST.
        /// </summary>
        /// <param name="androidScepCertificateProfileToCreate">The AndroidScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidScepCertificateProfile> CreateAsync(AndroidScepCertificateProfile androidScepCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidScepCertificateProfile using POST and returns a <see cref="GraphResponse{AndroidScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidScepCertificateProfileToCreate">The AndroidScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidScepCertificateProfile>> CreateResponseAsync(AndroidScepCertificateProfile androidScepCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidScepCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidScepCertificateProfile.
        /// </summary>
        /// <returns>The AndroidScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidScepCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified AndroidScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidScepCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidScepCertificateProfile and returns a <see cref="GraphResponse{AndroidScepCertificateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidScepCertificateProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AndroidScepCertificateProfile and returns a <see cref="GraphResponse{AndroidScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidScepCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidScepCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidScepCertificateProfileToUpdate">The AndroidScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidScepCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidScepCertificateProfile> UpdateAsync(AndroidScepCertificateProfile androidScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidScepCertificateProfile using PATCH and returns a <see cref="GraphResponse{AndroidScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidScepCertificateProfileToUpdate">The AndroidScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidScepCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidScepCertificateProfile>> UpdateResponseAsync(AndroidScepCertificateProfile androidScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidScepCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidScepCertificateProfileRequest Expand(Expression<Func<AndroidScepCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidScepCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidScepCertificateProfileRequest Select(Expression<Func<AndroidScepCertificateProfile, object>> selectExpression);

    }
}
