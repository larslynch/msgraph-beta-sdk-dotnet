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
    /// The interface ICloudPcProvisioningPolicyRequest.
    /// </summary>
    public partial interface ICloudPcProvisioningPolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CloudPcProvisioningPolicy using POST.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyToCreate">The CloudPcProvisioningPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcProvisioningPolicy.</returns>
        System.Threading.Tasks.Task<CloudPcProvisioningPolicy> CreateAsync(CloudPcProvisioningPolicy cloudPcProvisioningPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified CloudPcProvisioningPolicy using POST and returns a <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyToCreate">The CloudPcProvisioningPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicy>> CreateResponseAsync(CloudPcProvisioningPolicy cloudPcProvisioningPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CloudPcProvisioningPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CloudPcProvisioningPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicy.
        /// </summary>
        /// <returns>The CloudPcProvisioningPolicy.</returns>
        System.Threading.Tasks.Task<CloudPcProvisioningPolicy> GetAsync();

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcProvisioningPolicy.</returns>
        System.Threading.Tasks.Task<CloudPcProvisioningPolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicy and returns a <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicy>> GetResponseAsync();

        /// <summary>
        /// Gets the specified CloudPcProvisioningPolicy and returns a <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicy>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CloudPcProvisioningPolicy using PATCH.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyToUpdate">The CloudPcProvisioningPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcProvisioningPolicy.</returns>
        System.Threading.Tasks.Task<CloudPcProvisioningPolicy> UpdateAsync(CloudPcProvisioningPolicy cloudPcProvisioningPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified CloudPcProvisioningPolicy using PATCH and returns a <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object.
        /// </summary>
        /// <param name="cloudPcProvisioningPolicyToUpdate">The CloudPcProvisioningPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CloudPcProvisioningPolicy}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcProvisioningPolicy>> UpdateResponseAsync(CloudPcProvisioningPolicy cloudPcProvisioningPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcProvisioningPolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcProvisioningPolicyRequest Expand(Expression<Func<CloudPcProvisioningPolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcProvisioningPolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcProvisioningPolicyRequest Select(Expression<Func<CloudPcProvisioningPolicy, object>> selectExpression);

    }
}
