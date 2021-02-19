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
    /// The interface IWindowsPhone81AppXRequest.
    /// </summary>
    public partial interface IWindowsPhone81AppXRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsPhone81AppX using POST.
        /// </summary>
        /// <param name="windowsPhone81AppXToCreate">The WindowsPhone81AppX to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsPhone81AppX.</returns>
        System.Threading.Tasks.Task<WindowsPhone81AppX> CreateAsync(WindowsPhone81AppX windowsPhone81AppXToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WindowsPhone81AppX using POST and returns a <see cref="GraphResponse{WindowsPhone81AppX}"/> object.
        /// </summary>
        /// <param name="windowsPhone81AppXToCreate">The WindowsPhone81AppX to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81AppX}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsPhone81AppX>> CreateResponseAsync(WindowsPhone81AppX windowsPhone81AppXToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsPhone81AppX.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsPhone81AppX and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsPhone81AppX.
        /// </summary>
        /// <returns>The WindowsPhone81AppX.</returns>
        System.Threading.Tasks.Task<WindowsPhone81AppX> GetAsync();

        /// <summary>
        /// Gets the specified WindowsPhone81AppX.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsPhone81AppX.</returns>
        System.Threading.Tasks.Task<WindowsPhone81AppX> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsPhone81AppX and returns a <see cref="GraphResponse{WindowsPhone81AppX}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81AppX}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsPhone81AppX>> GetResponseAsync();

        /// <summary>
        /// Gets the specified WindowsPhone81AppX and returns a <see cref="GraphResponse{WindowsPhone81AppX}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81AppX}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsPhone81AppX>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsPhone81AppX using PATCH.
        /// </summary>
        /// <param name="windowsPhone81AppXToUpdate">The WindowsPhone81AppX to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsPhone81AppX.</returns>
        System.Threading.Tasks.Task<WindowsPhone81AppX> UpdateAsync(WindowsPhone81AppX windowsPhone81AppXToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsPhone81AppX using PATCH and returns a <see cref="GraphResponse{WindowsPhone81AppX}"/> object.
        /// </summary>
        /// <param name="windowsPhone81AppXToUpdate">The WindowsPhone81AppX to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsPhone81AppX}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsPhone81AppX>> UpdateResponseAsync(WindowsPhone81AppX windowsPhone81AppXToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81AppXRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81AppXRequest Expand(Expression<Func<WindowsPhone81AppX, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81AppXRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsPhone81AppXRequest Select(Expression<Func<WindowsPhone81AppX, object>> selectExpression);

    }
}
