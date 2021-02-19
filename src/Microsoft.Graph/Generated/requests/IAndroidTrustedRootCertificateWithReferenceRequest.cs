// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAndroidTrustedRootCertificateWithReferenceRequest.
    /// </summary>
    public partial interface IAndroidTrustedRootCertificateWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified AndroidTrustedRootCertificate.
        /// </summary>
        /// <returns>The AndroidTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidTrustedRootCertificate> GetAsync();

        /// <summary>
        /// Gets the specified AndroidTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidTrustedRootCertificate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidTrustedRootCertificate and returns a <see cref="GraphResponse{AndroidTrustedRootCertificate}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidTrustedRootCertificate>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AndroidTrustedRootCertificate and returns a <see cref="GraphResponse{AndroidTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidTrustedRootCertificate>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified AndroidTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="androidTrustedRootCertificateToCreate">The AndroidTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidTrustedRootCertificate> CreateAsync(AndroidTrustedRootCertificate androidTrustedRootCertificateToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified AndroidTrustedRootCertificate using POST and returns a <see cref="GraphResponse{AndroidTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="androidTrustedRootCertificateToCreate">The AndroidTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidTrustedRootCertificate>> CreateResponseAsync(AndroidTrustedRootCertificate androidTrustedRootCertificateToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified AndroidTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="androidTrustedRootCertificateToUpdate">The AndroidTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidTrustedRootCertificate> UpdateAsync(AndroidTrustedRootCertificate androidTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified AndroidTrustedRootCertificate using PATCH and returns a <see cref="GraphResponse{AndroidTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="androidTrustedRootCertificateToUpdate">The AndroidTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidTrustedRootCertificate>> UpdateResponseAsync(AndroidTrustedRootCertificate androidTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified AndroidTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified AndroidTrustedRootCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidTrustedRootCertificateWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidTrustedRootCertificateWithReferenceRequest Expand(Expression<Func<AndroidTrustedRootCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidTrustedRootCertificateWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidTrustedRootCertificateWithReferenceRequest Select(Expression<Func<AndroidTrustedRootCertificate, object>> selectExpression);

    }
}
