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
    /// The interface IUnsupportedGroupPolicyExtensionRequest.
    /// </summary>
    public partial interface IUnsupportedGroupPolicyExtensionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnsupportedGroupPolicyExtension using POST.
        /// </summary>
        /// <param name="unsupportedGroupPolicyExtensionToCreate">The UnsupportedGroupPolicyExtension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnsupportedGroupPolicyExtension.</returns>
        System.Threading.Tasks.Task<UnsupportedGroupPolicyExtension> CreateAsync(UnsupportedGroupPolicyExtension unsupportedGroupPolicyExtensionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UnsupportedGroupPolicyExtension using POST and returns a <see cref="GraphResponse{UnsupportedGroupPolicyExtension}"/> object.
        /// </summary>
        /// <param name="unsupportedGroupPolicyExtensionToCreate">The UnsupportedGroupPolicyExtension to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnsupportedGroupPolicyExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnsupportedGroupPolicyExtension>> CreateResponseAsync(UnsupportedGroupPolicyExtension unsupportedGroupPolicyExtensionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnsupportedGroupPolicyExtension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnsupportedGroupPolicyExtension and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnsupportedGroupPolicyExtension.
        /// </summary>
        /// <returns>The UnsupportedGroupPolicyExtension.</returns>
        System.Threading.Tasks.Task<UnsupportedGroupPolicyExtension> GetAsync();

        /// <summary>
        /// Gets the specified UnsupportedGroupPolicyExtension.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnsupportedGroupPolicyExtension.</returns>
        System.Threading.Tasks.Task<UnsupportedGroupPolicyExtension> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UnsupportedGroupPolicyExtension and returns a <see cref="GraphResponse{UnsupportedGroupPolicyExtension}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UnsupportedGroupPolicyExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnsupportedGroupPolicyExtension>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UnsupportedGroupPolicyExtension and returns a <see cref="GraphResponse{UnsupportedGroupPolicyExtension}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnsupportedGroupPolicyExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnsupportedGroupPolicyExtension>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UnsupportedGroupPolicyExtension using PATCH.
        /// </summary>
        /// <param name="unsupportedGroupPolicyExtensionToUpdate">The UnsupportedGroupPolicyExtension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnsupportedGroupPolicyExtension.</returns>
        System.Threading.Tasks.Task<UnsupportedGroupPolicyExtension> UpdateAsync(UnsupportedGroupPolicyExtension unsupportedGroupPolicyExtensionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnsupportedGroupPolicyExtension using PATCH and returns a <see cref="GraphResponse{UnsupportedGroupPolicyExtension}"/> object.
        /// </summary>
        /// <param name="unsupportedGroupPolicyExtensionToUpdate">The UnsupportedGroupPolicyExtension to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnsupportedGroupPolicyExtension}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnsupportedGroupPolicyExtension>> UpdateResponseAsync(UnsupportedGroupPolicyExtension unsupportedGroupPolicyExtensionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnsupportedGroupPolicyExtensionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnsupportedGroupPolicyExtensionRequest Expand(Expression<Func<UnsupportedGroupPolicyExtension, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnsupportedGroupPolicyExtensionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnsupportedGroupPolicyExtensionRequest Select(Expression<Func<UnsupportedGroupPolicyExtension, object>> selectExpression);

    }
}
