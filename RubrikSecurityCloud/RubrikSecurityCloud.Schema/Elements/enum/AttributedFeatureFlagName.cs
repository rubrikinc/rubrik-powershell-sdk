// AttributedFeatureFlagName.cs
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
    public enum AttributedFeatureFlagName
    {
        [EnumMember(Value = "ACTIVE_DIRECTORY_OBJECT_COMPARISION")]
        ACTIVE_DIRECTORY_OBJECT_COMPARISION,

        [EnumMember(Value = "AD_SEARCH_ACROSS_SNAPSHOTS_ENABLED")]
        AD_SEARCH_ACROSS_SNAPSHOTS_ENABLED,

        [EnumMember(Value = "ARCHIVAL_ENCRYPTION_WITH_KEY_MGMT_AZURE")]
        ARCHIVAL_ENCRYPTION_WITH_KEY_MGMT_AZURE,

        [EnumMember(Value = "AZURE_BLOB_LEVEL_IMMUTABILITY_ENABLED")]
        AZURE_BLOB_LEVEL_IMMUTABILITY_ENABLED,

        [EnumMember(Value = "DB2_CROSS_HOST_AUTH")]
        DB2_CROSS_HOST_AUTH,

        [EnumMember(Value = "DB2_STATIC_RETENTION_ENABLED")]
        DB2_STATIC_RETENTION_ENABLED,

        [EnumMember(Value = "HYPERV_INPLACE_RECOVERY_ENABLED")]
        HYPERV_INPLACE_RECOVERY_ENABLED,

        [EnumMember(Value = "HYPERV_VHDX_RECOVERY_ENABLED")]
        HYPERV_VHDX_RECOVERY_ENABLED,

        [EnumMember(Value = "MONGO_LDAP_AUTH_ENABLED")]
        MONGO_LDAP_AUTH_ENABLED,

        [EnumMember(Value = "MONGO_ON_DEMAND_SNAPSHOT_ENABLED")]
        MONGO_ON_DEMAND_SNAPSHOT_ENABLED,

        [EnumMember(Value = "MONGO_SHARDED_SUPPORT_ENABLED")]
        MONGO_SHARDED_SUPPORT_ENABLED,

        [EnumMember(Value = "MULTI_CLUSTER_PC_ENABLED")]
        MULTI_CLUSTER_PC_ENABLED,

        [EnumMember(Value = "NUTANIX_CLUSTER_SNAPSHOT_CONSISTENCY")]
        NUTANIX_CLUSTER_SNAPSHOT_CONSISTENCY,

        [EnumMember(Value = "NUTANIX_DR_ENABLED")]
        NUTANIX_DR_ENABLED,

        [EnumMember(Value = "NUTANIX_SNAPSHOT_VDISK_RECOVERY_ENABLED")]
        NUTANIX_SNAPSHOT_VDISK_RECOVERY_ENABLED,

        [EnumMember(Value = "RCV_BLOB_LEVEL_IMMUTABILITY_ENABLED")]
        RCV_BLOB_LEVEL_IMMUTABILITY_ENABLED,

        [EnumMember(Value = "RCV_BLOB_LEVEL_IMMUTABILITY_ENABLED_FOR_NCD")]
        RCV_BLOB_LEVEL_IMMUTABILITY_ENABLED_FOR_NCD,

        [EnumMember(Value = "REGISTER_HOST_OS_TYPE_ENABLED")]
        REGISTER_HOST_OS_TYPE_ENABLED,

        [EnumMember(Value = "RESTORE_TO_TARGET_VM_ENABLED")]
        RESTORE_TO_TARGET_VM_ENABLED,

        [EnumMember(Value = "ROLLING_UPGRADE")]
        ROLLING_UPGRADE,

        [EnumMember(Value = "SAMPLE_FLAG_WITH_ATTRIBUTES")]
        SAMPLE_FLAG_WITH_ATTRIBUTES,

        [EnumMember(Value = "SONAR_PHASED_ANALYSIS")]
        SONAR_PHASED_ANALYSIS,

        [EnumMember(Value = "VLAN_REPLICATION_SUPPORT")]
        VLAN_REPLICATION_SUPPORT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AttributedFeatureFlagName

} // namespace RubrikSecurityCloud.Types