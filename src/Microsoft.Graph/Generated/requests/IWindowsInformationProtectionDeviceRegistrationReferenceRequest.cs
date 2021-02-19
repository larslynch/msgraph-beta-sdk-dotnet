// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWindowsInformationProtectionDeviceRegistrationReferenceRequest.
    /// </summary>
    public partial interface IWindowsInformationProtectionDeviceRegistrationReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Deletes the specified WindowsInformationProtectionDeviceRegistration reference.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsInformationProtectionDeviceRegistration reference and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Puts the specified WindowsInformationProtectionDeviceRegistration reference.
        /// </summary>
        /// <param name="id">The WindowsInformationProtectionDeviceRegistration reference reference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task PutAsync(string id, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Puts the specified WindowsInformationProtectionDeviceRegistration reference and returns a <see cref="GraphResponse"/> object
        /// </summary>
        /// <param name="id">The WindowsInformationProtectionDeviceRegistration reference reference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> PutResponseAsync(string id, CancellationToken cancellationToken = default(CancellationToken));
    }
}
