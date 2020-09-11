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
    /// The interface IUserExperienceAnalyticsRegressionSummaryRequestBuilder.
    /// </summary>
    public partial interface IUserExperienceAnalyticsRegressionSummaryRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IUserExperienceAnalyticsRegressionSummaryRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IUserExperienceAnalyticsRegressionSummaryRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ManufacturerRegression.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsRegressionSummaryManufacturerRegressionCollectionRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsRegressionSummaryManufacturerRegressionCollectionRequestBuilder ManufacturerRegression { get; }

        /// <summary>
        /// Gets the request builder for ModelRegression.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsRegressionSummaryModelRegressionCollectionRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsRegressionSummaryModelRegressionCollectionRequestBuilder ModelRegression { get; }

        /// <summary>
        /// Gets the request builder for OperatingSystemRegression.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsRegressionSummaryOperatingSystemRegressionCollectionRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsRegressionSummaryOperatingSystemRegressionCollectionRequestBuilder OperatingSystemRegression { get; }
    
        /// <summary>
        /// Gets the request builder for UserExperienceAnalyticsRegressionSummarySummarizeDeviceRegressionPerformance.
        /// </summary>
        /// <returns>The <see cref="IUserExperienceAnalyticsRegressionSummarySummarizeDeviceRegressionPerformanceRequestBuilder"/>.</returns>
        IUserExperienceAnalyticsRegressionSummarySummarizeDeviceRegressionPerformanceRequestBuilder SummarizeDeviceRegressionPerformance(
            UserExperienceAnalyticsSummarizedBy summarizeBy);
    
    }
}
