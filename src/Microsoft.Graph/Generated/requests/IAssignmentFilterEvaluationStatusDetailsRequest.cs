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
    /// The interface IAssignmentFilterEvaluationStatusDetailsRequest.
    /// </summary>
    public partial interface IAssignmentFilterEvaluationStatusDetailsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AssignmentFilterEvaluationStatusDetails using POST.
        /// </summary>
        /// <param name="assignmentFilterEvaluationStatusDetailsToCreate">The AssignmentFilterEvaluationStatusDetails to create.</param>
        /// <returns>The created AssignmentFilterEvaluationStatusDetails.</returns>
        System.Threading.Tasks.Task<AssignmentFilterEvaluationStatusDetails> CreateAsync(AssignmentFilterEvaluationStatusDetails assignmentFilterEvaluationStatusDetailsToCreate);        /// <summary>
        /// Creates the specified AssignmentFilterEvaluationStatusDetails using POST.
        /// </summary>
        /// <param name="assignmentFilterEvaluationStatusDetailsToCreate">The AssignmentFilterEvaluationStatusDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AssignmentFilterEvaluationStatusDetails.</returns>
        System.Threading.Tasks.Task<AssignmentFilterEvaluationStatusDetails> CreateAsync(AssignmentFilterEvaluationStatusDetails assignmentFilterEvaluationStatusDetailsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AssignmentFilterEvaluationStatusDetails.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AssignmentFilterEvaluationStatusDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AssignmentFilterEvaluationStatusDetails.
        /// </summary>
        /// <returns>The AssignmentFilterEvaluationStatusDetails.</returns>
        System.Threading.Tasks.Task<AssignmentFilterEvaluationStatusDetails> GetAsync();

        /// <summary>
        /// Gets the specified AssignmentFilterEvaluationStatusDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AssignmentFilterEvaluationStatusDetails.</returns>
        System.Threading.Tasks.Task<AssignmentFilterEvaluationStatusDetails> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AssignmentFilterEvaluationStatusDetails using PATCH.
        /// </summary>
        /// <param name="assignmentFilterEvaluationStatusDetailsToUpdate">The AssignmentFilterEvaluationStatusDetails to update.</param>
        /// <returns>The updated AssignmentFilterEvaluationStatusDetails.</returns>
        System.Threading.Tasks.Task<AssignmentFilterEvaluationStatusDetails> UpdateAsync(AssignmentFilterEvaluationStatusDetails assignmentFilterEvaluationStatusDetailsToUpdate);

        /// <summary>
        /// Updates the specified AssignmentFilterEvaluationStatusDetails using PATCH.
        /// </summary>
        /// <param name="assignmentFilterEvaluationStatusDetailsToUpdate">The AssignmentFilterEvaluationStatusDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AssignmentFilterEvaluationStatusDetails.</returns>
        System.Threading.Tasks.Task<AssignmentFilterEvaluationStatusDetails> UpdateAsync(AssignmentFilterEvaluationStatusDetails assignmentFilterEvaluationStatusDetailsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAssignmentFilterEvaluationStatusDetailsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAssignmentFilterEvaluationStatusDetailsRequest Expand(Expression<Func<AssignmentFilterEvaluationStatusDetails, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAssignmentFilterEvaluationStatusDetailsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAssignmentFilterEvaluationStatusDetailsRequest Select(Expression<Func<AssignmentFilterEvaluationStatusDetails, object>> selectExpression);

    }
}
