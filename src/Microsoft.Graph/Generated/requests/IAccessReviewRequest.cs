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
    /// The interface IAccessReviewRequest.
    /// </summary>
    public partial interface IAccessReviewRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AccessReview using POST.
        /// </summary>
        /// <param name="accessReviewToCreate">The AccessReview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AccessReview.</returns>
        System.Threading.Tasks.Task<AccessReview> CreateAsync(AccessReview accessReviewToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AccessReview using POST and returns a <see cref="GraphResponse{AccessReview}"/> object.
        /// </summary>
        /// <param name="accessReviewToCreate">The AccessReview to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReview}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReview>> CreateResponseAsync(AccessReview accessReviewToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AccessReview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AccessReview and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AccessReview.
        /// </summary>
        /// <returns>The AccessReview.</returns>
        System.Threading.Tasks.Task<AccessReview> GetAsync();

        /// <summary>
        /// Gets the specified AccessReview.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AccessReview.</returns>
        System.Threading.Tasks.Task<AccessReview> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AccessReview and returns a <see cref="GraphResponse{AccessReview}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AccessReview}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReview>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AccessReview and returns a <see cref="GraphResponse{AccessReview}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AccessReview}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReview>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AccessReview using PATCH.
        /// </summary>
        /// <param name="accessReviewToUpdate">The AccessReview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AccessReview.</returns>
        System.Threading.Tasks.Task<AccessReview> UpdateAsync(AccessReview accessReviewToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AccessReview using PATCH and returns a <see cref="GraphResponse{AccessReview}"/> object.
        /// </summary>
        /// <param name="accessReviewToUpdate">The AccessReview to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AccessReview}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AccessReview>> UpdateResponseAsync(AccessReview accessReviewToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewRequest Expand(Expression<Func<AccessReview, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAccessReviewRequest Select(Expression<Func<AccessReview, object>> selectExpression);

    }
}
