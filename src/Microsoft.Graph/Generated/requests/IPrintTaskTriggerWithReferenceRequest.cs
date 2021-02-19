// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IPrintTaskTriggerWithReferenceRequest.
    /// </summary>
    public partial interface IPrintTaskTriggerWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified PrintTaskTrigger.
        /// </summary>
        /// <returns>The PrintTaskTrigger.</returns>
        System.Threading.Tasks.Task<PrintTaskTrigger> GetAsync();

        /// <summary>
        /// Gets the specified PrintTaskTrigger.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrintTaskTrigger.</returns>
        System.Threading.Tasks.Task<PrintTaskTrigger> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrintTaskTrigger and returns a <see cref="GraphResponse{PrintTaskTrigger}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PrintTaskTrigger}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintTaskTrigger>> GetResponseAsync();

        /// <summary>
        /// Gets the specified PrintTaskTrigger and returns a <see cref="GraphResponse{PrintTaskTrigger}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintTaskTrigger}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintTaskTrigger>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified PrintTaskTrigger using POST.
        /// </summary>
        /// <param name="printTaskTriggerToCreate">The PrintTaskTrigger to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintTaskTrigger.</returns>
        System.Threading.Tasks.Task<PrintTaskTrigger> CreateAsync(PrintTaskTrigger printTaskTriggerToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified PrintTaskTrigger using POST and returns a <see cref="GraphResponse{PrintTaskTrigger}"/> object.
        /// </summary>
        /// <param name="printTaskTriggerToCreate">The PrintTaskTrigger to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintTaskTrigger}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintTaskTrigger>> CreateResponseAsync(PrintTaskTrigger printTaskTriggerToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified PrintTaskTrigger using PATCH.
        /// </summary>
        /// <param name="printTaskTriggerToUpdate">The PrintTaskTrigger to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrintTaskTrigger.</returns>
        System.Threading.Tasks.Task<PrintTaskTrigger> UpdateAsync(PrintTaskTrigger printTaskTriggerToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified PrintTaskTrigger using PATCH and returns a <see cref="GraphResponse{PrintTaskTrigger}"/> object.
        /// </summary>
        /// <param name="printTaskTriggerToUpdate">The PrintTaskTrigger to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrintTaskTrigger}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintTaskTrigger>> UpdateResponseAsync(PrintTaskTrigger printTaskTriggerToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified PrintTaskTrigger.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified PrintTaskTrigger and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintTaskTriggerWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintTaskTriggerWithReferenceRequest Expand(Expression<Func<PrintTaskTrigger, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintTaskTriggerWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintTaskTriggerWithReferenceRequest Select(Expression<Func<PrintTaskTrigger, object>> selectExpression);

    }
}
