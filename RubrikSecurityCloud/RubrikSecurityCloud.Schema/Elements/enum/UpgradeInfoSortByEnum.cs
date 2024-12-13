// UpgradeInfoSortByEnum.cs
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

namespace RubrikSecurityCloud.Types
{
    public enum UpgradeInfoSortByEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

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

} // namespace RubrikSecurityCloud.Types