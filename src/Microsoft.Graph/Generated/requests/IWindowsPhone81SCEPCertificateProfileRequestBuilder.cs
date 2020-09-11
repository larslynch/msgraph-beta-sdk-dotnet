// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWindowsPhone81SCEPCertificateProfileRequestBuilder.
    /// </summary>
    public partial interface IWindowsPhone81SCEPCertificateProfileRequestBuilder : IWindowsPhone81CertificateProfileBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWindowsPhone81SCEPCertificateProfileRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWindowsPhone81SCEPCertificateProfileRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ManagedDeviceCertificateStates.
        /// </summary>
        /// <returns>The <see cref="IWindowsPhone81SCEPCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder"/>.</returns>
        IWindowsPhone81SCEPCertificateProfileManagedDeviceCertificateStatesCollectionRequestBuilder ManagedDeviceCertificateStates { get; }

        /// <summary>
        /// Gets the request builder for RootCertificate.
        /// </summary>
        /// <returns>The <see cref="IWindowsPhone81TrustedRootCertificateWithReferenceRequestBuilder"/>.</returns>
        IWindowsPhone81TrustedRootCertificateWithReferenceRequestBuilder RootCertificate { get; }
    
    }
}
