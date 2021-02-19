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
    /// The type AndroidForWorkScepCertificateProfileRequest.
    /// </summary>
    public partial class AndroidForWorkScepCertificateProfileRequest : BaseRequest, IAndroidForWorkScepCertificateProfileRequest
    {
        /// <summary>
        /// Constructs a new AndroidForWorkScepCertificateProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidForWorkScepCertificateProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidForWorkScepCertificateProfile using POST.
        /// </summary>
        /// <param name="androidForWorkScepCertificateProfileToCreate">The AndroidForWorkScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkScepCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<AndroidForWorkScepCertificateProfile> CreateAsync(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<AndroidForWorkScepCertificateProfile>(androidForWorkScepCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AndroidForWorkScepCertificateProfile using POST and returns a <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidForWorkScepCertificateProfileToCreate">The AndroidForWorkScepCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidForWorkScepCertificateProfile>> CreateResponseAsync(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<AndroidForWorkScepCertificateProfile>(androidForWorkScepCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidForWorkScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<AndroidForWorkScepCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidForWorkScepCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AndroidForWorkScepCertificateProfile.
        /// </summary>
        /// <returns>The AndroidForWorkScepCertificateProfile.</returns>
        public System.Threading.Tasks.Task<AndroidForWorkScepCertificateProfile> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidForWorkScepCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkScepCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<AndroidForWorkScepCertificateProfile> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AndroidForWorkScepCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AndroidForWorkScepCertificateProfile and returns a <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidForWorkScepCertificateProfile>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AndroidForWorkScepCertificateProfile and returns a <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidForWorkScepCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<AndroidForWorkScepCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified AndroidForWorkScepCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidForWorkScepCertificateProfileToUpdate">The AndroidForWorkScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidForWorkScepCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<AndroidForWorkScepCertificateProfile> UpdateAsync(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AndroidForWorkScepCertificateProfile>(androidForWorkScepCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidForWorkScepCertificateProfile using PATCH and returns a <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidForWorkScepCertificateProfileToUpdate">The AndroidForWorkScepCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkScepCertificateProfile}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<AndroidForWorkScepCertificateProfile>> UpdateResponseAsync(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<AndroidForWorkScepCertificateProfile>(androidForWorkScepCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidForWorkScepCertificateProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidForWorkScepCertificateProfileRequest Expand(Expression<Func<AndroidForWorkScepCertificateProfile, object>> expandExpression)
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
        public IAndroidForWorkScepCertificateProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidForWorkScepCertificateProfileRequest Select(Expression<Func<AndroidForWorkScepCertificateProfile, object>> selectExpression)
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
        /// <param name="androidForWorkScepCertificateProfileToInitialize">The <see cref="AndroidForWorkScepCertificateProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidForWorkScepCertificateProfile androidForWorkScepCertificateProfileToInitialize)
        {

            if (androidForWorkScepCertificateProfileToInitialize != null && androidForWorkScepCertificateProfileToInitialize.AdditionalData != null)
            {

                if (androidForWorkScepCertificateProfileToInitialize.ManagedDeviceCertificateStates != null && androidForWorkScepCertificateProfileToInitialize.ManagedDeviceCertificateStates.CurrentPage != null)
                {
                    androidForWorkScepCertificateProfileToInitialize.ManagedDeviceCertificateStates.AdditionalData = androidForWorkScepCertificateProfileToInitialize.AdditionalData;

                    object nextPageLink;
                    androidForWorkScepCertificateProfileToInitialize.AdditionalData.TryGetValue("managedDeviceCertificateStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        androidForWorkScepCertificateProfileToInitialize.ManagedDeviceCertificateStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
