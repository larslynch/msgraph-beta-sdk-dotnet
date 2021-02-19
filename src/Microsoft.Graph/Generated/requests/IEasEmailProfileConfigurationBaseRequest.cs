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
    /// The interface IEasEmailProfileConfigurationBaseRequest.
    /// </summary>
    public partial interface IEasEmailProfileConfigurationBaseRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EasEmailProfileConfigurationBase using POST.
        /// </summary>
        /// <param name="easEmailProfileConfigurationBaseToCreate">The EasEmailProfileConfigurationBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EasEmailProfileConfigurationBase.</returns>
        System.Threading.Tasks.Task<EasEmailProfileConfigurationBase> CreateAsync(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified EasEmailProfileConfigurationBase using POST and returns a <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object.
        /// </summary>
        /// <param name="easEmailProfileConfigurationBaseToCreate">The EasEmailProfileConfigurationBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EasEmailProfileConfigurationBase>> CreateResponseAsync(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EasEmailProfileConfigurationBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EasEmailProfileConfigurationBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EasEmailProfileConfigurationBase.
        /// </summary>
        /// <returns>The EasEmailProfileConfigurationBase.</returns>
        System.Threading.Tasks.Task<EasEmailProfileConfigurationBase> GetAsync();

        /// <summary>
        /// Gets the specified EasEmailProfileConfigurationBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EasEmailProfileConfigurationBase.</returns>
        System.Threading.Tasks.Task<EasEmailProfileConfigurationBase> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified EasEmailProfileConfigurationBase and returns a <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EasEmailProfileConfigurationBase>> GetResponseAsync();

        /// <summary>
        /// Gets the specified EasEmailProfileConfigurationBase and returns a <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EasEmailProfileConfigurationBase>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified EasEmailProfileConfigurationBase using PATCH.
        /// </summary>
        /// <param name="easEmailProfileConfigurationBaseToUpdate">The EasEmailProfileConfigurationBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EasEmailProfileConfigurationBase.</returns>
        System.Threading.Tasks.Task<EasEmailProfileConfigurationBase> UpdateAsync(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EasEmailProfileConfigurationBase using PATCH and returns a <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object.
        /// </summary>
        /// <param name="easEmailProfileConfigurationBaseToUpdate">The EasEmailProfileConfigurationBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EasEmailProfileConfigurationBase}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EasEmailProfileConfigurationBase>> UpdateResponseAsync(EasEmailProfileConfigurationBase easEmailProfileConfigurationBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEasEmailProfileConfigurationBaseRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEasEmailProfileConfigurationBaseRequest Expand(Expression<Func<EasEmailProfileConfigurationBase, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEasEmailProfileConfigurationBaseRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEasEmailProfileConfigurationBaseRequest Select(Expression<Func<EasEmailProfileConfigurationBase, object>> selectExpression);

    }
}
