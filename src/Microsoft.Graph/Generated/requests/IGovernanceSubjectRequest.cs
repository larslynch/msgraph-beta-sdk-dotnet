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
    /// The interface IGovernanceSubjectRequest.
    /// </summary>
    public partial interface IGovernanceSubjectRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GovernanceSubject using POST.
        /// </summary>
        /// <param name="governanceSubjectToCreate">The GovernanceSubject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GovernanceSubject.</returns>
        System.Threading.Tasks.Task<GovernanceSubject> CreateAsync(GovernanceSubject governanceSubjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified GovernanceSubject using POST and returns a <see cref="GraphResponse{GovernanceSubject}"/> object.
        /// </summary>
        /// <param name="governanceSubjectToCreate">The GovernanceSubject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceSubject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernanceSubject>> CreateResponseAsync(GovernanceSubject governanceSubjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified GovernanceSubject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified GovernanceSubject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified GovernanceSubject.
        /// </summary>
        /// <returns>The GovernanceSubject.</returns>
        System.Threading.Tasks.Task<GovernanceSubject> GetAsync();

        /// <summary>
        /// Gets the specified GovernanceSubject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GovernanceSubject.</returns>
        System.Threading.Tasks.Task<GovernanceSubject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GovernanceSubject and returns a <see cref="GraphResponse{GovernanceSubject}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{GovernanceSubject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernanceSubject>> GetResponseAsync();

        /// <summary>
        /// Gets the specified GovernanceSubject and returns a <see cref="GraphResponse{GovernanceSubject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GovernanceSubject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernanceSubject>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GovernanceSubject using PATCH.
        /// </summary>
        /// <param name="governanceSubjectToUpdate">The GovernanceSubject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GovernanceSubject.</returns>
        System.Threading.Tasks.Task<GovernanceSubject> UpdateAsync(GovernanceSubject governanceSubjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified GovernanceSubject using PATCH and returns a <see cref="GraphResponse{GovernanceSubject}"/> object.
        /// </summary>
        /// <param name="governanceSubjectToUpdate">The GovernanceSubject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GovernanceSubject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GovernanceSubject>> UpdateResponseAsync(GovernanceSubject governanceSubjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceSubjectRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceSubjectRequest Expand(Expression<Func<GovernanceSubject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceSubjectRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGovernanceSubjectRequest Select(Expression<Func<GovernanceSubject, object>> selectExpression);

    }
}
