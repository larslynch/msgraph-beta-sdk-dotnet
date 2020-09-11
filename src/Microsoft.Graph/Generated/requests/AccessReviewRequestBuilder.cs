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
    /// The type AccessReviewRequestBuilder.
    /// </summary>
    public partial class AccessReviewRequestBuilder : EntityRequestBuilder, IAccessReviewRequestBuilder
    {

        /// <summary>
        /// Constructs a new AccessReviewRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessReviewRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAccessReviewRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAccessReviewRequest Request(IEnumerable<Option> options)
        {
            return new AccessReviewRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Decisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewDecisionsCollectionRequestBuilder"/>.</returns>
        public IAccessReviewDecisionsCollectionRequestBuilder Decisions
        {
            get
            {
                return new AccessReviewDecisionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("decisions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Instances.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewInstancesCollectionRequestBuilder"/>.</returns>
        public IAccessReviewInstancesCollectionRequestBuilder Instances
        {
            get
            {
                return new AccessReviewInstancesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("instances"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MyDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewMyDecisionsCollectionRequestBuilder"/>.</returns>
        public IAccessReviewMyDecisionsCollectionRequestBuilder MyDecisions
        {
            get
            {
                return new AccessReviewMyDecisionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("myDecisions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Reviewers.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewReviewersCollectionRequestBuilder"/>.</returns>
        public IAccessReviewReviewersCollectionRequestBuilder Reviewers
        {
            get
            {
                return new AccessReviewReviewersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("reviewers"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for AccessReviewApplyDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewApplyDecisionsRequestBuilder"/>.</returns>
        public IAccessReviewApplyDecisionsRequestBuilder ApplyDecisions()
        {
            return new AccessReviewApplyDecisionsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyDecisions"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AccessReviewResetDecisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewResetDecisionsRequestBuilder"/>.</returns>
        public IAccessReviewResetDecisionsRequestBuilder ResetDecisions()
        {
            return new AccessReviewResetDecisionsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.resetDecisions"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AccessReviewSendReminder.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewSendReminderRequestBuilder"/>.</returns>
        public IAccessReviewSendReminderRequestBuilder SendReminder()
        {
            return new AccessReviewSendReminderRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.sendReminder"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for AccessReviewStop.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewStopRequestBuilder"/>.</returns>
        public IAccessReviewStopRequestBuilder Stop()
        {
            return new AccessReviewStopRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.stop"),
                this.Client);
        }
    
    }
}
