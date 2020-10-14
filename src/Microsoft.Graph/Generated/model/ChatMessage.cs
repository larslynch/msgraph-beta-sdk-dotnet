// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Chat Message.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ChatMessage : Entity
    {
    
		///<summary>
		/// The ChatMessage constructor
		///</summary>
        public ChatMessage()
        {
            this.ODataType = "microsoft.graph.chatMessage";
        }
	
        /// <summary>
        /// Gets or sets attachments.
        /// Attached files. Attachments are currently read-only – sending attachments is not supported.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attachments", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ChatMessageAttachment> Attachments { get; set; }
    
        /// <summary>
        /// Gets or sets body.
        /// Plaintext/HTML representation of the content of the chat message. Representation is specified by the contentType inside the body. The content is always in HTML if the chat message contains a chatMessageMention.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "body", Required = Newtonsoft.Json.Required.Default)]
        public ItemBody Body { get; set; }
    
        /// <summary>
        /// Gets or sets channel identity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "channelIdentity", Required = Newtonsoft.Json.Required.Default)]
        public ChannelIdentity ChannelIdentity { get; set; }
    
        /// <summary>
        /// Gets or sets chat id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "chatId", Required = Newtonsoft.Json.Required.Default)]
        public string ChatId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Read only. Timestamp of when the chat message was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deleted date time.
        /// Read only. Timestamp at which the chat message was deleted, or null if not deleted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deletedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DeletedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets etag.
        /// Read-only. Version number of the chat message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "etag", Required = Newtonsoft.Json.Required.Default)]
        public string Etag { get; set; }
    
        /// <summary>
        /// Gets or sets from.
        /// Read only. Details of the sender of the chat message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "from", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet From { get; set; }
    
        /// <summary>
        /// Gets or sets importance.
        /// The importance of the chat message. The possible values are: normal, high, urgent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "importance", Required = Newtonsoft.Json.Required.Default)]
        public ChatMessageImportance? Importance { get; set; }
    
        /// <summary>
        /// Gets or sets last edited date time.
        /// Read only. Timestamp when edits to the chat message were made. Triggers an 'Edited' flag in the Microsoft Teams UI. If no edits are made the value is null.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastEditedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastEditedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Read only. Timestamp when the chat message is created (initial setting) or edited, including when a reaction is added or removed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets locale.
        /// Locale of the chat message set by the client.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locale", Required = Newtonsoft.Json.Required.Default)]
        public string Locale { get; set; }
    
        /// <summary>
        /// Gets or sets mentions.
        /// List of entities mentioned in the chat message. Currently supports user, bot, team, channel.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mentions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ChatMessageMention> Mentions { get; set; }
    
        /// <summary>
        /// Gets or sets message type.
        /// The type of chat message. The possible values are: message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messageType", Required = Newtonsoft.Json.Required.Default)]
        public ChatMessageType? MessageType { get; set; }
    
        /// <summary>
        /// Gets or sets policy violation.
        /// Defines the properties of a policy violation set by a data loss prevention (DLP) application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "policyViolation", Required = Newtonsoft.Json.Required.Default)]
        public ChatMessagePolicyViolation PolicyViolation { get; set; }
    
        /// <summary>
        /// Gets or sets reactions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reactions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ChatMessageReaction> Reactions { get; set; }
    
        /// <summary>
        /// Gets or sets reply to id.
        /// Read-only. Id of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels not chats)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replyToId", Required = Newtonsoft.Json.Required.Default)]
        public string ReplyToId { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The subject of the chat message, in plaintext.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "subject", Required = Newtonsoft.Json.Required.Default)]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets summary.
        /// Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "summary", Required = Newtonsoft.Json.Required.Default)]
        public string Summary { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "webUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets hosted contents.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hostedContents", Required = Newtonsoft.Json.Required.Default)]
        public IChatMessageHostedContentsCollectionPage HostedContents { get; set; }
    
        /// <summary>
        /// Gets or sets replies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "replies", Required = Newtonsoft.Json.Required.Default)]
        public IChatMessageRepliesCollectionPage Replies { get; set; }
    
    }
}

