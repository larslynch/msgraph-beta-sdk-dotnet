// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type PrinterShareRequestBuilder.
    /// </summary>
    public partial class PrinterShareRequestBuilder : PrinterBaseRequestBuilder, IPrinterShareRequestBuilder
    {

        /// <summary>
        /// Constructs a new PrinterShareRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrinterShareRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPrinterShareRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPrinterShareRequest Request(IEnumerable<Option> options)
        {
            return new PrinterShareRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AllowedGroups.
        /// </summary>
        /// <returns>The <see cref="IPrinterShareAllowedGroupsCollectionRequestBuilder"/>.</returns>
        public IPrinterShareAllowedGroupsCollectionRequestBuilder AllowedGroups
        {
            get
            {
                return new PrinterShareAllowedGroupsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("allowedGroups"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AllowedUsers.
        /// </summary>
        /// <returns>The <see cref="IPrinterShareAllowedUsersCollectionRequestBuilder"/>.</returns>
        public IPrinterShareAllowedUsersCollectionRequestBuilder AllowedUsers
        {
            get
            {
                return new PrinterShareAllowedUsersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("allowedUsers"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Printer.
        /// </summary>
        /// <returns>The <see cref="IPrinterWithReferenceRequestBuilder"/>.</returns>
        public IPrinterWithReferenceRequestBuilder Printer
        {
            get
            {
                return new PrinterWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("printer"), this.Client);
            }
        }
    
    }
}
