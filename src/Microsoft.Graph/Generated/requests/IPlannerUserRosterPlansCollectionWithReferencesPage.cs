// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IPlannerUserRosterPlansCollectionWithReferencesPage.
    /// </summary>
    [JsonConverter(typeof(InterfaceConverter<PlannerUserRosterPlansCollectionWithReferencesPage>))]
    public interface IPlannerUserRosterPlansCollectionWithReferencesPage : ICollectionPage<PlannerPlan>
    {
        /// <summary>
        /// Gets the next page <see cref="IPlannerUserRosterPlansCollectionWithReferencesRequest"/> instance.
        /// </summary>
        IPlannerUserRosterPlansCollectionWithReferencesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
