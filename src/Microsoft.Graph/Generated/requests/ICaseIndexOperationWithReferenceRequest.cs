// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICaseIndexOperationWithReferenceRequest.
    /// </summary>
    public partial interface ICaseIndexOperationWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified CaseIndexOperation.
        /// </summary>
        /// <returns>The CaseIndexOperation.</returns>
        System.Threading.Tasks.Task<CaseIndexOperation> GetAsync();

        /// <summary>
        /// Gets the specified CaseIndexOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CaseIndexOperation.</returns>
        System.Threading.Tasks.Task<CaseIndexOperation> GetAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified CaseIndexOperation using POST.
        /// </summary>
        /// <param name="caseIndexOperationToCreate">The CaseIndexOperation to create.</param>
        /// <returns>The created CaseIndexOperation.</returns>
        System.Threading.Tasks.Task<CaseIndexOperation> CreateAsync(CaseIndexOperation caseIndexOperationToCreate);        /// <summary>
        /// Creates the specified CaseIndexOperation using POST.
        /// </summary>
        /// <param name="caseIndexOperationToCreate">The CaseIndexOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CaseIndexOperation.</returns>
        System.Threading.Tasks.Task<CaseIndexOperation> CreateAsync(CaseIndexOperation caseIndexOperationToCreate, CancellationToken cancellationToken);

		/// <summary>
        /// Updates the specified CaseIndexOperation using PATCH.
        /// </summary>
        /// <param name="caseIndexOperationToUpdate">The CaseIndexOperation to update.</param>
        /// <returns>The updated CaseIndexOperation.</returns>
        System.Threading.Tasks.Task<CaseIndexOperation> UpdateAsync(CaseIndexOperation caseIndexOperationToUpdate);

        /// <summary>
        /// Updates the specified CaseIndexOperation using PATCH.
        /// </summary>
        /// <param name="caseIndexOperationToUpdate">The CaseIndexOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CaseIndexOperation.</returns>
        System.Threading.Tasks.Task<CaseIndexOperation> UpdateAsync(CaseIndexOperation caseIndexOperationToUpdate, CancellationToken cancellationToken);

		/// <summary>
        /// Deletes the specified CaseIndexOperation.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CaseIndexOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICaseIndexOperationWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICaseIndexOperationWithReferenceRequest Expand(Expression<Func<CaseIndexOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICaseIndexOperationWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICaseIndexOperationWithReferenceRequest Select(Expression<Func<CaseIndexOperation, object>> selectExpression);

    }
}
