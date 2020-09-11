// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ISalesOrderRequestBuilder.
    /// </summary>
    public partial interface ISalesOrderRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ISalesOrderRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ISalesOrderRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Currency.
        /// </summary>
        /// <returns>The <see cref="ICurrencyRequestBuilder"/>.</returns>
        ICurrencyRequestBuilder Currency { get; }

        /// <summary>
        /// Gets the request builder for Customer.
        /// </summary>
        /// <returns>The <see cref="ICustomerRequestBuilder"/>.</returns>
        ICustomerRequestBuilder Customer { get; }

        /// <summary>
        /// Gets the request builder for PaymentTerm.
        /// </summary>
        /// <returns>The <see cref="IPaymentTermRequestBuilder"/>.</returns>
        IPaymentTermRequestBuilder PaymentTerm { get; }

        /// <summary>
        /// Gets the request builder for SalesOrderLines.
        /// </summary>
        /// <returns>The <see cref="ISalesOrderSalesOrderLinesCollectionRequestBuilder"/>.</returns>
        ISalesOrderSalesOrderLinesCollectionRequestBuilder SalesOrderLines { get; }
    
    }
}
