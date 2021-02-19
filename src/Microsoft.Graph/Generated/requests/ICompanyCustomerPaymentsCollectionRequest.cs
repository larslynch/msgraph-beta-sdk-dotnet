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
    /// The interface ICompanyCustomerPaymentsCollectionRequest.
    /// </summary>
    public partial interface ICompanyCustomerPaymentsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified CustomerPayment to the collection via POST.
        /// </summary>
        /// <param name="customerPayment">The CustomerPayment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CustomerPayment.</returns>
        System.Threading.Tasks.Task<CustomerPayment> AddAsync(CustomerPayment customerPayment, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified CustomerPayment to the collection via POST and returns a <see cref="GraphResponse{CustomerPayment}"/> object of the request.
        /// </summary>
        /// <param name="customerPayment">The CustomerPayment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CustomerPayment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CustomerPayment>> AddResponseAsync(CustomerPayment customerPayment, CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ICompanyCustomerPaymentsCollectionPage> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{CompanyCustomerPaymentsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CompanyCustomerPaymentsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<CompanyCustomerPaymentsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyCustomerPaymentsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyCustomerPaymentsCollectionRequest Expand(Expression<Func<CustomerPayment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyCustomerPaymentsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyCustomerPaymentsCollectionRequest Select(Expression<Func<CustomerPayment, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyCustomerPaymentsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyCustomerPaymentsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyCustomerPaymentsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ICompanyCustomerPaymentsCollectionRequest OrderBy(string value);
    }
}
