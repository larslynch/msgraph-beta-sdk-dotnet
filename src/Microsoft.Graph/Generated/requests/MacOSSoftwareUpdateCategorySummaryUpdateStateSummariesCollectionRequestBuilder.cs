// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type MacOSSoftwareUpdateCategorySummaryUpdateStateSummariesCollectionRequestBuilder.
    /// </summary>
    public partial class MacOSSoftwareUpdateCategorySummaryUpdateStateSummariesCollectionRequestBuilder : BaseRequestBuilder, IMacOSSoftwareUpdateCategorySummaryUpdateStateSummariesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new MacOSSoftwareUpdateCategorySummaryUpdateStateSummariesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MacOSSoftwareUpdateCategorySummaryUpdateStateSummariesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IMacOSSoftwareUpdateCategorySummaryUpdateStateSummariesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IMacOSSoftwareUpdateCategorySummaryUpdateStateSummariesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new MacOSSoftwareUpdateCategorySummaryUpdateStateSummariesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMacOSSoftwareUpdateStateSummaryRequestBuilder"/> for the specified MacOSSoftwareUpdateCategorySummaryMacOSSoftwareUpdateStateSummary.
        /// </summary>
        /// <param name="id">The ID for the MacOSSoftwareUpdateCategorySummaryMacOSSoftwareUpdateStateSummary.</param>
        /// <returns>The <see cref="IMacOSSoftwareUpdateStateSummaryRequestBuilder"/>.</returns>
        public IMacOSSoftwareUpdateStateSummaryRequestBuilder this[string id]
        {
            get
            {
                return new MacOSSoftwareUpdateStateSummaryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
