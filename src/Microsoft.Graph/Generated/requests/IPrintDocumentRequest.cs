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
    /// The interface IPrintDocumentRequest.
    /// </summary>
    public partial interface IPrintDocumentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrintDocument using POST.
        /// </summary>
        /// <param name="printDocumentToCreate">The PrintDocument to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintDocument.</returns>
        System.Threading.Tasks.Task<PrintDocument> CreateAsync(PrintDocument printDocumentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified PrintDocument using POST and returns a <see cref="GraphResponse{PrintDocument}"/> object.
        /// </summary>
        /// <param name="printDocumentToCreate">The PrintDocument to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintDocument}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintDocument>> CreateResponseAsync(PrintDocument printDocumentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PrintDocument.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PrintDocument and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PrintDocument.
        /// </summary>
        /// <returns>The PrintDocument.</returns>
        System.Threading.Tasks.Task<PrintDocument> GetAsync();

        /// <summary>
        /// Gets the specified PrintDocument.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrintDocument.</returns>
        System.Threading.Tasks.Task<PrintDocument> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrintDocument and returns a <see cref="GraphResponse{PrintDocument}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PrintDocument}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintDocument>> GetResponseAsync();

        /// <summary>
        /// Gets the specified PrintDocument and returns a <see cref="GraphResponse{PrintDocument}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrintDocument}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintDocument>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PrintDocument using PATCH.
        /// </summary>
        /// <param name="printDocumentToUpdate">The PrintDocument to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrintDocument.</returns>
        System.Threading.Tasks.Task<PrintDocument> UpdateAsync(PrintDocument printDocumentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PrintDocument using PATCH and returns a <see cref="GraphResponse{PrintDocument}"/> object.
        /// </summary>
        /// <param name="printDocumentToUpdate">The PrintDocument to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrintDocument}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PrintDocument>> UpdateResponseAsync(PrintDocument printDocumentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintDocumentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintDocumentRequest Expand(Expression<Func<PrintDocument, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintDocumentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintDocumentRequest Select(Expression<Func<PrintDocument, object>> selectExpression);

    }
}
