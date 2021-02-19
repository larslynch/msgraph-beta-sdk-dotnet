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
    /// The interface IMessageRuleRequest.
    /// </summary>
    public partial interface IMessageRuleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MessageRule using POST.
        /// </summary>
        /// <param name="messageRuleToCreate">The MessageRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MessageRule.</returns>
        System.Threading.Tasks.Task<MessageRule> CreateAsync(MessageRule messageRuleToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified MessageRule using POST and returns a <see cref="GraphResponse{MessageRule}"/> object.
        /// </summary>
        /// <param name="messageRuleToCreate">The MessageRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MessageRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MessageRule>> CreateResponseAsync(MessageRule messageRuleToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified MessageRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified MessageRule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified MessageRule.
        /// </summary>
        /// <returns>The MessageRule.</returns>
        System.Threading.Tasks.Task<MessageRule> GetAsync();

        /// <summary>
        /// Gets the specified MessageRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MessageRule.</returns>
        System.Threading.Tasks.Task<MessageRule> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MessageRule and returns a <see cref="GraphResponse{MessageRule}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MessageRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MessageRule>> GetResponseAsync();

        /// <summary>
        /// Gets the specified MessageRule and returns a <see cref="GraphResponse{MessageRule}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MessageRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MessageRule>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MessageRule using PATCH.
        /// </summary>
        /// <param name="messageRuleToUpdate">The MessageRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MessageRule.</returns>
        System.Threading.Tasks.Task<MessageRule> UpdateAsync(MessageRule messageRuleToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified MessageRule using PATCH and returns a <see cref="GraphResponse{MessageRule}"/> object.
        /// </summary>
        /// <param name="messageRuleToUpdate">The MessageRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MessageRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MessageRule>> UpdateResponseAsync(MessageRule messageRuleToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRuleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRuleRequest Expand(Expression<Func<MessageRule, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRuleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMessageRuleRequest Select(Expression<Func<MessageRule, object>> selectExpression);

    }
}
