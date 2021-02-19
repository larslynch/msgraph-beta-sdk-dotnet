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
    /// The interface IIpSecurityProfileRequest.
    /// </summary>
    public partial interface IIpSecurityProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IpSecurityProfile using POST.
        /// </summary>
        /// <param name="ipSecurityProfileToCreate">The IpSecurityProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IpSecurityProfile.</returns>
        System.Threading.Tasks.Task<IpSecurityProfile> CreateAsync(IpSecurityProfile ipSecurityProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified IpSecurityProfile using POST and returns a <see cref="GraphResponse{IpSecurityProfile}"/> object.
        /// </summary>
        /// <param name="ipSecurityProfileToCreate">The IpSecurityProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IpSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IpSecurityProfile>> CreateResponseAsync(IpSecurityProfile ipSecurityProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IpSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IpSecurityProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IpSecurityProfile.
        /// </summary>
        /// <returns>The IpSecurityProfile.</returns>
        System.Threading.Tasks.Task<IpSecurityProfile> GetAsync();

        /// <summary>
        /// Gets the specified IpSecurityProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IpSecurityProfile.</returns>
        System.Threading.Tasks.Task<IpSecurityProfile> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified IpSecurityProfile and returns a <see cref="GraphResponse{IpSecurityProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{IpSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IpSecurityProfile>> GetResponseAsync();

        /// <summary>
        /// Gets the specified IpSecurityProfile and returns a <see cref="GraphResponse{IpSecurityProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IpSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IpSecurityProfile>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified IpSecurityProfile using PATCH.
        /// </summary>
        /// <param name="ipSecurityProfileToUpdate">The IpSecurityProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IpSecurityProfile.</returns>
        System.Threading.Tasks.Task<IpSecurityProfile> UpdateAsync(IpSecurityProfile ipSecurityProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IpSecurityProfile using PATCH and returns a <see cref="GraphResponse{IpSecurityProfile}"/> object.
        /// </summary>
        /// <param name="ipSecurityProfileToUpdate">The IpSecurityProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IpSecurityProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IpSecurityProfile>> UpdateResponseAsync(IpSecurityProfile ipSecurityProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIpSecurityProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIpSecurityProfileRequest Expand(Expression<Func<IpSecurityProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIpSecurityProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIpSecurityProfileRequest Select(Expression<Func<IpSecurityProfile, object>> selectExpression);

    }
}
