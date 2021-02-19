// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type MacOSPkcsCertificateProfileRequest.
    /// </summary>
    public partial class MacOSPkcsCertificateProfileRequest : BaseRequest, IMacOSPkcsCertificateProfileRequest
    {
        /// <summary>
        /// Constructs a new MacOSPkcsCertificateProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSPkcsCertificateProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSPkcsCertificateProfile using POST.
        /// </summary>
        /// <param name="macOSPkcsCertificateProfileToCreate">The MacOSPkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSPkcsCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<MacOSPkcsCertificateProfile> CreateAsync(MacOSPkcsCertificateProfile macOSPkcsCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<MacOSPkcsCertificateProfile>(macOSPkcsCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MacOSPkcsCertificateProfile using POST and returns a <see cref="GraphResponse{MacOSPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="macOSPkcsCertificateProfileToCreate">The MacOSPkcsCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSPkcsCertificateProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSPkcsCertificateProfile>> CreateResponseAsync(MacOSPkcsCertificateProfile macOSPkcsCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<MacOSPkcsCertificateProfile>(macOSPkcsCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<MacOSPkcsCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSPkcsCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MacOSPkcsCertificateProfile.
        /// </summary>
        /// <returns>The MacOSPkcsCertificateProfile.</returns>
        public System.Threading.Tasks.Task<MacOSPkcsCertificateProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSPkcsCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSPkcsCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<MacOSPkcsCertificateProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MacOSPkcsCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MacOSPkcsCertificateProfile and returns a <see cref="GraphResponse{MacOSPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MacOSPkcsCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSPkcsCertificateProfile>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MacOSPkcsCertificateProfile and returns a <see cref="GraphResponse{MacOSPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSPkcsCertificateProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSPkcsCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<MacOSPkcsCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified MacOSPkcsCertificateProfile using PATCH.
        /// </summary>
        /// <param name="macOSPkcsCertificateProfileToUpdate">The MacOSPkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSPkcsCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<MacOSPkcsCertificateProfile> UpdateAsync(MacOSPkcsCertificateProfile macOSPkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MacOSPkcsCertificateProfile>(macOSPkcsCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSPkcsCertificateProfile using PATCH and returns a <see cref="GraphResponse{MacOSPkcsCertificateProfile}"/> object.
        /// </summary>
        /// <param name="macOSPkcsCertificateProfileToUpdate">The MacOSPkcsCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSPkcsCertificateProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<MacOSPkcsCertificateProfile>> UpdateResponseAsync(MacOSPkcsCertificateProfile macOSPkcsCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<MacOSPkcsCertificateProfile>(macOSPkcsCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSPkcsCertificateProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSPkcsCertificateProfileRequest Expand(Expression<Func<MacOSPkcsCertificateProfile, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSPkcsCertificateProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSPkcsCertificateProfileRequest Select(Expression<Func<MacOSPkcsCertificateProfile, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="macOSPkcsCertificateProfileToInitialize">The <see cref="MacOSPkcsCertificateProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSPkcsCertificateProfile macOSPkcsCertificateProfileToInitialize)
        {

            if (macOSPkcsCertificateProfileToInitialize != null && macOSPkcsCertificateProfileToInitialize.AdditionalData != null)
            {

                if (macOSPkcsCertificateProfileToInitialize.ManagedDeviceCertificateStates != null && macOSPkcsCertificateProfileToInitialize.ManagedDeviceCertificateStates.CurrentPage != null)
                {
                    macOSPkcsCertificateProfileToInitialize.ManagedDeviceCertificateStates.AdditionalData = macOSPkcsCertificateProfileToInitialize.AdditionalData;

                    object nextPageLink;
                    macOSPkcsCertificateProfileToInitialize.AdditionalData.TryGetValue("managedDeviceCertificateStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        macOSPkcsCertificateProfileToInitialize.ManagedDeviceCertificateStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
