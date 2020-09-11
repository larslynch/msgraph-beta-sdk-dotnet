// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Sales Order.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SalesOrder : Entity
    {
    
		///<summary>
		/// The SalesOrder constructor
		///</summary>
        public SalesOrder()
        {
            this.ODataType = "microsoft.graph.salesOrder";
        }
	
        /// <summary>
        /// Gets or sets billing postal address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billingPostalAddress", Required = Newtonsoft.Json.Required.Default)]
        public PostalAddressType BillingPostalAddress { get; set; }
    
        /// <summary>
        /// Gets or sets bill to customer id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billToCustomerId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? BillToCustomerId { get; set; }
    
        /// <summary>
        /// Gets or sets bill to customer number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billToCustomerNumber", Required = Newtonsoft.Json.Required.Default)]
        public string BillToCustomerNumber { get; set; }
    
        /// <summary>
        /// Gets or sets bill to name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "billToName", Required = Newtonsoft.Json.Required.Default)]
        public string BillToName { get; set; }
    
        /// <summary>
        /// Gets or sets currency code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currencyCode", Required = Newtonsoft.Json.Required.Default)]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// Gets or sets currency id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currencyId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? CurrencyId { get; set; }
    
        /// <summary>
        /// Gets or sets customer id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customerId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? CustomerId { get; set; }
    
        /// <summary>
        /// Gets or sets customer name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customerName", Required = Newtonsoft.Json.Required.Default)]
        public string CustomerName { get; set; }
    
        /// <summary>
        /// Gets or sets customer number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customerNumber", Required = Newtonsoft.Json.Required.Default)]
        public string CustomerNumber { get; set; }
    
        /// <summary>
        /// Gets or sets discount amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discountAmount", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? DiscountAmount { get; set; }
    
        /// <summary>
        /// Gets or sets discount applied before tax.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "discountAppliedBeforeTax", Required = Newtonsoft.Json.Required.Default)]
        public bool? DiscountAppliedBeforeTax { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email", Required = Newtonsoft.Json.Required.Default)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets external document number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalDocumentNumber", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalDocumentNumber { get; set; }
    
        /// <summary>
        /// Gets or sets fully shipped.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fullyShipped", Required = Newtonsoft.Json.Required.Default)]
        public bool? FullyShipped { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number", Required = Newtonsoft.Json.Required.Default)]
        public string Number { get; set; }
    
        /// <summary>
        /// Gets or sets order date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orderDate", Required = Newtonsoft.Json.Required.Default)]
        public Date OrderDate { get; set; }
    
        /// <summary>
        /// Gets or sets partial shipping.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "partialShipping", Required = Newtonsoft.Json.Required.Default)]
        public bool? PartialShipping { get; set; }
    
        /// <summary>
        /// Gets or sets payment terms id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paymentTermsId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? PaymentTermsId { get; set; }
    
        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phoneNumber", Required = Newtonsoft.Json.Required.Default)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets prices include tax.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pricesIncludeTax", Required = Newtonsoft.Json.Required.Default)]
        public bool? PricesIncludeTax { get; set; }
    
        /// <summary>
        /// Gets or sets requested delivery date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requestedDeliveryDate", Required = Newtonsoft.Json.Required.Default)]
        public Date RequestedDeliveryDate { get; set; }
    
        /// <summary>
        /// Gets or sets salesperson.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salesperson", Required = Newtonsoft.Json.Required.Default)]
        public string Salesperson { get; set; }
    
        /// <summary>
        /// Gets or sets selling postal address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sellingPostalAddress", Required = Newtonsoft.Json.Required.Default)]
        public PostalAddressType SellingPostalAddress { get; set; }
    
        /// <summary>
        /// Gets or sets shipping postal address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shippingPostalAddress", Required = Newtonsoft.Json.Required.Default)]
        public PostalAddressType ShippingPostalAddress { get; set; }
    
        /// <summary>
        /// Gets or sets ship to contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shipToContact", Required = Newtonsoft.Json.Required.Default)]
        public string ShipToContact { get; set; }
    
        /// <summary>
        /// Gets or sets ship to name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shipToName", Required = Newtonsoft.Json.Required.Default)]
        public string ShipToName { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets total amount excluding tax.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalAmountExcludingTax", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? TotalAmountExcludingTax { get; set; }
    
        /// <summary>
        /// Gets or sets total amount including tax.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalAmountIncludingTax", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? TotalAmountIncludingTax { get; set; }
    
        /// <summary>
        /// Gets or sets total tax amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalTaxAmount", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? TotalTaxAmount { get; set; }
    
        /// <summary>
        /// Gets or sets currency.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency", Required = Newtonsoft.Json.Required.Default)]
        public Currency Currency { get; set; }
    
        /// <summary>
        /// Gets or sets customer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customer", Required = Newtonsoft.Json.Required.Default)]
        public Customer Customer { get; set; }
    
        /// <summary>
        /// Gets or sets payment term.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paymentTerm", Required = Newtonsoft.Json.Required.Default)]
        public PaymentTerm PaymentTerm { get; set; }
    
        /// <summary>
        /// Gets or sets sales order lines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salesOrderLines", Required = Newtonsoft.Json.Required.Default)]
        public ISalesOrderSalesOrderLinesCollectionPage SalesOrderLines { get; set; }
    
    }
}

