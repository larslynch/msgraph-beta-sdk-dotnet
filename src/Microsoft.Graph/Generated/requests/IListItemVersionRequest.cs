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
    /// The interface IListItemVersionRequest.
    /// </summary>
    public partial interface IListItemVersionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ListItemVersion using POST.
        /// </summary>
        /// <param name="listItemVersionToCreate">The ListItemVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ListItemVersion.</returns>
        System.Threading.Tasks.Task<ListItemVersion> CreateAsync(ListItemVersion listItemVersionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ListItemVersion using POST and returns a <see cref="GraphResponse{ListItemVersion}"/> object.
        /// </summary>
        /// <param name="listItemVersionToCreate">The ListItemVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ListItemVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ListItemVersion>> CreateResponseAsync(ListItemVersion listItemVersionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ListItemVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ListItemVersion and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ListItemVersion.
        /// </summary>
        /// <returns>The ListItemVersion.</returns>
        System.Threading.Tasks.Task<ListItemVersion> GetAsync();

        /// <summary>
        /// Gets the specified ListItemVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ListItemVersion.</returns>
        System.Threading.Tasks.Task<ListItemVersion> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ListItemVersion and returns a <see cref="GraphResponse{ListItemVersion}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ListItemVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ListItemVersion>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ListItemVersion and returns a <see cref="GraphResponse{ListItemVersion}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ListItemVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ListItemVersion>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ListItemVersion using PATCH.
        /// </summary>
        /// <param name="listItemVersionToUpdate">The ListItemVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ListItemVersion.</returns>
        System.Threading.Tasks.Task<ListItemVersion> UpdateAsync(ListItemVersion listItemVersionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ListItemVersion using PATCH and returns a <see cref="GraphResponse{ListItemVersion}"/> object.
        /// </summary>
        /// <param name="listItemVersionToUpdate">The ListItemVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ListItemVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ListItemVersion>> UpdateResponseAsync(ListItemVersion listItemVersionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IListItemVersionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IListItemVersionRequest Expand(Expression<Func<ListItemVersion, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IListItemVersionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IListItemVersionRequest Select(Expression<Func<ListItemVersion, object>> selectExpression);

    }
}
