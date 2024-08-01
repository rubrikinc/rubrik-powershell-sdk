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

        [EnumMember(Value = "DATA_CENTER_CONSOLIDATION")]
        DATA_CENTER_CONSOLIDATION,

        [EnumMember(Value = "DATA_CENTER_IMMUTABILITY")]
        DATA_CENTER_IMMUTABILITY,

        [EnumMember(Value = "DATA_CENTER_KMS")]
        DATA_CENTER_KMS,

        [EnumMember(Value = "ENCRYPTION")]
        ENCRYPTION,

        [EnumMember(Value = "EXPORT_AND_RESTORE")]
        EXPORT_AND_RESTORE,

        [EnumMember(Value = "FILE_LEVEL_RECOVERY")]
        FILE_LEVEL_RECOVERY,

        [EnumMember(Value = "GROUP_UNSPECIFIED")]
        GROUP_UNSPECIFIED,

        [EnumMember(Value = "PRIVATE_ENDPOINTS")]
        PRIVATE_ENDPOINTS,

        [EnumMember(Value = "RECOVERY")]
        RECOVERY,

        [EnumMember(Value = "RSC_MANAGED_CLUSTER")]
        RSC_MANAGED_CLUSTER,

        [EnumMember(Value = "SAP_HANA_SS_BASIC")]
        SAP_HANA_SS_BASIC,

        [EnumMember(Value = "SAP_HANA_SS_RECOVERY")]
        SAP_HANA_SS_RECOVERY,

        [EnumMember(Value = "SNAPSHOT_PRIVATE_ACCESS")]
        SNAPSHOT_PRIVATE_ACCESS,

        [EnumMember(Value = "SQL_ARCHIVAL")]
        SQL_ARCHIVAL,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PermissionsGroup

} // namespace RubrikSecurityCloud.Types