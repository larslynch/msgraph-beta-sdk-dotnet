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
    /// The interface IUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsAppHealthAppPerformanceByAppVersionToCreate">The UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion> CreateAsync(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion userExperienceAnalyticsAppHealthAppPerformanceByAppVersionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsAppHealthAppPerformanceByAppVersionToCreate">The UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>> CreateResponseAsync(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion userExperienceAnalyticsAppHealthAppPerformanceByAppVersionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion.
        /// </summary>
        /// <returns>The UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion> GetAsync();

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion and returns a <see cref="GraphResponse{UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion and returns a <see cref="GraphResponse{UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsAppHealthAppPerformanceByAppVersionToUpdate">The UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion> UpdateAsync(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion userExperienceAnalyticsAppHealthAppPerformanceByAppVersionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsAppHealthAppPerformanceByAppVersionToUpdate">The UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion>> UpdateResponseAsync(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion userExperienceAnalyticsAppHealthAppPerformanceByAppVersionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionRequest Expand(Expression<Func<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsAppHealthAppPerformanceByAppVersionRequest Select(Expression<Func<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion, object>> selectExpression);

    }
}
