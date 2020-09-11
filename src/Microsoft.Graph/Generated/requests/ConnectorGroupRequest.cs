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
    /// The type ConnectorGroupRequest.
    /// </summary>
    public partial class ConnectorGroupRequest : BaseRequest, IConnectorGroupRequest
    {
        /// <summary>
        /// Constructs a new ConnectorGroupRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ConnectorGroupRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ConnectorGroup using POST.
        /// </summary>
        /// <param name="connectorGroupToCreate">The ConnectorGroup to create.</param>
        /// <returns>The created ConnectorGroup.</returns>
        public System.Threading.Tasks.Task<ConnectorGroup> CreateAsync(ConnectorGroup connectorGroupToCreate)
        {
            return this.CreateAsync(connectorGroupToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified ConnectorGroup using POST.
        /// </summary>
        /// <param name="connectorGroupToCreate">The ConnectorGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConnectorGroup.</returns>
        public async System.Threading.Tasks.Task<ConnectorGroup> CreateAsync(ConnectorGroup connectorGroupToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<ConnectorGroup>(connectorGroupToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified ConnectorGroup.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified ConnectorGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<ConnectorGroup>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified ConnectorGroup.
        /// </summary>
        /// <returns>The ConnectorGroup.</returns>
        public System.Threading.Tasks.Task<ConnectorGroup> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified ConnectorGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConnectorGroup.</returns>
        public async System.Threading.Tasks.Task<ConnectorGroup> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<ConnectorGroup>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified ConnectorGroup using PATCH.
        /// </summary>
        /// <param name="connectorGroupToUpdate">The ConnectorGroup to update.</param>
        /// <returns>The updated ConnectorGroup.</returns>
        public System.Threading.Tasks.Task<ConnectorGroup> UpdateAsync(ConnectorGroup connectorGroupToUpdate)
        {
            return this.UpdateAsync(connectorGroupToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified ConnectorGroup using PATCH.
        /// </summary>
        /// <param name="connectorGroupToUpdate">The ConnectorGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConnectorGroup.</returns>
        public async System.Threading.Tasks.Task<ConnectorGroup> UpdateAsync(ConnectorGroup connectorGroupToUpdate, CancellationToken cancellationToken)
        {
			if (connectorGroupToUpdate.AdditionalData != null)
			{
				if (connectorGroupToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
					connectorGroupToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
				{
					throw new ClientException(
						new Error
						{
							Code = GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, connectorGroupToUpdate.GetType().Name)
						});
				}
			}
            if (connectorGroupToUpdate.AdditionalData != null)
            {
                if (connectorGroupToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    connectorGroupToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, connectorGroupToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<ConnectorGroup>(connectorGroupToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConnectorGroupRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IConnectorGroupRequest Expand(Expression<Func<ConnectorGroup, object>> expandExpression)
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
        public IConnectorGroupRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IConnectorGroupRequest Select(Expression<Func<ConnectorGroup, object>> selectExpression)
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
        /// <param name="connectorGroupToInitialize">The <see cref="ConnectorGroup"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ConnectorGroup connectorGroupToInitialize)
        {

            if (connectorGroupToInitialize != null && connectorGroupToInitialize.AdditionalData != null)
            {

                if (connectorGroupToInitialize.Applications != null && connectorGroupToInitialize.Applications.CurrentPage != null)
                {
                    connectorGroupToInitialize.Applications.AdditionalData = connectorGroupToInitialize.AdditionalData;

                    object nextPageLink;
                    connectorGroupToInitialize.AdditionalData.TryGetValue("applications@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        connectorGroupToInitialize.Applications.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (connectorGroupToInitialize.Members != null && connectorGroupToInitialize.Members.CurrentPage != null)
                {
                    connectorGroupToInitialize.Members.AdditionalData = connectorGroupToInitialize.AdditionalData;

                    object nextPageLink;
                    connectorGroupToInitialize.AdditionalData.TryGetValue("members@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        connectorGroupToInitialize.Members.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
