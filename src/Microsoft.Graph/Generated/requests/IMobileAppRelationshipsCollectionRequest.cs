// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IMobileAppRelationshipsCollectionRequest.
    /// </summary>
    public partial interface IMobileAppRelationshipsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified MobileAppRelationship to the collection via POST.
        /// </summary>
        /// <param name="mobileAppRelationship">The MobileAppRelationship to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppRelationship.</returns>
        System.Threading.Tasks.Task<MobileAppRelationship> AddAsync(MobileAppRelationship mobileAppRelationship, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified MobileAppRelationship to the collection via POST and returns a <see cref="GraphResponse{MobileAppRelationship}"/> object of the request.
        /// </summary>
        /// <param name="mobileAppRelationship">The MobileAppRelationship to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppRelationship}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppRelationship>> AddResponseAsync(MobileAppRelationship mobileAppRelationship, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IMobileAppRelationshipsCollectionPage> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{MobileAppRelationshipsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppRelationshipsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppRelationshipsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppRelationshipsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppRelationshipsCollectionRequest Expand(Expression<Func<MobileAppRelationship, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppRelationshipsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppRelationshipsCollectionRequest Select(Expression<Func<MobileAppRelationship, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppRelationshipsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppRelationshipsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppRelationshipsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppRelationshipsCollectionRequest OrderBy(string value);
    }
}
