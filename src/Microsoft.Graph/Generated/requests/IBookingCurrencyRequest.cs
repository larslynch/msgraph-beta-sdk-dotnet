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
    /// The interface IBookingCurrencyRequest.
    /// </summary>
    public partial interface IBookingCurrencyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BookingCurrency using POST.
        /// </summary>
        /// <param name="bookingCurrencyToCreate">The BookingCurrency to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> CreateAsync(BookingCurrency bookingCurrencyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified BookingCurrency using POST and returns a <see cref="GraphResponse{BookingCurrency}"/> object.
        /// </summary>
        /// <param name="bookingCurrencyToCreate">The BookingCurrency to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingCurrency}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingCurrency>> CreateResponseAsync(BookingCurrency bookingCurrencyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified BookingCurrency.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified BookingCurrency and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified BookingCurrency.
        /// </summary>
        /// <returns>The BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> GetAsync();

        /// <summary>
        /// Gets the specified BookingCurrency.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified BookingCurrency and returns a <see cref="GraphResponse{BookingCurrency}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{BookingCurrency}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingCurrency>> GetResponseAsync();

        /// <summary>
        /// Gets the specified BookingCurrency and returns a <see cref="GraphResponse{BookingCurrency}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingCurrency}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingCurrency>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified BookingCurrency using PATCH.
        /// </summary>
        /// <param name="bookingCurrencyToUpdate">The BookingCurrency to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> UpdateAsync(BookingCurrency bookingCurrencyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified BookingCurrency using PATCH and returns a <see cref="GraphResponse{BookingCurrency}"/> object.
        /// </summary>
        /// <param name="bookingCurrencyToUpdate">The BookingCurrency to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BookingCurrency}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingCurrency>> UpdateResponseAsync(BookingCurrency bookingCurrencyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingCurrencyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingCurrencyRequest Expand(Expression<Func<BookingCurrency, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingCurrencyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingCurrencyRequest Select(Expression<Func<BookingCurrency, object>> selectExpression);

    }
}
