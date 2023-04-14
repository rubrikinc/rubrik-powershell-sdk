// CdmClusterStatusTypeEnum.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum CdmClusterStatusTypeEnum
    {
        [EnumMember(Value = "Disconnected")]
        DISCONNECTED,

        [EnumMember(Value = "DownloadPackageFailed")]
        DOWNLOAD_PACKAGE_FAILED,

        [EnumMember(Value = "DownloadingPackage")]
        DOWNLOADING_PACKAGE,

        [EnumMember(Value = "FailedToInitiateUpgrade")]
        FAILED_TO_INITIATE_UPGRADE,

        [EnumMember(Value = "OnOldRelease")]
        ON_OLD_RELEASE,

        [EnumMember(Value = "PrechecksFailureError")]
        PRECHECKS_FAILURE_ERROR,

        [EnumMember(Value = "PrechecksFailureWarning")]
        PRECHECKS_FAILURE_WARNING,

        [EnumMember(Value = "PrechecksRunning")]
        PRECHECKS_RUNNING,

        [EnumMember(Value = "ReadyForDownload")]
        READY_FOR_DOWNLOAD,

        [EnumMember(Value = "ReadyForUpgrade")]
        READY_FOR_UPGRADE,

        [EnumMember(Value = "ResumingUpgrade")]
        RESUMING_UPGRADE,

        [EnumMember(Value = "RollbackFailed")]
        ROLLBACK_FAILED,

        [EnumMember(Value = "RollingBackUpgrade")]
        ROLLING_BACK_UPGRADE,

        [EnumMember(Value = "Stable")]
        STABLE,

        [EnumMember(Value = "StableWithUpgradeInfo")]
        STABLE_WITH_UPGRADE_INFO,

        [EnumMember(Value = "Unknown")]
        UNKNOWN,

        [EnumMember(Value = "UpgradeFailed")]
        UPGRADE_FAILED,

        [EnumMember(Value = "UpgradeRecommended")]
        UPGRADE_RECOMMENDED,

        [EnumMember(Value = "UpgradeScheduled")]
        UPGRADE_SCHEDULED,

        [EnumMember(Value = "UpgradeScheduledWithWarning")]
        UPGRADE_SCHEDULED_WITH_WARNING,

        [EnumMember(Value = "Upgrading")]
        UPGRADING


    } // enum CdmClusterStatusTypeEnum

} // namespace Rubrik.SecurityCloud.Types