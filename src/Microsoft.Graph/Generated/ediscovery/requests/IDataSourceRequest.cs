// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDataSourceRequest.
    /// </summary>
    public partial interface IDataSourceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified DataSource using POST.
        /// </summary>
        /// <param name="dataSourceToCreate">The DataSource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DataSource.</returns>
        System.Threading.Tasks.Task<DataSource> CreateAsync(DataSource dataSourceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DataSource using POST and returns a <see cref="GraphResponse{DataSource}"/> object.
        /// </summary>
        /// <param name="dataSourceToCreate">The DataSource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DataSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataSource>> CreateResponseAsync(DataSource dataSourceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DataSource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DataSource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DataSource.
        /// </summary>
        /// <returns>The DataSource.</returns>
        System.Threading.Tasks.Task<DataSource> GetAsync();

        /// <summary>
        /// Gets the specified DataSource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DataSource.</returns>
        System.Threading.Tasks.Task<DataSource> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DataSource and returns a <see cref="GraphResponse{DataSource}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{DataSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataSource>> GetResponseAsync();

        /// <summary>
        /// Gets the specified DataSource and returns a <see cref="GraphResponse{DataSource}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DataSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataSource>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DataSource using PATCH.
        /// </summary>
        /// <param name="dataSourceToUpdate">The DataSource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DataSource.</returns>
        System.Threading.Tasks.Task<DataSource> UpdateAsync(DataSource dataSourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DataSource using PATCH and returns a <see cref="GraphResponse{DataSource}"/> object.
        /// </summary>
        /// <param name="dataSourceToUpdate">The DataSource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DataSource}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DataSource>> UpdateResponseAsync(DataSource dataSourceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDataSourceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDataSourceRequest Expand(Expression<Func<DataSource, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDataSourceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDataSourceRequest Select(Expression<Func<DataSource, object>> selectExpression);

    }
}
