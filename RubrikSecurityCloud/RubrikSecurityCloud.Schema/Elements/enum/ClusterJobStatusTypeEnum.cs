// ClusterJobStatusTypeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:04.
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
    public enum ClusterJobStatusTypeEnum
    {
        [EnumMember(Value = "DownloadPackageFailed")]
        DOWNLOAD_PACKAGE_FAILED,

        [EnumMember(Value = "DownloadingPackage")]
        DOWNLOADING_PACKAGE,

        [EnumMember(Value = "FailedToInitiateUpgrade")]
        FAILED_TO_INITIATE_UPGRADE,

        [EnumMember(Value = "PreCheckFailureError")]
        PRE_CHECK_FAILURE_ERROR,

        [EnumMember(Value = "PreCheckFailureWarning")]
        PRE_CHECK_FAILURE_WARNING,

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

        [EnumMember(Value = "Unknown")]
        UNKNOWN,

        [EnumMember(Value = "UpToDate")]
        UP_TO_DATE,

        [EnumMember(Value = "UpgradeFailed")]
        UPGRADE_FAILED,

        [EnumMember(Value = "Upgrading")]
        UPGRADING


    } // enum ClusterJobStatusTypeEnum

} // namespace Rubrik.SecurityCloud.Types