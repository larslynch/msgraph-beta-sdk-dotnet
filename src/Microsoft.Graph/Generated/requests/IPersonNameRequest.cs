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
    /// The interface IPersonNameRequest.
    /// </summary>
    public partial interface IPersonNameRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PersonName using POST.
        /// </summary>
        /// <param name="personNameToCreate">The PersonName to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PersonName.</returns>
        System.Threading.Tasks.Task<PersonName> CreateAsync(PersonName personNameToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified PersonName using POST and returns a <see cref="GraphResponse{PersonName}"/> object.
        /// </summary>
        /// <param name="personNameToCreate">The PersonName to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PersonName}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonName>> CreateResponseAsync(PersonName personNameToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PersonName.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified PersonName and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified PersonName.
        /// </summary>
        /// <returns>The PersonName.</returns>
        System.Threading.Tasks.Task<PersonName> GetAsync();

        /// <summary>
        /// Gets the specified PersonName.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PersonName.</returns>
        System.Threading.Tasks.Task<PersonName> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PersonName and returns a <see cref="GraphResponse{PersonName}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{PersonName}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonName>> GetResponseAsync();

        /// <summary>
        /// Gets the specified PersonName and returns a <see cref="GraphResponse{PersonName}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PersonName}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonName>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PersonName using PATCH.
        /// </summary>
        /// <param name="personNameToUpdate">The PersonName to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PersonName.</returns>
        System.Threading.Tasks.Task<PersonName> UpdateAsync(PersonName personNameToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified PersonName using PATCH and returns a <see cref="GraphResponse{PersonName}"/> object.
        /// </summary>
        /// <param name="personNameToUpdate">The PersonName to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PersonName}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<PersonName>> UpdateResponseAsync(PersonName personNameToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPersonNameRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPersonNameRequest Expand(Expression<Func<PersonName, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPersonNameRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPersonNameRequest Select(Expression<Func<PersonName, object>> selectExpression);

    }
}
