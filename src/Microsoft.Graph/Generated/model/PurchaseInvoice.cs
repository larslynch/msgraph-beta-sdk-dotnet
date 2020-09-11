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
    /// The type Purchase Invoice.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PurchaseInvoice : Entity
    {
    
		///<summary>
		/// The PurchaseInvoice constructor
		///</summary>
        public PurchaseInvoice()
        {
            this.ODataType = "microsoft.graph.purchaseInvoice";
        }
	
        /// <summary>
        /// Gets or sets buy from address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "buyFromAddress", Required = Newtonsoft.Json.Required.Default)]
        public PostalAddressType BuyFromAddress { get; set; }
    
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
        /// Gets or sets due date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dueDate", Required = Newtonsoft.Json.Required.Default)]
        public Date DueDate { get; set; }
    
        /// <summary>
        /// Gets or sets invoice date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "invoiceDate", Required = Newtonsoft.Json.Required.Default)]
        public Date InvoiceDate { get; set; }
    
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
        /// Gets or sets pay to address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payToAddress", Required = Newtonsoft.Json.Required.Default)]
        public PostalAddressType PayToAddress { get; set; }
    
        /// <summary>
        /// Gets or sets pay to contact.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payToContact", Required = Newtonsoft.Json.Required.Default)]
        public string PayToContact { get; set; }
    
        /// <summary>
        /// Gets or sets pay to name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payToName", Required = Newtonsoft.Json.Required.Default)]
        public string PayToName { get; set; }
    
        /// <summary>
        /// Gets or sets pay to vendor id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payToVendorId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? PayToVendorId { get; set; }
    
        /// <summary>
        /// Gets or sets pay to vendor number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "payToVendorNumber", Required = Newtonsoft.Json.Required.Default)]
        public string PayToVendorNumber { get; set; }
    
        /// <summary>
        /// Gets or sets prices include tax.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pricesIncludeTax", Required = Newtonsoft.Json.Required.Default)]
        public bool? PricesIncludeTax { get; set; }
    
        /// <summary>
        /// Gets or sets ship to address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shipToAddress", Required = Newtonsoft.Json.Required.Default)]
        public PostalAddressType ShipToAddress { get; set; }
    
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
        /// Gets or sets vendor id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? VendorId { get; set; }
    
        /// <summary>
        /// Gets or sets vendor invoice number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorInvoiceNumber", Required = Newtonsoft.Json.Required.Default)]
        public string VendorInvoiceNumber { get; set; }
    
        /// <summary>
        /// Gets or sets vendor name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorName", Required = Newtonsoft.Json.Required.Default)]
        public string VendorName { get; set; }
    
        /// <summary>
        /// Gets or sets vendor number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorNumber", Required = Newtonsoft.Json.Required.Default)]
        public string VendorNumber { get; set; }
    
        /// <summary>
        /// Gets or sets currency.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currency", Required = Newtonsoft.Json.Required.Default)]
        public Currency Currency { get; set; }
    
        /// <summary>
        /// Gets or sets purchase invoice lines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purchaseInvoiceLines", Required = Newtonsoft.Json.Required.Default)]
        public IPurchaseInvoicePurchaseInvoiceLinesCollectionPage PurchaseInvoiceLines { get; set; }
    
        /// <summary>
        /// Gets or sets vendor.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendor", Required = Newtonsoft.Json.Required.Default)]
        public Vendor Vendor { get; set; }
    
    }
}

