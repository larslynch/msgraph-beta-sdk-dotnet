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
    /// The type PrintRequest.
    /// </summary>
    public partial class PrintRequest : BaseRequest, IPrintRequest
    {
        /// <summary>
        /// Constructs a new PrintRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PrintRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Print using POST.
        /// </summary>
        /// <param name="printToCreate">The Print to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Print.</returns>
        public async System.Threading.Tasks.Task<Print> CreateAsync(Print printToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            var newEntity = await this.SendAsync<Print>(printToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Print using POST and returns a <see cref="GraphResponse{Print}"/> object.
        /// </summary>
        /// <param name="printToCreate">The Print to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Print}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Print>> CreateResponseAsync(Print printToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";
            return await this.SendAsyncWithGraphResponse<Print>(printToCreate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Print.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            await this.SendAsync<Print>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Print and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Print.
        /// </summary>
        /// <returns>The Print.</returns>
        public System.Threading.Tasks.Task<Print> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Print.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Print.</returns>
        public async System.Threading.Tasks.Task<Print> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Print>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Print and returns a <see cref="GraphResponse{Print}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Print}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Print>> GetResponseAsync()
        {
            return this.GetResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Print and returns a <see cref="GraphResponse{Print}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Print}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Print>> GetResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            return await this.SendAsyncWithGraphResponse<Print>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the specified Print using PATCH.
        /// </summary>
        /// <param name="printToUpdate">The Print to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Print.</returns>
        public async System.Threading.Tasks.Task<Print> UpdateAsync(Print printToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Print>(printToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Print using PATCH and returns a <see cref="GraphResponse{Print}"/> object.
        /// </summary>
        /// <param name="printToUpdate">The Print to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Print}"/> object of the request.</returns>
        public async System.Threading.Tasks.Task<GraphResponse<Print>> UpdateResponseAsync(Print printToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "PATCH";
            return await this.SendAsyncWithGraphResponse<Print>(printToUpdate, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPrintRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPrintRequest Expand(Expression<Func<Print, object>> expandExpression)
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
        public IPrintRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPrintRequest Select(Expression<Func<Print, object>> selectExpression)
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
        /// <param name="printToInitialize">The <see cref="Print"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Print printToInitialize)
        {

            if (printToInitialize != null && printToInitialize.AdditionalData != null)
            {

                if (printToInitialize.Connectors != null && printToInitialize.Connectors.CurrentPage != null)
                {
                    printToInitialize.Connectors.AdditionalData = printToInitialize.AdditionalData;

                    object nextPageLink;
                    printToInitialize.AdditionalData.TryGetValue("connectors@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        printToInitialize.Connectors.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (printToInitialize.Operations != null && printToInitialize.Operations.CurrentPage != null)
                {
                    printToInitialize.Operations.AdditionalData = printToInitialize.AdditionalData;

                    object nextPageLink;
                    printToInitialize.AdditionalData.TryGetValue("operations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        printToInitialize.Operations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (printToInitialize.Printers != null && printToInitialize.Printers.CurrentPage != null)
                {
                    printToInitialize.Printers.AdditionalData = printToInitialize.AdditionalData;

                    object nextPageLink;
                    printToInitialize.AdditionalData.TryGetValue("printers@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        printToInitialize.Printers.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (printToInitialize.PrinterShares != null && printToInitialize.PrinterShares.CurrentPage != null)
                {
                    printToInitialize.PrinterShares.AdditionalData = printToInitialize.AdditionalData;

                    object nextPageLink;
                    printToInitialize.AdditionalData.TryGetValue("printerShares@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        printToInitialize.PrinterShares.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (printToInitialize.Services != null && printToInitialize.Services.CurrentPage != null)
                {
                    printToInitialize.Services.AdditionalData = printToInitialize.AdditionalData;

                    object nextPageLink;
                    printToInitialize.AdditionalData.TryGetValue("services@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        printToInitialize.Services.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (printToInitialize.Shares != null && printToInitialize.Shares.CurrentPage != null)
                {
                    printToInitialize.Shares.AdditionalData = printToInitialize.AdditionalData;

                    object nextPageLink;
                    printToInitialize.AdditionalData.TryGetValue("shares@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        printToInitialize.Shares.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (printToInitialize.TaskDefinitions != null && printToInitialize.TaskDefinitions.CurrentPage != null)
                {
                    printToInitialize.TaskDefinitions.AdditionalData = printToInitialize.AdditionalData;

                    object nextPageLink;
                    printToInitialize.AdditionalData.TryGetValue("taskDefinitions@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        printToInitialize.TaskDefinitions.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
