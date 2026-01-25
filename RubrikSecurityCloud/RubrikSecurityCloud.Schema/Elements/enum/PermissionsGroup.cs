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
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AKS_CUSTOM_PRIVATE_DNS_ZONE")]
        AKS_CUSTOM_PRIVATE_DNS_ZONE,

        [EnumMember(Value = "AUTOMATED_NETWORKING_SETUP")]
        AUTOMATED_NETWORKING_SETUP,

        [EnumMember(Value = "BACKUP_V2")]
        BACKUP_V2,

        [EnumMember(Value = "BASIC")]
        BASIC,

        [EnumMember(Value = "CLOUD_CLUSTER_ES")]
        CLOUD_CLUSTER_ES,

        [EnumMember(Value = "CUSTOMER_HOSTED_LOGGING")]
        CUSTOMER_HOSTED_LOGGING,

        [EnumMember(Value = "CUSTOMER_MANAGED_BASIC")]
        CUSTOMER_MANAGED_BASIC,

        [EnumMember(Value = "CUSTOMER_MANAGED_STORAGE_INDEXING")]
        CUSTOMER_MANAGED_STORAGE_INDEXING,

        [EnumMember(Value = "DATA_CENTER_CONSOLIDATION")]
        DATA_CENTER_CONSOLIDATION,

        [EnumMember(Value = "DATA_CENTER_IMMUTABILITY")]
        DATA_CENTER_IMMUTABILITY,

        [EnumMember(Value = "DATA_CENTER_KMS")]
        DATA_CENTER_KMS,

        [EnumMember(Value = "DOWNLOAD_FILE")]
        DOWNLOAD_FILE,

        [EnumMember(Value = "ENCRYPTION")]
        ENCRYPTION,

        [EnumMember(Value = "EXPORT_AND_RESTORE")]
        EXPORT_AND_RESTORE,

        [EnumMember(Value = "EXPORT_AND_RESTORE_POWER_OFF_VM")]
        EXPORT_AND_RESTORE_POWER_OFF_VM,

        [EnumMember(Value = "EXPORT_POWER_OFF")]
        EXPORT_POWER_OFF,

        [EnumMember(Value = "EXPORT_POWER_ON")]
        EXPORT_POWER_ON,

        [EnumMember(Value = "FILE_LEVEL_RECOVERY")]
        FILE_LEVEL_RECOVERY,

        [EnumMember(Value = "GROUP_UNSPECIFIED")]
        GROUP_UNSPECIFIED,

        [EnumMember(Value = "PRIVATE_ENDPOINTS")]
        PRIVATE_ENDPOINTS,

        [EnumMember(Value = "RECOVERY")]
        RECOVERY,

        [EnumMember(Value = "RESTORE")]
        RESTORE,

        [EnumMember(Value = "RSC_MANAGED_CLUSTER")]
        RSC_MANAGED_CLUSTER,

        [EnumMember(Value = "SAP_HANA_SS_BASIC")]
        SAP_HANA_SS_BASIC,

        [EnumMember(Value = "SAP_HANA_SS_RECOVERY")]
        SAP_HANA_SS_RECOVERY,

        [EnumMember(Value = "SERVICE_ENDPOINT_AUTOMATION")]
        SERVICE_ENDPOINT_AUTOMATION,

        [EnumMember(Value = "SNAPSHOT_PRIVATE_ACCESS")]
        SNAPSHOT_PRIVATE_ACCESS,

        [EnumMember(Value = "SQL_ARCHIVAL")]
        SQL_ARCHIVAL


    } // enum PermissionsGroup

} // namespace RubrikSecurityCloud.Types