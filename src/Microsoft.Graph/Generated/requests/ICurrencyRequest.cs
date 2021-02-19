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
    /// The interface ICurrencyRequest.
    /// </summary>
    public partial interface ICurrencyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Currency using POST.
        /// </summary>
        /// <param name="currencyToCreate">The Currency to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Currency.</returns>
        System.Threading.Tasks.Task<Currency> CreateAsync(Currency currencyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified Currency using POST and returns a <see cref="GraphResponse{Currency}"/> object.
        /// </summary>
        /// <param name="currencyToCreate">The Currency to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Currency}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Currency>> CreateResponseAsync(Currency currencyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Currency.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Currency and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified Currency.
        /// </summary>
        /// <returns>The Currency.</returns>
        System.Threading.Tasks.Task<Currency> GetAsync();

        /// <summary>
        /// Gets the specified Currency.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Currency.</returns>
        System.Threading.Tasks.Task<Currency> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Currency and returns a <see cref="GraphResponse{Currency}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Currency}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Currency>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Currency and returns a <see cref="GraphResponse{Currency}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Currency}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Currency>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Currency using PATCH.
        /// </summary>
        /// <param name="currencyToUpdate">The Currency to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Currency.</returns>
        System.Threading.Tasks.Task<Currency> UpdateAsync(Currency currencyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Currency using PATCH and returns a <see cref="GraphResponse{Currency}"/> object.
        /// </summary>
        /// <param name="currencyToUpdate">The Currency to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Currency}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Currency>> UpdateResponseAsync(Currency currencyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICurrencyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICurrencyRequest Expand(Expression<Func<Currency, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICurrencyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICurrencyRequest Select(Expression<Func<Currency, object>> selectExpression);

    }
}
