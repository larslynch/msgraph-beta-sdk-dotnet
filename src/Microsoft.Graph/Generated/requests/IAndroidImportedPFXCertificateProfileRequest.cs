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
    /// The interface IAndroidImportedPFXCertificateProfileRequest.
    /// </summary>
    public partial interface IAndroidImportedPFXCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="androidImportedPFXCertificateProfileToCreate">The AndroidImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidImportedPFXCertificateProfile> CreateAsync(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidImportedPFXCertificateProfile using POST and returns a <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidImportedPFXCertificateProfileToCreate">The AndroidImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidImportedPFXCertificateProfile>> CreateResponseAsync(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidImportedPFXCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidImportedPFXCertificateProfile.
        /// </summary>
        /// <returns>The AndroidImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidImportedPFXCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified AndroidImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidImportedPFXCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidImportedPFXCertificateProfile and returns a <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidImportedPFXCertificateProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AndroidImportedPFXCertificateProfile and returns a <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidImportedPFXCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidImportedPFXCertificateProfileToUpdate">The AndroidImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidImportedPFXCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidImportedPFXCertificateProfile> UpdateAsync(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidImportedPFXCertificateProfile using PATCH and returns a <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidImportedPFXCertificateProfileToUpdate">The AndroidImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidImportedPFXCertificateProfile>> UpdateResponseAsync(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidImportedPFXCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidImportedPFXCertificateProfileRequest Expand(Expression<Func<AndroidImportedPFXCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidImportedPFXCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidImportedPFXCertificateProfileRequest Select(Expression<Func<AndroidImportedPFXCertificateProfile, object>> selectExpression);

    }
}
