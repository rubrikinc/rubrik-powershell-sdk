// UpgradeInfoSortByEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:21.
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
    public enum UpgradeInfoSortByEnum
    {
        [EnumMember(Value = "ClusterJobStatus")]
        CLUSTER_JOB_STATUS,

        [EnumMember(Value = "ClusterLocation")]
        CLUSTER_LOCATION,

        [EnumMember(Value = "ClusterName")]
        CLUSTER_NAME,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "DownloadedVersion")]
        DOWNLOADED_VERSION,

        [EnumMember(Value = "InstalledVersion")]
        INSTALLED_VERSION,

        [EnumMember(Value = "RegisteredAt")]
        REGISTERED_AT,

        [EnumMember(Value = "VersionStatus")]
        VERSION_STATUS


    } // enum UpgradeInfoSortByEnum

} // namespace Rubrik.SecurityCloud.Types