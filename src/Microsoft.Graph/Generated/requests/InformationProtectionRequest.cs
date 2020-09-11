// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type InformationProtectionRequest.
    /// </summary>
    public partial class InformationProtectionRequest : BaseRequest, IInformationProtectionRequest
    {
        /// <summary>
        /// Constructs a new InformationProtectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public InformationProtectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified InformationProtection using POST.
        /// </summary>
        /// <param name="informationProtectionToCreate">The InformationProtection to create.</param>
        /// <returns>The created InformationProtection.</returns>
        public System.Threading.Tasks.Task<InformationProtection> CreateAsync(InformationProtection informationProtectionToCreate)
        {
            return this.CreateAsync(informationProtectionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified InformationProtection using POST.
        /// </summary>
        /// <param name="informationProtectionToCreate">The InformationProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created InformationProtection.</returns>
        public async System.Threading.Tasks.Task<InformationProtection> CreateAsync(InformationProtection informationProtectionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<InformationProtection>(informationProtectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified InformationProtection.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified InformationProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<InformationProtection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified InformationProtection.
        /// </summary>
        /// <returns>The InformationProtection.</returns>
        public System.Threading.Tasks.Task<InformationProtection> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified InformationProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The InformationProtection.</returns>
        public async System.Threading.Tasks.Task<InformationProtection> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<InformationProtection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified InformationProtection using PATCH.
        /// </summary>
        /// <param name="informationProtectionToUpdate">The InformationProtection to update.</param>
        /// <returns>The updated InformationProtection.</returns>
        public System.Threading.Tasks.Task<InformationProtection> UpdateAsync(InformationProtection informationProtectionToUpdate)
        {
            return this.UpdateAsync(informationProtectionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified InformationProtection using PATCH.
        /// </summary>
        /// <param name="informationProtectionToUpdate">The InformationProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated InformationProtection.</returns>
        public async System.Threading.Tasks.Task<InformationProtection> UpdateAsync(InformationProtection informationProtectionToUpdate, CancellationToken cancellationToken)
        {
			if (informationProtectionToUpdate.AdditionalData != null)
			{
				if (informationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					informationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, informationProtectionToUpdate.GetType().Name)
						});
				}
			}
            if (informationProtectionToUpdate.AdditionalData != null)
            {
                if (informationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    informationProtectionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, informationProtectionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<InformationProtection>(informationProtectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IInformationProtectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IInformationProtectionRequest Expand(Expression<Func<InformationProtection, object>> expandExpression)
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
        public IInformationProtectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IInformationProtectionRequest Select(Expression<Func<InformationProtection, object>> selectExpression)
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
        /// <param name="informationProtectionToInitialize">The <see cref="InformationProtection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(InformationProtection informationProtectionToInitialize)
        {

            if (informationProtectionToInitialize != null && informationProtectionToInitialize.AdditionalData != null)
            {

                if (informationProtectionToInitialize.DataLossPreventionPolicies != null && informationProtectionToInitialize.DataLossPreventionPolicies.CurrentPage != null)
                {
                    informationProtectionToInitialize.DataLossPreventionPolicies.AdditionalData = informationProtectionToInitialize.AdditionalData;

                    object nextPageLink;
                    informationProtectionToInitialize.AdditionalData.TryGetValue("dataLossPreventionPolicies@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        informationProtectionToInitialize.DataLossPreventionPolicies.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (informationProtectionToInitialize.SensitivityLabels != null && informationProtectionToInitialize.SensitivityLabels.CurrentPage != null)
                {
                    informationProtectionToInitialize.SensitivityLabels.AdditionalData = informationProtectionToInitialize.AdditionalData;

                    object nextPageLink;
                    informationProtectionToInitialize.AdditionalData.TryGetValue("sensitivityLabels@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        informationProtectionToInitialize.SensitivityLabels.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (informationProtectionToInitialize.ThreatAssessmentRequests != null && informationProtectionToInitialize.ThreatAssessmentRequests.CurrentPage != null)
                {
                    informationProtectionToInitialize.ThreatAssessmentRequests.AdditionalData = informationProtectionToInitialize.AdditionalData;

                    object nextPageLink;
                    informationProtectionToInitialize.AdditionalData.TryGetValue("threatAssessmentRequests@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        informationProtectionToInitialize.ThreatAssessmentRequests.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
