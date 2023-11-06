// PermissionsGroup.cs
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
    public enum PermissionsGroup
    {
        [EnumMember(Value = "BACKUP_V2")]
        BACKUP_V2,

        [EnumMember(Value = "BASIC")]
        BASIC,

        [EnumMember(Value = "CLOUD_CLUSTER_ES")]
        CLOUD_CLUSTER_ES,

        [EnumMember(Value = "ENCRYPTION")]
        ENCRYPTION,

        [EnumMember(Value = "EXPORT_AND_RESTORE")]
        EXPORT_AND_RESTORE,

        [EnumMember(Value = "FILE_LEVEL_RECOVERY")]
        FILE_LEVEL_RECOVERY,

        [EnumMember(Value = "GROUP_UNSPECIFIED")]
        GROUP_UNSPECIFIED,

        [EnumMember(Value = "RECOVERY")]
        RECOVERY


    } // enum PermissionsGroup

} // namespace RubrikSecurityCloud.Types