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
    /// The interface IBookingStaffMemberRequest.
    /// </summary>
    public partial interface IBookingStaffMemberRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified BookingStaffMember using POST.
        /// </summary>
        /// <param name="bookingStaffMemberToCreate">The BookingStaffMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BookingStaffMember.</returns>
        System.Threading.Tasks.Task<BookingStaffMember> CreateAsync(BookingStaffMember bookingStaffMemberToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified BookingStaffMember using POST and returns a <see cref="GraphResponse{BookingStaffMember}"/> object.
        /// </summary>
        /// <param name="bookingStaffMemberToCreate">The BookingStaffMember to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingStaffMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingStaffMember>> CreateResponseAsync(BookingStaffMember bookingStaffMemberToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified BookingStaffMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified BookingStaffMember and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified BookingStaffMember.
        /// </summary>
        /// <returns>The BookingStaffMember.</returns>
        System.Threading.Tasks.Task<BookingStaffMember> GetAsync();

        /// <summary>
        /// Gets the specified BookingStaffMember.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BookingStaffMember.</returns>
        System.Threading.Tasks.Task<BookingStaffMember> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified BookingStaffMember and returns a <see cref="GraphResponse{BookingStaffMember}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{BookingStaffMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingStaffMember>> GetResponseAsync();

        /// <summary>
        /// Gets the specified BookingStaffMember and returns a <see cref="GraphResponse{BookingStaffMember}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingStaffMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingStaffMember>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified BookingStaffMember using PATCH.
        /// </summary>
        /// <param name="bookingStaffMemberToUpdate">The BookingStaffMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BookingStaffMember.</returns>
        System.Threading.Tasks.Task<BookingStaffMember> UpdateAsync(BookingStaffMember bookingStaffMemberToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified BookingStaffMember using PATCH and returns a <see cref="GraphResponse{BookingStaffMember}"/> object.
        /// </summary>
        /// <param name="bookingStaffMemberToUpdate">The BookingStaffMember to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BookingStaffMember}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingStaffMember>> UpdateResponseAsync(BookingStaffMember bookingStaffMemberToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingStaffMemberRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IBookingStaffMemberRequest Expand(Expression<Func<BookingStaffMember, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingStaffMemberRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IBookingStaffMemberRequest Select(Expression<Func<BookingStaffMember, object>> selectExpression);

    }
}
