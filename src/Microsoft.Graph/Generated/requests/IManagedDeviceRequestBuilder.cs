// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IManagedDeviceRequestBuilder.
    /// </summary>
    public partial interface IManagedDeviceRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IManagedDeviceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IManagedDeviceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for DeviceCompliancePolicyStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeviceCompliancePolicyStatesCollectionRequestBuilder"/>.</returns>
        IManagedDeviceDeviceCompliancePolicyStatesCollectionRequestBuilder DeviceCompliancePolicyStates { get; }

        /// <summary>
        /// Gets the request builder for AssignmentFilterEvaluationStatusDetails.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceAssignmentFilterEvaluationStatusDetailsCollectionRequestBuilder"/>.</returns>
        IManagedDeviceAssignmentFilterEvaluationStatusDetailsCollectionRequestBuilder AssignmentFilterEvaluationStatusDetails { get; }

        /// <summary>
        /// Gets the request builder for DeviceConfigurationStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder"/>.</returns>
        IManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder DeviceConfigurationStates { get; }

        /// <summary>
        /// Gets the request builder for ManagedDeviceMobileAppConfigurationStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder"/>.</returns>
        IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder ManagedDeviceMobileAppConfigurationStates { get; }

        /// <summary>
        /// Gets the request builder for SecurityBaselineStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceSecurityBaselineStatesCollectionRequestBuilder"/>.</returns>
        IManagedDeviceSecurityBaselineStatesCollectionRequestBuilder SecurityBaselineStates { get; }

        /// <summary>
        /// Gets the request builder for DetectedApps.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder"/>.</returns>
        IManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder DetectedApps { get; }

        /// <summary>
        /// Gets the request builder for DeviceCategory.
        /// </summary>
        /// <returns>The <see cref="IDeviceCategoryRequestBuilder"/>.</returns>
        IDeviceCategoryRequestBuilder DeviceCategory { get; }

        /// <summary>
        /// Gets the request builder for LogCollectionRequests.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceLogCollectionRequestsCollectionRequestBuilder"/>.</returns>
        IManagedDeviceLogCollectionRequestsCollectionRequestBuilder LogCollectionRequests { get; }

        /// <summary>
        /// Gets the request builder for Users.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceUsersCollectionRequestBuilder"/>.</returns>
        IManagedDeviceUsersCollectionRequestBuilder Users { get; }

        /// <summary>
        /// Gets the request builder for WindowsProtectionState.
        /// </summary>
        /// <returns>The <see cref="IWindowsProtectionStateRequestBuilder"/>.</returns>
        IWindowsProtectionStateRequestBuilder WindowsProtectionState { get; }
    
        /// <summary>
        /// Gets the request builder for ManagedDeviceSendCustomNotificationToCompanyPortal.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceSendCustomNotificationToCompanyPortalRequestBuilder"/>.</returns>
        IManagedDeviceSendCustomNotificationToCompanyPortalRequestBuilder SendCustomNotificationToCompanyPortal(
            string notificationTitle,
            string notificationBody);

        /// <summary>
        /// Gets the request builder for ManagedDeviceOverrideComplianceState.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceOverrideComplianceStateRequestBuilder"/>.</returns>
        IManagedDeviceOverrideComplianceStateRequestBuilder OverrideComplianceState(
            AdministratorConfiguredDeviceComplianceState complianceState,
            string remediationUrl = null);

        /// <summary>
        /// Gets the request builder for ManagedDeviceBypassActivationLock.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceBypassActivationLockRequestBuilder"/>.</returns>
        IManagedDeviceBypassActivationLockRequestBuilder BypassActivationLock();

        /// <summary>
        /// Gets the request builder for ManagedDeviceCleanWindowsDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceCleanWindowsDeviceRequestBuilder"/>.</returns>
        IManagedDeviceCleanWindowsDeviceRequestBuilder CleanWindowsDevice(
            bool keepUserData);

        /// <summary>
        /// Gets the request builder for ManagedDeviceCreateDeviceLogCollectionRequest.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceCreateDeviceLogCollectionRequestRequestBuilder"/>.</returns>
        IManagedDeviceCreateDeviceLogCollectionRequestRequestBuilder CreateDeviceLogCollectionRequest(
            DeviceLogCollectionRequestObject templateType = null);

        /// <summary>
        /// Gets the request builder for ManagedDeviceDeleteUserFromSharedAppleDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeleteUserFromSharedAppleDeviceRequestBuilder"/>.</returns>
        IManagedDeviceDeleteUserFromSharedAppleDeviceRequestBuilder DeleteUserFromSharedAppleDevice(
            string userPrincipalName = null);

        /// <summary>
        /// Gets the request builder for ManagedDeviceDisableLostMode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDisableLostModeRequestBuilder"/>.</returns>
        IManagedDeviceDisableLostModeRequestBuilder DisableLostMode();

        /// <summary>
        /// Gets the request builder for ManagedDeviceEnableLostMode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceEnableLostModeRequestBuilder"/>.</returns>
        IManagedDeviceEnableLostModeRequestBuilder EnableLostMode(
            string message = null,
            string phoneNumber = null,
            string footer = null);

        /// <summary>
        /// Gets the request builder for ManagedDeviceLocateDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceLocateDeviceRequestBuilder"/>.</returns>
        IManagedDeviceLocateDeviceRequestBuilder LocateDevice();

        /// <summary>
        /// Gets the request builder for ManagedDeviceLogoutSharedAppleDeviceActiveUser.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceLogoutSharedAppleDeviceActiveUserRequestBuilder"/>.</returns>
        IManagedDeviceLogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser();

        /// <summary>
        /// Gets the request builder for ManagedDevicePlayLostModeSound.
        /// </summary>
        /// <returns>The <see cref="IManagedDevicePlayLostModeSoundRequestBuilder"/>.</returns>
        IManagedDevicePlayLostModeSoundRequestBuilder PlayLostModeSound();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRebootNow.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRebootNowRequestBuilder"/>.</returns>
        IManagedDeviceRebootNowRequestBuilder RebootNow();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRecoverPasscode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRecoverPasscodeRequestBuilder"/>.</returns>
        IManagedDeviceRecoverPasscodeRequestBuilder RecoverPasscode();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRemoteLock.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRemoteLockRequestBuilder"/>.</returns>
        IManagedDeviceRemoteLockRequestBuilder RemoteLock();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRequestRemoteAssistance.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRequestRemoteAssistanceRequestBuilder"/>.</returns>
        IManagedDeviceRequestRemoteAssistanceRequestBuilder RequestRemoteAssistance();

        /// <summary>
        /// Gets the request builder for ManagedDeviceResetPasscode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceResetPasscodeRequestBuilder"/>.</returns>
        IManagedDeviceResetPasscodeRequestBuilder ResetPasscode();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRetire.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRetireRequestBuilder"/>.</returns>
        IManagedDeviceRetireRequestBuilder Retire();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRevokeAppleVppLicenses.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRevokeAppleVppLicensesRequestBuilder"/>.</returns>
        IManagedDeviceRevokeAppleVppLicensesRequestBuilder RevokeAppleVppLicenses();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRotateBitLockerKeys.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRotateBitLockerKeysRequestBuilder"/>.</returns>
        IManagedDeviceRotateBitLockerKeysRequestBuilder RotateBitLockerKeys();

        /// <summary>
        /// Gets the request builder for ManagedDeviceRotateFileVaultKey.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRotateFileVaultKeyRequestBuilder"/>.</returns>
        IManagedDeviceRotateFileVaultKeyRequestBuilder RotateFileVaultKey();

        /// <summary>
        /// Gets the request builder for ManagedDeviceSetDeviceName.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceSetDeviceNameRequestBuilder"/>.</returns>
        IManagedDeviceSetDeviceNameRequestBuilder SetDeviceName(
            string deviceName = null);

        /// <summary>
        /// Gets the request builder for ManagedDeviceShutDown.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceShutDownRequestBuilder"/>.</returns>
        IManagedDeviceShutDownRequestBuilder ShutDown();

        /// <summary>
        /// Gets the request builder for ManagedDeviceSyncDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceSyncDeviceRequestBuilder"/>.</returns>
        IManagedDeviceSyncDeviceRequestBuilder SyncDevice();

        /// <summary>
        /// Gets the request builder for ManagedDeviceTriggerConfigurationManagerAction.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceTriggerConfigurationManagerActionRequestBuilder"/>.</returns>
        IManagedDeviceTriggerConfigurationManagerActionRequestBuilder TriggerConfigurationManagerAction(
            ConfigurationManagerAction configurationManagerAction);

        /// <summary>
        /// Gets the request builder for ManagedDeviceUpdateWindowsDeviceAccount.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceUpdateWindowsDeviceAccountRequestBuilder"/>.</returns>
        IManagedDeviceUpdateWindowsDeviceAccountRequestBuilder UpdateWindowsDeviceAccount(
            UpdateWindowsDeviceAccountActionParameter updateWindowsDeviceAccountActionParameter = null);

        /// <summary>
        /// Gets the request builder for ManagedDeviceWindowsDefenderScan.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceWindowsDefenderScanRequestBuilder"/>.</returns>
        IManagedDeviceWindowsDefenderScanRequestBuilder WindowsDefenderScan(
            bool quickScan);

        /// <summary>
        /// Gets the request builder for ManagedDeviceWindowsDefenderUpdateSignatures.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceWindowsDefenderUpdateSignaturesRequestBuilder"/>.</returns>
        IManagedDeviceWindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures();

        /// <summary>
        /// Gets the request builder for ManagedDeviceWipe.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceWipeRequestBuilder"/>.</returns>
        IManagedDeviceWipeRequestBuilder Wipe(
            bool? keepEnrollmentData = null,
            bool? keepUserData = null,
            string macOsUnlockCode = null,
            bool? useProtectedWipe = null);

        /// <summary>
        /// Gets the request builder for ManagedDeviceGetNonCompliantSettings.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceGetNonCompliantSettingsRequestBuilder"/>.</returns>
        IManagedDeviceGetNonCompliantSettingsRequestBuilder GetNonCompliantSettings();

        /// <summary>
        /// Gets the request builder for ManagedDeviceGetFileVaultKey.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceGetFileVaultKeyRequestBuilder"/>.</returns>
        IManagedDeviceGetFileVaultKeyRequestBuilder GetFileVaultKey();
    
    }
}
