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
    /// The interface ISalesQuoteRequestBuilder.
    /// </summary>
    public partial interface ISalesQuoteRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ISalesQuoteRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ISalesQuoteRequest Request(IEnumerable<Option> options);
    
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
        /// Gets the request builder for SalesQuoteLines.
        /// </summary>
        /// <returns>The <see cref="ISalesQuoteSalesQuoteLinesCollectionRequestBuilder"/>.</returns>
        ISalesQuoteSalesQuoteLinesCollectionRequestBuilder SalesQuoteLines { get; }

        /// <summary>
        /// Gets the request builder for ShipmentMethod.
        /// </summary>
        /// <returns>The <see cref="IShipmentMethodRequestBuilder"/>.</returns>
        IShipmentMethodRequestBuilder ShipmentMethod { get; }
    
        /// <summary>
        /// Gets the request builder for SalesQuoteSend.
        /// </summary>
        /// <returns>The <see cref="ISalesQuoteSendRequestBuilder"/>.</returns>
        ISalesQuoteSendRequestBuilder Send();

        /// <summary>
        /// Gets the request builder for SalesQuoteMakeInvoice.
        /// </summary>
        /// <returns>The <see cref="ISalesQuoteMakeInvoiceRequestBuilder"/>.</returns>
        ISalesQuoteMakeInvoiceRequestBuilder MakeInvoice();
    
    }
}
