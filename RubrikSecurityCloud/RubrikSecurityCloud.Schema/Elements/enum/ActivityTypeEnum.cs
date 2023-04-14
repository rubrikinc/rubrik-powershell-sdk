// ActivityTypeEnum.cs
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
    public enum ActivityTypeEnum
    {
        [EnumMember(Value = "Anomaly")]
        ANOMALY,

        [EnumMember(Value = "Archive")]
        ARCHIVE,

        [EnumMember(Value = "AuthDomain")]
        AUTH_DOMAIN,

        [EnumMember(Value = "AwsEvent")]
        AWS_EVENT,

        [EnumMember(Value = "BULK_RECOVERY")]
        BULK_RECOVERY,

        [EnumMember(Value = "Backup")]
        BACKUP,

        [EnumMember(Value = "Classification")]
        CLASSIFICATION,

        [EnumMember(Value = "CloudNativeSource")]
        CLOUD_NATIVE_SOURCE,

        [EnumMember(Value = "CloudNativeVirtualMachine")]
        CLOUD_NATIVE_VIRTUAL_MACHINE,

        [EnumMember(Value = "CloudNativeVm")]
        CLOUD_NATIVE_VM,

        [EnumMember(Value = "Configuration")]
        CONFIGURATION,

        [EnumMember(Value = "Connection")]
        CONNECTION,

        [EnumMember(Value = "Conversion")]
        CONVERSION,

        [EnumMember(Value = "Diagnostic")]
        DIAGNOSTIC,

        [EnumMember(Value = "Discovery")]
        DISCOVERY,

        [EnumMember(Value = "Download")]
        DOWNLOAD,

        [EnumMember(Value = "ENCRYPTION_MANAGEMENT_OPERATION")]
        ENCRYPTION_MANAGEMENT_OPERATION,

        [EnumMember(Value = "EmbeddedEvent")]
        EMBEDDED_EVENT,

        [EnumMember(Value = "Failover")]
        FAILOVER,

        [EnumMember(Value = "Fileset")]
        FILESET,

        [EnumMember(Value = "Hardware")]
        HARDWARE,

        [EnumMember(Value = "Hdfs")]
        HDFS,

        [EnumMember(Value = "HostEvent")]
        HOST_EVENT,

        [EnumMember(Value = "HypervScvmm")]
        HYPERV_SCVMM,

        [EnumMember(Value = "HypervServer")]
        HYPERV_SERVER,

        [EnumMember(Value = "ISOLATED_RECOVERY")]
        ISOLATED_RECOVERY,

        [EnumMember(Value = "Index")]
        INDEX,

        [EnumMember(Value = "Instantiate")]
        INSTANTIATE,

        [EnumMember(Value = "K8S")]
        K8_S,

        [EnumMember(Value = "LOG_BACKUP")]
        LOG_BACKUP,

        [EnumMember(Value = "LegalHold")]
        LEGAL_HOLD,

        [EnumMember(Value = "LocalRecovery")]
        LOCAL_RECOVERY,

        [EnumMember(Value = "LockSnapshot")]
        LOCK_SNAPSHOT,

        [EnumMember(Value = "Maintenance")]
        MAINTENANCE,

        [EnumMember(Value = "NutanixCluster")]
        NUTANIX_CLUSTER,

        [EnumMember(Value = "OWNERSHIP")]
        OWNERSHIP,

        [EnumMember(Value = "RadarAnalysis")]
        RADAR_ANALYSIS,

        [EnumMember(Value = "Recovery")]
        RECOVERY,

        [EnumMember(Value = "Replication")]
        REPLICATION,

        [EnumMember(Value = "ResourceOperations")]
        RESOURCE_OPERATIONS,

        [EnumMember(Value = "Storage")]
        STORAGE,

        [EnumMember(Value = "StorageArray")]
        STORAGE_ARRAY,

        [EnumMember(Value = "StormResource")]
        STORM_RESOURCE,

        [EnumMember(Value = "Support")]
        SUPPORT,

        [EnumMember(Value = "Sync")]
        SYNC,

        [EnumMember(Value = "System")]
        SYSTEM,

        [EnumMember(Value = "TENANT_OVERLAP")]
        TENANT_OVERLAP,

        [EnumMember(Value = "THREAT_FEED")]
        THREAT_FEED,

        [EnumMember(Value = "TestFailover")]
        TEST_FAILOVER,

        [EnumMember(Value = "ThreatHunt")]
        THREAT_HUNT,

        [EnumMember(Value = "Tpr")]
        TPR,

        [EnumMember(Value = "UnknownEventType")]
        UNKNOWN_EVENT_TYPE,

        [EnumMember(Value = "Upgrade")]
        UPGRADE,

        [EnumMember(Value = "VCenter")]
        VCENTER,

        [EnumMember(Value = "Vcd")]
        VCD,

        [EnumMember(Value = "VolumeGroup")]
        VOLUME_GROUP


    } // enum ActivityTypeEnum

} // namespace Rubrik.SecurityCloud.Types