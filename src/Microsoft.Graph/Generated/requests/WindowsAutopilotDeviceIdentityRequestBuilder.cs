// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WindowsAutopilotDeviceIdentityRequestBuilder.
    /// </summary>
    public partial class WindowsAutopilotDeviceIdentityRequestBuilder : EntityRequestBuilder, IWindowsAutopilotDeviceIdentityRequestBuilder
    {

        /// <summary>
        /// Constructs a new WindowsAutopilotDeviceIdentityRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WindowsAutopilotDeviceIdentityRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWindowsAutopilotDeviceIdentityRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWindowsAutopilotDeviceIdentityRequest Request(IEnumerable<Option> options)
        {
            return new WindowsAutopilotDeviceIdentityRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DeploymentProfile.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileWithReferenceRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeploymentProfileWithReferenceRequestBuilder DeploymentProfile
        {
            get
            {
                return new WindowsAutopilotDeploymentProfileWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("deploymentProfile"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IntendedDeploymentProfile.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileWithReferenceRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeploymentProfileWithReferenceRequestBuilder IntendedDeploymentProfile
        {
            get
            {
                return new WindowsAutopilotDeploymentProfileWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("intendedDeploymentProfile"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeviceIdentityAssignResourceAccountToDevice.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeviceIdentityAssignResourceAccountToDeviceRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeviceIdentityAssignResourceAccountToDeviceRequestBuilder AssignResourceAccountToDevice(
            string userPrincipalName = null,
            string addressableUserName = null,
            string resourceAccountName = null)
        {
            return new WindowsAutopilotDeviceIdentityAssignResourceAccountToDeviceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assignResourceAccountToDevice"),
                this.Client,
                userPrincipalName,
                addressableUserName,
                resourceAccountName);
        }

        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeviceIdentityAssignUserToDevice.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeviceIdentityAssignUserToDeviceRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeviceIdentityAssignUserToDeviceRequestBuilder AssignUserToDevice(
            string userPrincipalName = null,
            string addressableUserName = null)
        {
            return new WindowsAutopilotDeviceIdentityAssignUserToDeviceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.assignUserToDevice"),
                this.Client,
                userPrincipalName,
                addressableUserName);
        }

        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeviceIdentityUnassignResourceAccountFromDevice.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeviceIdentityUnassignResourceAccountFromDeviceRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeviceIdentityUnassignResourceAccountFromDeviceRequestBuilder UnassignResourceAccountFromDevice()
        {
            return new WindowsAutopilotDeviceIdentityUnassignResourceAccountFromDeviceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unassignResourceAccountFromDevice"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeviceIdentityUnassignUserFromDevice.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeviceIdentityUnassignUserFromDeviceRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeviceIdentityUnassignUserFromDeviceRequestBuilder UnassignUserFromDevice()
        {
            return new WindowsAutopilotDeviceIdentityUnassignUserFromDeviceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unassignUserFromDevice"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeviceIdentityUpdateDeviceProperties.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeviceIdentityUpdateDevicePropertiesRequestBuilder"/>.</returns>
        public IWindowsAutopilotDeviceIdentityUpdateDevicePropertiesRequestBuilder UpdateDeviceProperties(
            string userPrincipalName = null,
            string addressableUserName = null,
            string groupTag = null,
            string displayName = null)
        {
            return new WindowsAutopilotDeviceIdentityUpdateDevicePropertiesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.updateDeviceProperties"),
                this.Client,
                userPrincipalName,
                addressableUserName,
                groupTag,
                displayName);
        }
    
    }
}
