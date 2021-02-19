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
    /// The interface IAdministrativeUnitWithReferenceRequest.
    /// </summary>
    public partial interface IAdministrativeUnitWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified AdministrativeUnit.
        /// </summary>
        /// <returns>The AdministrativeUnit.</returns>
        System.Threading.Tasks.Task<AdministrativeUnit> GetAsync();

        /// <summary>
        /// Gets the specified AdministrativeUnit.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AdministrativeUnit.</returns>
        System.Threading.Tasks.Task<AdministrativeUnit> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AdministrativeUnit and returns a <see cref="GraphResponse{AdministrativeUnit}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AdministrativeUnit}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdministrativeUnit>> GetResponseAsync();

        /// <summary>
        /// Gets the specified AdministrativeUnit and returns a <see cref="GraphResponse{AdministrativeUnit}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AdministrativeUnit}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdministrativeUnit>> GetResponseAsync(CancellationToken cancellationToken);

		/// <summary>
        /// Creates the specified AdministrativeUnit using POST.
        /// </summary>
        /// <param name="administrativeUnitToCreate">The AdministrativeUnit to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AdministrativeUnit.</returns>
        System.Threading.Tasks.Task<AdministrativeUnit> CreateAsync(AdministrativeUnit administrativeUnitToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified AdministrativeUnit using POST and returns a <see cref="GraphResponse{AdministrativeUnit}"/> object.
        /// </summary>
        /// <param name="administrativeUnitToCreate">The AdministrativeUnit to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AdministrativeUnit}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdministrativeUnit>> CreateResponseAsync(AdministrativeUnit administrativeUnitToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified AdministrativeUnit using PATCH.
        /// </summary>
        /// <param name="administrativeUnitToUpdate">The AdministrativeUnit to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AdministrativeUnit.</returns>
        System.Threading.Tasks.Task<AdministrativeUnit> UpdateAsync(AdministrativeUnit administrativeUnitToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified AdministrativeUnit using PATCH and returns a <see cref="GraphResponse{AdministrativeUnit}"/> object.
        /// </summary>
        /// <param name="administrativeUnitToUpdate">The AdministrativeUnit to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AdministrativeUnit}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdministrativeUnit>> UpdateResponseAsync(AdministrativeUnit administrativeUnitToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified AdministrativeUnit.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified AdministrativeUnit and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdministrativeUnitWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdministrativeUnitWithReferenceRequest Expand(Expression<Func<AdministrativeUnit, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAdministrativeUnitWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAdministrativeUnitWithReferenceRequest Select(Expression<Func<AdministrativeUnit, object>> selectExpression);

    }
}
