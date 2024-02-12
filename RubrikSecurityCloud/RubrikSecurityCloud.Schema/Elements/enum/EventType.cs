// EventType.cs
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
    public enum EventType
    {
        [EnumMember(Value = "ANOMALY")]
        ANOMALY,

        [EnumMember(Value = "ARCHIVE")]
        ARCHIVE,

        [EnumMember(Value = "AUTH_DOMAIN")]
        AUTH_DOMAIN,

        [EnumMember(Value = "AWS_EVENT")]
        AWS_EVENT,

        [EnumMember(Value = "BACKUP")]
        BACKUP,

        [EnumMember(Value = "BULK_RECOVERY")]
        BULK_RECOVERY,

        [EnumMember(Value = "CLASSIFICATION")]
        CLASSIFICATION,

        [EnumMember(Value = "CLOUD_NATIVE_SOURCE")]
        CLOUD_NATIVE_SOURCE,

        [EnumMember(Value = "CLOUD_NATIVE_VIRTUAL_MACHINE")]
        CLOUD_NATIVE_VIRTUAL_MACHINE,

        [EnumMember(Value = "CLOUD_NATIVE_VM")]
        CLOUD_NATIVE_VM,

        [EnumMember(Value = "CONFIGURATION")]
        CONFIGURATION,

        [EnumMember(Value = "CONNECTION")]
        CONNECTION,

        [EnumMember(Value = "CONVERSION")]
        CONVERSION,

        [EnumMember(Value = "DIAGNOSTIC")]
        DIAGNOSTIC,

        [EnumMember(Value = "DISCOVERY")]
        DISCOVERY,

        [EnumMember(Value = "DOWNLOAD")]
        DOWNLOAD,

        [EnumMember(Value = "EMBEDDED_EVENT")]
        EMBEDDED_EVENT,

        [EnumMember(Value = "ENCRYPTION_MANAGEMENT_OPERATION")]
        ENCRYPTION_MANAGEMENT_OPERATION,

        [EnumMember(Value = "FAILOVER")]
        FAILOVER,

        [EnumMember(Value = "FILESET")]
        FILESET,

        [EnumMember(Value = "HARDWARE")]
        HARDWARE,

        [EnumMember(Value = "HDFS")]
        HDFS,

        [EnumMember(Value = "HOST_EVENT")]
        HOST_EVENT,

        [EnumMember(Value = "HYPERV_SCVMM")]
        HYPERV_SCVMM,

        [EnumMember(Value = "HYPERV_SERVER")]
        HYPERV_SERVER,

        [EnumMember(Value = "INDEX")]
        INDEX,

        [EnumMember(Value = "INSTANTIATE")]
        INSTANTIATE,

        [EnumMember(Value = "ISOLATED_RECOVERY")]
        ISOLATED_RECOVERY,

        [EnumMember(Value = "LEGAL_HOLD")]
        LEGAL_HOLD,

        [EnumMember(Value = "LOCAL_RECOVERY")]
        LOCAL_RECOVERY,

        [EnumMember(Value = "LOCK_SNAPSHOT")]
        LOCK_SNAPSHOT,

        [EnumMember(Value = "LOG_BACKUP")]
        LOG_BACKUP,

        [EnumMember(Value = "MAINTENANCE")]
        MAINTENANCE,

        [EnumMember(Value = "NUTANIX_CLUSTER")]
        NUTANIX_CLUSTER,

        [EnumMember(Value = "OWNERSHIP")]
        OWNERSHIP,

        [EnumMember(Value = "RANSOMWARE_INVESTIGATION_ANALYSIS")]
        RANSOMWARE_INVESTIGATION_ANALYSIS,

        [EnumMember(Value = "RECOVERY")]
        RECOVERY,

        [EnumMember(Value = "REPLICATION")]
        REPLICATION,

        [EnumMember(Value = "RESOURCE_OPERATIONS")]
        RESOURCE_OPERATIONS,

        [EnumMember(Value = "SCHEDULE_RECOVERY")]
        SCHEDULE_RECOVERY,

        [EnumMember(Value = "STORAGE")]
        STORAGE,

        [EnumMember(Value = "STORAGE_ARRAY")]
        STORAGE_ARRAY,

        [EnumMember(Value = "STORM_RESOURCE")]
        STORM_RESOURCE,

        [EnumMember(Value = "SUPPORT")]
        SUPPORT,

        [EnumMember(Value = "SYNC")]
        SYNC,

        [EnumMember(Value = "SYSTEM")]
        SYSTEM,

        [EnumMember(Value = "TENANT_OVERLAP")]
        TENANT_OVERLAP,

        [EnumMember(Value = "TEST_FAILOVER")]
        TEST_FAILOVER,

        [EnumMember(Value = "THREAT_FEED")]
        THREAT_FEED,

        [EnumMember(Value = "THREAT_HUNT")]
        THREAT_HUNT,

        [EnumMember(Value = "THREAT_MONITORING")]
        THREAT_MONITORING,

        [EnumMember(Value = "TPR")]
        TPR,

        [EnumMember(Value = "UNKNOWN_EVENT_TYPE")]
        UNKNOWN_EVENT_TYPE,

        [EnumMember(Value = "UPGRADE")]
        UPGRADE,

        [EnumMember(Value = "VCD")]
        VCD,

        [EnumMember(Value = "VCENTER")]
        VCENTER,

        [EnumMember(Value = "VOLUME_GROUP")]
        VOLUME_GROUP


    } // enum EventType

} // namespace RubrikSecurityCloud.Types