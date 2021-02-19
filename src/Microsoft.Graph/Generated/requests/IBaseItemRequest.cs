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
    /// The interface IBaseItemRequest.
    /// </summary>
    public partial interface IBaseItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BaseItem using POST.
        /// </summary>
        /// <param name="baseItemToCreate">The BaseItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BaseItem.</returns>
        System.Threading.Tasks.Task<BaseItem> CreateAsync(BaseItem baseItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified BaseItem using POST and returns a <see cref="GraphResponse{BaseItem}"/> object.
        /// </summary>
        /// <param name="baseItemToCreate">The BaseItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BaseItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BaseItem>> CreateResponseAsync(BaseItem baseItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified BaseItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified BaseItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified BaseItem.
        /// </summary>
        /// <returns>The BaseItem.</returns>
        System.Threading.Tasks.Task<BaseItem> GetAsync();

        /// <summary>
        /// Gets the specified BaseItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BaseItem.</returns>
        System.Threading.Tasks.Task<BaseItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified BaseItem and returns a <see cref="GraphResponse{BaseItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{BaseItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BaseItem>> GetResponseAsync();

        /// <summary>
        /// Gets the specified BaseItem and returns a <see cref="GraphResponse{BaseItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BaseItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BaseItem>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified BaseItem using PATCH.
        /// </summary>
        /// <param name="baseItemToUpdate">The BaseItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BaseItem.</returns>
        System.Threading.Tasks.Task<BaseItem> UpdateAsync(BaseItem baseItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified BaseItem using PATCH and returns a <see cref="GraphResponse{BaseItem}"/> object.
        /// </summary>
        /// <param name="baseItemToUpdate">The BaseItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BaseItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BaseItem>> UpdateResponseAsync(BaseItem baseItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBaseItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBaseItemRequest Expand(Expression<Func<BaseItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBaseItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBaseItemRequest Select(Expression<Func<BaseItem, object>> selectExpression);

    }
}
