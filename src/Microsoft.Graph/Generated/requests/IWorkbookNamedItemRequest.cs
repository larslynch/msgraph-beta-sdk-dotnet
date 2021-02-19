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
    /// The interface IWorkbookNamedItemRequest.
    /// </summary>
    public partial interface IWorkbookNamedItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookNamedItem using POST.
        /// </summary>
        /// <param name="workbookNamedItemToCreate">The WorkbookNamedItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookNamedItem.</returns>
        System.Threading.Tasks.Task<WorkbookNamedItem> CreateAsync(WorkbookNamedItem workbookNamedItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WorkbookNamedItem using POST and returns a <see cref="GraphResponse{WorkbookNamedItem}"/> object.
        /// </summary>
        /// <param name="workbookNamedItemToCreate">The WorkbookNamedItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookNamedItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookNamedItem>> CreateResponseAsync(WorkbookNamedItem workbookNamedItemToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkbookNamedItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkbookNamedItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkbookNamedItem.
        /// </summary>
        /// <returns>The WorkbookNamedItem.</returns>
        System.Threading.Tasks.Task<WorkbookNamedItem> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookNamedItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookNamedItem.</returns>
        System.Threading.Tasks.Task<WorkbookNamedItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookNamedItem and returns a <see cref="GraphResponse{WorkbookNamedItem}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WorkbookNamedItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookNamedItem>> GetResponseAsync();

        /// <summary>
        /// Gets the specified WorkbookNamedItem and returns a <see cref="GraphResponse{WorkbookNamedItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookNamedItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookNamedItem>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookNamedItem using PATCH.
        /// </summary>
        /// <param name="workbookNamedItemToUpdate">The WorkbookNamedItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookNamedItem.</returns>
        System.Threading.Tasks.Task<WorkbookNamedItem> UpdateAsync(WorkbookNamedItem workbookNamedItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookNamedItem using PATCH and returns a <see cref="GraphResponse{WorkbookNamedItem}"/> object.
        /// </summary>
        /// <param name="workbookNamedItemToUpdate">The WorkbookNamedItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookNamedItem}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookNamedItem>> UpdateResponseAsync(WorkbookNamedItem workbookNamedItemToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamedItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamedItemRequest Expand(Expression<Func<WorkbookNamedItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamedItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookNamedItemRequest Select(Expression<Func<WorkbookNamedItem, object>> selectExpression);

    }
}
