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
    /// The interface IUserSecurityProfileRequest.
    /// </summary>
    public partial interface IUserSecurityProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserSecurityProfile using POST.
        /// </summary>
        /// <param name="userSecurityProfileToCreate">The UserSecurityProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserSecurityProfile.</returns>
        System.Threading.Tasks.Task<UserSecurityProfile> CreateAsync(UserSecurityProfile userSecurityProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UserSecurityProfile using POST and returns a <see cref="GraphResponse{UserSecurityProfile}"/> object.
        /// </summary>
        /// <param name="userSecurityProfileToCreate">The UserSecurityProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserSecurityProfile>> CreateResponseAsync(UserSecurityProfile userSecurityProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserSecurityProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UserSecurityProfile.
        /// </summary>
        /// <returns>The UserSecurityProfile.</returns>
        System.Threading.Tasks.Task<UserSecurityProfile> GetAsync();

        /// <summary>
        /// Gets the specified UserSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserSecurityProfile.</returns>
        System.Threading.Tasks.Task<UserSecurityProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserSecurityProfile and returns a <see cref="GraphResponse{UserSecurityProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UserSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserSecurityProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UserSecurityProfile and returns a <see cref="GraphResponse{UserSecurityProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserSecurityProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserSecurityProfile using PATCH.
        /// </summary>
        /// <param name="userSecurityProfileToUpdate">The UserSecurityProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserSecurityProfile.</returns>
        System.Threading.Tasks.Task<UserSecurityProfile> UpdateAsync(UserSecurityProfile userSecurityProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserSecurityProfile using PATCH and returns a <see cref="GraphResponse{UserSecurityProfile}"/> object.
        /// </summary>
        /// <param name="userSecurityProfileToUpdate">The UserSecurityProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserSecurityProfile>> UpdateResponseAsync(UserSecurityProfile userSecurityProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserSecurityProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserSecurityProfileRequest Expand(Expression<Func<UserSecurityProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserSecurityProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserSecurityProfileRequest Select(Expression<Func<UserSecurityProfile, object>> selectExpression);

    }
}
