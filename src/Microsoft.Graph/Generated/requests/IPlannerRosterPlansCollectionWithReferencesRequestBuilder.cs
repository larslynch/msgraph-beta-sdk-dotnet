// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IPlannerRosterPlansCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IPlannerRosterPlansCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPlannerRosterPlansCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPlannerRosterPlansCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPlannerPlanWithReferenceRequestBuilder"/> for the specified PlannerPlan.
        /// </summary>
        /// <param name="id">The ID for the PlannerPlan.</param>
        /// <returns>The <see cref="IPlannerPlanWithReferenceRequestBuilder"/>.</returns>
        IPlannerPlanWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IPlannerRosterPlansCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IPlannerRosterPlansCollectionReferencesRequestBuilder"/>.</returns>
        IPlannerRosterPlansCollectionReferencesRequestBuilder References { get; }

    }
}
