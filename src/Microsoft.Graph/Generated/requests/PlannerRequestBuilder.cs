// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type PlannerRequestBuilder.
    /// </summary>
    public partial class PlannerRequestBuilder : EntityRequestBuilder, IPlannerRequestBuilder
    {

        /// <summary>
        /// Constructs a new PlannerRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PlannerRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPlannerRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPlannerRequest Request(IEnumerable<Option> options)
        {
            return new PlannerRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Buckets.
        /// </summary>
        /// <returns>The <see cref="IPlannerBucketsCollectionRequestBuilder"/>.</returns>
        public IPlannerBucketsCollectionRequestBuilder Buckets
        {
            get
            {
                return new PlannerBucketsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("buckets"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Plans.
        /// </summary>
        /// <returns>The <see cref="IPlannerPlansCollectionRequestBuilder"/>.</returns>
        public IPlannerPlansCollectionRequestBuilder Plans
        {
            get
            {
                return new PlannerPlansCollectionRequestBuilder(this.AppendSegmentToRequestUrl("plans"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Rosters.
        /// </summary>
        /// <returns>The <see cref="IPlannerRostersCollectionRequestBuilder"/>.</returns>
        public IPlannerRostersCollectionRequestBuilder Rosters
        {
            get
            {
                return new PlannerRostersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("rosters"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Tasks.
        /// </summary>
        /// <returns>The <see cref="IPlannerTasksCollectionRequestBuilder"/>.</returns>
        public IPlannerTasksCollectionRequestBuilder Tasks
        {
            get
            {
                return new PlannerTasksCollectionRequestBuilder(this.AppendSegmentToRequestUrl("tasks"), this.Client);
            }
        }
    
    }
}
