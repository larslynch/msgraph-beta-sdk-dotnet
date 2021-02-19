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
    /// The interface IApplePushNotificationCertificateRequest.
    /// </summary>
    public partial interface IApplePushNotificationCertificateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ApplePushNotificationCertificate using POST.
        /// </summary>
        /// <param name="applePushNotificationCertificateToCreate">The ApplePushNotificationCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ApplePushNotificationCertificate.</returns>
        System.Threading.Tasks.Task<ApplePushNotificationCertificate> CreateAsync(ApplePushNotificationCertificate applePushNotificationCertificateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ApplePushNotificationCertificate using POST and returns a <see cref="GraphResponse{ApplePushNotificationCertificate}"/> object.
        /// </summary>
        /// <param name="applePushNotificationCertificateToCreate">The ApplePushNotificationCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ApplePushNotificationCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ApplePushNotificationCertificate>> CreateResponseAsync(ApplePushNotificationCertificate applePushNotificationCertificateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ApplePushNotificationCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ApplePushNotificationCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ApplePushNotificationCertificate.
        /// </summary>
        /// <returns>The ApplePushNotificationCertificate.</returns>
        System.Threading.Tasks.Task<ApplePushNotificationCertificate> GetAsync();

        /// <summary>
        /// Gets the specified ApplePushNotificationCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ApplePushNotificationCertificate.</returns>
        System.Threading.Tasks.Task<ApplePushNotificationCertificate> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ApplePushNotificationCertificate and returns a <see cref="GraphResponse{ApplePushNotificationCertificate}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ApplePushNotificationCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ApplePushNotificationCertificate>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ApplePushNotificationCertificate and returns a <see cref="GraphResponse{ApplePushNotificationCertificate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ApplePushNotificationCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ApplePushNotificationCertificate>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ApplePushNotificationCertificate using PATCH.
        /// </summary>
        /// <param name="applePushNotificationCertificateToUpdate">The ApplePushNotificationCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ApplePushNotificationCertificate.</returns>
        System.Threading.Tasks.Task<ApplePushNotificationCertificate> UpdateAsync(ApplePushNotificationCertificate applePushNotificationCertificateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ApplePushNotificationCertificate using PATCH and returns a <see cref="GraphResponse{ApplePushNotificationCertificate}"/> object.
        /// </summary>
        /// <param name="applePushNotificationCertificateToUpdate">The ApplePushNotificationCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ApplePushNotificationCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ApplePushNotificationCertificate>> UpdateResponseAsync(ApplePushNotificationCertificate applePushNotificationCertificateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IApplePushNotificationCertificateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IApplePushNotificationCertificateRequest Expand(Expression<Func<ApplePushNotificationCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IApplePushNotificationCertificateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IApplePushNotificationCertificateRequest Select(Expression<Func<ApplePushNotificationCertificate, object>> selectExpression);

    }
}
