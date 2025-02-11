// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Sign In.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SignIn : Entity
    {
    
		///<summary>
		/// The SignIn constructor
		///</summary>
        public SignIn()
        {
            this.ODataType = "microsoft.graph.signIn";
        }
	
        /// <summary>
        /// Gets or sets alternate sign in name.
        /// The alternate sign-in identity whenever you use phone number to sign-in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alternateSignInName", Required = Newtonsoft.Json.Required.Default)]
        public string AlternateSignInName { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// The application name displayed in the Azure Portal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// The application identifier in Azure Active Directory.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appId", Required = Newtonsoft.Json.Required.Default)]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets applied conditional access policies.
        /// A list of conditional access policies that are triggered by the corresponding sign-in activity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliedConditionalAccessPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets authentication details.
        /// The result of the authentication attempt and additional details on the authentication method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationDetails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AuthenticationDetail> AuthenticationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets authentication methods used.
        /// The authentication methods used. Possible values: SMS, Authenticator App, App Verification code, Password, FIDO, PTA, or PHS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethodsUsed", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AuthenticationMethodsUsed { get; set; }
    
        /// <summary>
        /// Gets or sets authentication processing details.
        /// Additional authentication processing details, such as the agent name in case of PTA/PHS or Server/farm name in case of federated authentication.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationProcessingDetails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValue> AuthenticationProcessingDetails { get; set; }
    
        /// <summary>
        /// Gets or sets authentication requirement.
        /// This holds the highest level of authentication needed through all the sign-in steps, for sign-in to succeed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationRequirement", Required = Newtonsoft.Json.Required.Default)]
        public string AuthenticationRequirement { get; set; }
    
        /// <summary>
        /// Gets or sets authentication requirement policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationRequirementPolicies", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AuthenticationRequirementPolicy> AuthenticationRequirementPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets client app used.
        /// The legacy client used for sign-in activity. For example, Browser, Exchange Active Sync,Modern clients, IMAP, MAPI, SMTP, or POP.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientAppUsed", Required = Newtonsoft.Json.Required.Default)]
        public string ClientAppUsed { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access status.
        /// The status of the conditional access policy triggered. Possible values: success, failure, notApplied, or unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditionalAccessStatus", Required = Newtonsoft.Json.Required.Default)]
        public ConditionalAccessStatus? ConditionalAccessStatus { get; set; }
    
        /// <summary>
        /// Gets or sets correlation id.
        /// The identifier that's sent from the client when sign-in is initiated. This is used for troubleshooting the corresponding sign-in activity when calling for support.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "correlationId", Required = Newtonsoft.Json.Required.Default)]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time the sign-in was initiated. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device detail.
        /// The device information from where the sign-in occurred. Includes information such as deviceId, OS, and browser.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceDetail", Required = Newtonsoft.Json.Required.Default)]
        public DeviceDetail DeviceDetail { get; set; }
    
        /// <summary>
        /// Gets or sets flagged for review.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "flaggedForReview", Required = Newtonsoft.Json.Required.Default)]
        public bool? FlaggedForReview { get; set; }
    
        /// <summary>
        /// Gets or sets home tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homeTenantId", Required = Newtonsoft.Json.Required.Default)]
        public string HomeTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets ip address.
        /// The IP address of the client from where the sign-in occurred.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipAddress", Required = Newtonsoft.Json.Required.Default)]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets ip address from resource provider.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ipAddressFromResourceProvider", Required = Newtonsoft.Json.Required.Default)]
        public string IpAddressFromResourceProvider { get; set; }
    
        /// <summary>
        /// Gets or sets is interactive.
        /// Indicates whether a sign-in is interactive or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isInteractive", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsInteractive { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// The city, state, and 2 letter country code from where the sign-in occurred.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "location", Required = Newtonsoft.Json.Required.Default)]
        public SignInLocation Location { get; set; }
    
        /// <summary>
        /// Gets or sets mfa detail.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mfaDetail", Required = Newtonsoft.Json.Required.Default)]
        public MfaDetail MfaDetail { get; set; }
    
        /// <summary>
        /// Gets or sets network location details.
        /// The network location details, such as IP address, location of the sign-in, the type of network used, and its names. Possible values: Named Netowrk, Extranet, Intranet, or Trusted Network.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkLocationDetails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<NetworkLocationDetail> NetworkLocationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets original request id.
        /// The request identifier of the first request in the authentication sequence.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "originalRequestId", Required = Newtonsoft.Json.Required.Default)]
        public string OriginalRequestId { get; set; }
    
        /// <summary>
        /// Gets or sets processing time in milliseconds.
        /// The request processing time in milliseconds in AD STS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "processingTimeInMilliseconds", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ProcessingTimeInMilliseconds { get; set; }
    
        /// <summary>
        /// Gets or sets resource display name.
        /// The name of the resource that the user signed in to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// The identifier of the resource that the user signed in to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceId", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets resource tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceTenantId", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets risk detail.
        /// The reason behind a specific state of a risky user, sign-in, or a risk event. Possible values: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, or unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far. Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskDetail", Required = Newtonsoft.Json.Required.Default)]
        public RiskDetail? RiskDetail { get; set; }
    
        /// <summary>
        /// Gets or sets risk event types.
        /// The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskEventTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<RiskEventType> RiskEventTypes { get; set; }
    
        /// <summary>
        /// Gets or sets risk event types_v2.
        /// The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskEventTypes_v2", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RiskEventTypes_v2 { get; set; }
    
        /// <summary>
        /// Gets or sets risk level aggregated.
        /// The aggregated risk level. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskLevelAggregated", Required = Newtonsoft.Json.Required.Default)]
        public RiskLevel? RiskLevelAggregated { get; set; }
    
        /// <summary>
        /// Gets or sets risk level during sign in.
        /// The risk level during sign-in. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskLevelDuringSignIn", Required = Newtonsoft.Json.Required.Default)]
        public RiskLevel? RiskLevelDuringSignIn { get; set; }
    
        /// <summary>
        /// Gets or sets risk state.
        /// The risk state of a risky user, sign-in, or a risk event. Possible values: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, or unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "riskState", Required = Newtonsoft.Json.Required.Default)]
        public RiskState? RiskState { get; set; }
    
        /// <summary>
        /// Gets or sets service principal id.
        /// The application identifier used for sign-in. This field is populated when you are signing in using an application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePrincipalId", Required = Newtonsoft.Json.Required.Default)]
        public string ServicePrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets service principal name.
        /// The application name used for sign-in. This field is populated when you are signing in using an application.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string ServicePrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets sign in event types.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signInEventTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SignInEventTypes { get; set; }
    
        /// <summary>
        /// Gets or sets sign in identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signInIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string SignInIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets sign in identifier type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signInIdentifierType", Required = Newtonsoft.Json.Required.Default)]
        public SignInIdentifierType? SignInIdentifierType { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The sign-in status. Includes the error code and description of the error (in case of a sign-in failure).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public SignInStatus Status { get; set; }
    
        /// <summary>
        /// Gets or sets token issuer name.
        /// The name of the identity provider. For example, sts.microsoft.com.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenIssuerName", Required = Newtonsoft.Json.Required.Default)]
        public string TokenIssuerName { get; set; }
    
        /// <summary>
        /// Gets or sets token issuer type.
        /// The type of identity provider. Possible values: AzureAD, ADFederationServices, or UnknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tokenIssuerType", Required = Newtonsoft.Json.Required.Default)]
        public TokenIssuerType? TokenIssuerType { get; set; }
    
        /// <summary>
        /// Gets or sets user agent.
        /// The user agent information related to sign-in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAgent", Required = Newtonsoft.Json.Required.Default)]
        public string UserAgent { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// The display name of the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The identifier of the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userId", Required = Newtonsoft.Json.Required.Default)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The UPN of the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets user type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userType", Required = Newtonsoft.Json.Required.Default)]
        public SignInUserType? UserType { get; set; }
    
    }
}

