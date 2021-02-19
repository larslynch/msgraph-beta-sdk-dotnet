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
    /// The interface IIosPkcsCertificateProfileRequest.
    /// </summary>
    public partial interface IIosPkcsCertificateProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosPkcsCertificateProfile using POST.
        /// </summary>
        /// <param name="iosPkcsCertificateProfileToCreate">The IosPkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosPkcsCertificateProfile> CreateAsync(IosPkcsCertificateProfile iosPkcsCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified IosPkcsCertificateProfile using POST and returns a <see cref="GraphResponse{IosPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosPkcsCertificateProfileToCreate">The IosPkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosPkcsCertificateProfile>> CreateResponseAsync(IosPkcsCertificateProfile iosPkcsCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosPkcsCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IosPkcsCertificateProfile.
        /// </summary>
        /// <returns>The IosPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosPkcsCertificateProfile> GetAsync();

        /// <summary>
        /// Gets the specified IosPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosPkcsCertificateProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IosPkcsCertificateProfile and returns a <see cref="GraphResponse{IosPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{IosPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosPkcsCertificateProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified IosPkcsCertificateProfile and returns a <see cref="GraphResponse{IosPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosPkcsCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IosPkcsCertificateProfile using PATCH.
        /// </summary>
        /// <param name="iosPkcsCertificateProfileToUpdate">The IosPkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosPkcsCertificateProfile.</returns>
        System.Threading.Tasks.Task<IosPkcsCertificateProfile> UpdateAsync(IosPkcsCertificateProfile iosPkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosPkcsCertificateProfile using PATCH and returns a <see cref="GraphResponse{IosPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="iosPkcsCertificateProfileToUpdate">The IosPkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosPkcsCertificateProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosPkcsCertificateProfile>> UpdateResponseAsync(IosPkcsCertificateProfile iosPkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosPkcsCertificateProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosPkcsCertificateProfileRequest Expand(Expression<Func<IosPkcsCertificateProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosPkcsCertificateProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosPkcsCertificateProfileRequest Select(Expression<Func<IosPkcsCertificateProfile, object>> selectExpression);

    }
}
