// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface ISourceCollectionCustodianSourcesCollectionWithReferencesPage.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.InterfaceConverter<SourceCollectionCustodianSourcesCollectionWithReferencesPage>))]
    public interface ISourceCollectionCustodianSourcesCollectionWithReferencesPage : Microsoft.Graph.ICollectionPage<DataSource>
    {
        /// <summary>
        /// Gets the next page <see cref="ISourceCollectionCustodianSourcesCollectionWithReferencesRequest"/> instance.
        /// </summary>
        ISourceCollectionCustodianSourcesCollectionWithReferencesRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}
