// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type TagWithReferenceRequest.
    /// </summary>
    public partial class TagWithReferenceRequest : Microsoft.Graph.BaseRequest, ITagWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new TagWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TagWithReferenceRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified Tag.
        /// </summary>
        /// <returns>The Tag.</returns>
        public System.Threading.Tasks.Task<Tag> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Tag.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Tag.</returns>
        public async System.Threading.Tasks.Task<Tag> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Tag>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified Tag using POST.
        /// </summary>
        /// <param name="tagToCreate">The Tag to create.</param>
        /// <returns>The created Tag.</returns>
        public System.Threading.Tasks.Task<Tag> CreateAsync(Tag tagToCreate)
        {
            return this.CreateAsync(tagToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Tag using POST.
        /// </summary>
        /// <param name="tagToCreate">The Tag to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Tag.</returns>
        public async System.Threading.Tasks.Task<Tag> CreateAsync(Tag tagToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Tag>(tagToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified Tag using PATCH.
        /// </summary>
        /// <param name="tagToUpdate">The Tag to update.</param>
        /// <returns>The updated Tag.</returns>
        public System.Threading.Tasks.Task<Tag> UpdateAsync(Tag tagToUpdate)
        {
            return this.UpdateAsync(tagToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Tag using PATCH.
        /// </summary>
        /// <param name="tagToUpdate">The Tag to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Tag.</returns>
        public async System.Threading.Tasks.Task<Tag> UpdateAsync(Tag tagToUpdate, CancellationToken cancellationToken)
        {
			if (tagToUpdate.AdditionalData != null)
			{
				if (tagToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
					tagToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
				{
					throw new Microsoft.Graph.ClientException(
						new Microsoft.Graph.Error
						{
							Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, tagToUpdate.GetType().Name)
						});
				}
			}
            if (tagToUpdate.AdditionalData != null)
            {
                if (tagToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
                    tagToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
                {
                    throw new Microsoft.Graph.ClientException(
                        new Microsoft.Graph.Error
                        {
                            Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, tagToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Tag>(tagToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified Tag.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Tag.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Tag>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITagWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITagWithReferenceRequest Expand(Expression<Func<Tag, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ITagWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITagWithReferenceRequest Select(Expression<Func<Tag, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

    }
}
