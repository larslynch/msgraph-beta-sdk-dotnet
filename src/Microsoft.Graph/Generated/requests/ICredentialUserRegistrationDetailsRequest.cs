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
    /// The interface ICredentialUserRegistrationDetailsRequest.
    /// </summary>
    public partial interface ICredentialUserRegistrationDetailsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CredentialUserRegistrationDetails using POST.
        /// </summary>
        /// <param name="credentialUserRegistrationDetailsToCreate">The CredentialUserRegistrationDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CredentialUserRegistrationDetails.</returns>
        System.Threading.Tasks.Task<CredentialUserRegistrationDetails> CreateAsync(CredentialUserRegistrationDetails credentialUserRegistrationDetailsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified CredentialUserRegistrationDetails using POST and returns a <see cref="GraphResponse{CredentialUserRegistrationDetails}"/> object.
        /// </summary>
        /// <param name="credentialUserRegistrationDetailsToCreate">The CredentialUserRegistrationDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CredentialUserRegistrationDetails}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CredentialUserRegistrationDetails>> CreateResponseAsync(CredentialUserRegistrationDetails credentialUserRegistrationDetailsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CredentialUserRegistrationDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CredentialUserRegistrationDetails and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified CredentialUserRegistrationDetails.
        /// </summary>
        /// <returns>The CredentialUserRegistrationDetails.</returns>
        System.Threading.Tasks.Task<CredentialUserRegistrationDetails> GetAsync();

        /// <summary>
        /// Gets the specified CredentialUserRegistrationDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CredentialUserRegistrationDetails.</returns>
        System.Threading.Tasks.Task<CredentialUserRegistrationDetails> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CredentialUserRegistrationDetails and returns a <see cref="GraphResponse{CredentialUserRegistrationDetails}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{CredentialUserRegistrationDetails}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CredentialUserRegistrationDetails>> GetResponseAsync();

        /// <summary>
        /// Gets the specified CredentialUserRegistrationDetails and returns a <see cref="GraphResponse{CredentialUserRegistrationDetails}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CredentialUserRegistrationDetails}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CredentialUserRegistrationDetails>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CredentialUserRegistrationDetails using PATCH.
        /// </summary>
        /// <param name="credentialUserRegistrationDetailsToUpdate">The CredentialUserRegistrationDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CredentialUserRegistrationDetails.</returns>
        System.Threading.Tasks.Task<CredentialUserRegistrationDetails> UpdateAsync(CredentialUserRegistrationDetails credentialUserRegistrationDetailsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified CredentialUserRegistrationDetails using PATCH and returns a <see cref="GraphResponse{CredentialUserRegistrationDetails}"/> object.
        /// </summary>
        /// <param name="credentialUserRegistrationDetailsToUpdate">The CredentialUserRegistrationDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CredentialUserRegistrationDetails}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CredentialUserRegistrationDetails>> UpdateResponseAsync(CredentialUserRegistrationDetails credentialUserRegistrationDetailsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICredentialUserRegistrationDetailsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICredentialUserRegistrationDetailsRequest Expand(Expression<Func<CredentialUserRegistrationDetails, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICredentialUserRegistrationDetailsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICredentialUserRegistrationDetailsRequest Select(Expression<Func<CredentialUserRegistrationDetails, object>> selectExpression);

    }
}
