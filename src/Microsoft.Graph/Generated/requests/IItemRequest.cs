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
    /// The interface IItemRequest.
    /// </summary>
    public partial interface IItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Item using POST.
        /// </summary>
        /// <param name="itemToCreate">The Item to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Item.</returns>
        System.Threading.Tasks.Task<Item> CreateAsync(Item itemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified Item using POST and returns a <see cref="GraphResponse{Item}"/> object.
        /// </summary>
        /// <param name="itemToCreate">The Item to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Item}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Item>> CreateResponseAsync(Item itemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Item.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Item and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified Item.
        /// </summary>
        /// <returns>The Item.</returns>
        System.Threading.Tasks.Task<Item> GetAsync();

        /// <summary>
        /// Gets the specified Item.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Item.</returns>
        System.Threading.Tasks.Task<Item> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Item and returns a <see cref="GraphResponse{Item}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Item}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Item>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Item and returns a <see cref="GraphResponse{Item}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Item}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Item>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Item using PATCH.
        /// </summary>
        /// <param name="itemToUpdate">The Item to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Item.</returns>
        System.Threading.Tasks.Task<Item> UpdateAsync(Item itemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Item using PATCH and returns a <see cref="GraphResponse{Item}"/> object.
        /// </summary>
        /// <param name="itemToUpdate">The Item to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Item}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Item>> UpdateResponseAsync(Item itemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemRequest Expand(Expression<Func<Item, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IItemRequest Select(Expression<Func<Item, object>> selectExpression);

    }
}
