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
    /// The interface IDeviceHealthScriptRequestBuilder.
    /// </summary>
    public partial interface IDeviceHealthScriptRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceHealthScriptRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceHealthScriptRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptAssignmentsCollectionRequestBuilder"/>.</returns>
        IDeviceHealthScriptAssignmentsCollectionRequestBuilder Assignments { get; }

        /// <summary>
        /// Gets the request builder for DeviceRunStates.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptDeviceRunStatesCollectionRequestBuilder"/>.</returns>
        IDeviceHealthScriptDeviceRunStatesCollectionRequestBuilder DeviceRunStates { get; }

        /// <summary>
        /// Gets the request builder for RunSummary.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptRunSummaryRequestBuilder"/>.</returns>
        IDeviceHealthScriptRunSummaryRequestBuilder RunSummary { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceHealthScriptAssign.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptAssignRequestBuilder"/>.</returns>
        IDeviceHealthScriptAssignRequestBuilder Assign(
            IEnumerable<DeviceHealthScriptAssignment> deviceHealthScriptAssignments = null);

        /// <summary>
        /// Gets the request builder for DeviceHealthScriptGetGlobalScriptHighestAvailableVersion.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptGetGlobalScriptHighestAvailableVersionRequestBuilder"/>.</returns>
        IDeviceHealthScriptGetGlobalScriptHighestAvailableVersionRequestBuilder GetGlobalScriptHighestAvailableVersion();

        /// <summary>
        /// Gets the request builder for DeviceHealthScriptUpdateGlobalScript.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptUpdateGlobalScriptRequestBuilder"/>.</returns>
        IDeviceHealthScriptUpdateGlobalScriptRequestBuilder UpdateGlobalScript(
            string version = null);

        /// <summary>
        /// Gets the request builder for DeviceHealthScriptGetRemediationHistory.
        /// </summary>
        /// <returns>The <see cref="IDeviceHealthScriptGetRemediationHistoryRequestBuilder"/>.</returns>
        IDeviceHealthScriptGetRemediationHistoryRequestBuilder GetRemediationHistory();
    
    }
}
