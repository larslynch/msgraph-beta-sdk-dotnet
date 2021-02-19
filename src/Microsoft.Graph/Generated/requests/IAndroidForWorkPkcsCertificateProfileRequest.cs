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
    /// The interface IAndroidForWorkPkcsCertificateProfileRequest.
    /// </summary>
    public partial interface IAndroidForWorkPkcsCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidForWorkPkcsCertificateProfile using POST.
        /// </summary>
        /// <param name="androidForWorkPkcsCertificateProfileToCreate">The AndroidForWorkPkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkPkcsCertificateProfile> CreateAsync(AndroidForWorkPkcsCertificateProfile androidForWorkPkcsCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidForWorkPkcsCertificateProfile using POST and returns a <see cref="GraphResponse{AndroidForWorkPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidForWorkPkcsCertificateProfileToCreate">The AndroidForWorkPkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkPkcsCertificateProfile>> CreateResponseAsync(AndroidForWorkPkcsCertificateProfile androidForWorkPkcsCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidForWorkPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidForWorkPkcsCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidForWorkPkcsCertificateProfile.
        /// </summary>
        /// <returns>The AndroidForWorkPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkPkcsCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified AndroidForWorkPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkPkcsCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidForWorkPkcsCertificateProfile and returns a <see cref="GraphResponse{AndroidForWorkPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkPkcsCertificateProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AndroidForWorkPkcsCertificateProfile and returns a <see cref="GraphResponse{AndroidForWorkPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkPkcsCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidForWorkPkcsCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidForWorkPkcsCertificateProfileToUpdate">The AndroidForWorkPkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidForWorkPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<AndroidForWorkPkcsCertificateProfile> UpdateAsync(AndroidForWorkPkcsCertificateProfile androidForWorkPkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidForWorkPkcsCertificateProfile using PATCH and returns a <see cref="GraphResponse{AndroidForWorkPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidForWorkPkcsCertificateProfileToUpdate">The AndroidForWorkPkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkPkcsCertificateProfile>> UpdateResponseAsync(AndroidForWorkPkcsCertificateProfile androidForWorkPkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkPkcsCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkPkcsCertificateProfileRequest Expand(Expression<Func<AndroidForWorkPkcsCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkPkcsCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkPkcsCertificateProfileRequest Select(Expression<Func<AndroidForWorkPkcsCertificateProfile, object>> selectExpression);

    }
}
