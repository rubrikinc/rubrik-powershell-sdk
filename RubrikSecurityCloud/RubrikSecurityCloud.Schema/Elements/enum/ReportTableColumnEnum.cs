// ReportTableColumnEnum.cs
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
    public enum ReportTableColumnEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ActivityStatus")]
        ACTIVITY_STATUS,

        [EnumMember(Value = "ActivityType")]
        ACTIVITY_TYPE,

        [EnumMember(Value = "AnalyzersBreakdown")]
        ANALYZERS_BREAKDOWN,

        [EnumMember(Value = "AppBlueprintName")]
        APP_BLUEPRINT_NAME,

        [EnumMember(Value = "ArchivalTarget")]
        ARCHIVAL_TARGET,

        [EnumMember(Value = "ArchiveSnapshots")]
        ARCHIVE_SNAPSHOTS,

        [EnumMember(Value = "ArchiveStorage")]
        ARCHIVE_STORAGE,

        [EnumMember(Value = "BytesCreated")]
        BYTES_CREATED,

        [EnumMember(Value = "BytesDeleted")]
        BYTES_DELETED,

        [EnumMember(Value = "BytesModified")]
        BYTES_MODIFIED,

        [EnumMember(Value = "BytesNetChanged")]
        BYTES_NET_CHANGED,

        [EnumMember(Value = "Cluster")]
        CLUSTER,

        [EnumMember(Value = "ClusterLocation")]
        CLUSTER_LOCATION,

        [EnumMember(Value = "ClusterName")]
        CLUSTER_NAME,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "ComplianceStatus")]
        COMPLIANCE_STATUS,

        [EnumMember(Value = "DataReduction")]
        DATA_REDUCTION,

        [EnumMember(Value = "DataTransferred")]
        DATA_TRANSFERRED,

        [EnumMember(Value = "DirectArchive")]
        DIRECT_ARCHIVE,

        [EnumMember(Value = "Duration")]
        DURATION,

        [EnumMember(Value = "EncryptionEnabled")]
        ENCRYPTION_ENABLED,

        [EnumMember(Value = "EndTime")]
        END_TIME,

        [EnumMember(Value = "FailoverStatus")]
        FAILOVER_STATUS,

        [EnumMember(Value = "FailoverType")]
        FAILOVER_TYPE,

        [EnumMember(Value = "FailureReason")]
        FAILURE_REASON,

        [EnumMember(Value = "FileName")]
        FILE_NAME,

        [EnumMember(Value = "FilesCreated")]
        FILES_CREATED,

        [EnumMember(Value = "FilesDeleted")]
        FILES_DELETED,

        [EnumMember(Value = "FilesModified")]
        FILES_MODIFIED,

        [EnumMember(Value = "IsAnomaly")]
        IS_ANOMALY,

        [EnumMember(Value = "LastSnapshot")]
        LAST_SNAPSHOT,

        [EnumMember(Value = "LastTestStatus")]
        LAST_TEST_STATUS,

        [EnumMember(Value = "LastTestTime")]
        LAST_TEST_TIME,

        [EnumMember(Value = "LastUpdated")]
        LAST_UPDATED,

        [EnumMember(Value = "LocalSnapshots")]
        LOCAL_SNAPSHOTS,

        [EnumMember(Value = "Location")]
        LOCATION,

        [EnumMember(Value = "LogicalByte")]
        LOGICAL_BYTE,

        [EnumMember(Value = "LogicalBytes")]
        LOGICAL_BYTES,

        [EnumMember(Value = "MissedSnapshots")]
        MISSED_SNAPSHOTS,

        [EnumMember(Value = "NumCoveredObjects")]
        NUM_COVERED_OBJECTS,

        [EnumMember(Value = "NumHighRiskLocations")]
        NUM_HIGH_RISK_LOCATIONS,

        [EnumMember(Value = "NumViolatedFiles")]
        NUM_VIOLATED_FILES,

        [EnumMember(Value = "NumViolations")]
        NUM_VIOLATIONS,

        [EnumMember(Value = "ObjectName")]
        OBJECT_NAME,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "Path")]
        PATH,

        [EnumMember(Value = "PhysicalBytes")]
        PHYSICAL_BYTES,

        [EnumMember(Value = "PoliciesBreakdown")]
        POLICIES_BREAKDOWN,

        [EnumMember(Value = "PolicyName")]
        POLICY_NAME,

        [EnumMember(Value = "PolicyStatus")]
        POLICY_STATUS,

        [EnumMember(Value = "PreviousSnapshotDate")]
        PREVIOUS_SNAPSHOT_DATE,

        [EnumMember(Value = "PreviousSnapshotId")]
        PREVIOUS_SNAPSHOT_ID,

        [EnumMember(Value = "ProtectedVolume")]
        PROTECTED_VOLUME,

        [EnumMember(Value = "RecoveryPoint")]
        RECOVERY_POINT,

        [EnumMember(Value = "RecoveryPointType")]
        RECOVERY_POINT_TYPE,

        [EnumMember(Value = "ReplicaSnapshots")]
        REPLICA_SNAPSHOTS,

        [EnumMember(Value = "ReplicaStorage")]
        REPLICA_STORAGE,

        [EnumMember(Value = "ReplicationSource")]
        REPLICATION_SOURCE,

        [EnumMember(Value = "ReplicationTarget")]
        REPLICATION_TARGET,

        [EnumMember(Value = "Size")]
        SIZE,

        [EnumMember(Value = "SlaDomain")]
        SLA_DOMAIN,

        [EnumMember(Value = "SlaDomainName")]
        SLA_DOMAIN_NAME,

        [EnumMember(Value = "SnappableName")]
        SNAPPABLE_NAME,

        [EnumMember(Value = "SnapshotConsistency")]
        SNAPSHOT_CONSISTENCY,

        [EnumMember(Value = "SnapshotDate")]
        SNAPSHOT_DATE,

        [EnumMember(Value = "SnapshotId")]
        SNAPSHOT_ID,

        [EnumMember(Value = "SnapshotTime")]
        SNAPSHOT_TIME,

        [EnumMember(Value = "Source")]
        SOURCE,

        [EnumMember(Value = "StartTime")]
        START_TIME,

        [EnumMember(Value = "Status")]
        STATUS,

        [EnumMember(Value = "SuspiciousFilesAdded")]
        SUSPICIOUS_FILES_ADDED,

        [EnumMember(Value = "TargetSite")]
        TARGET_SITE,

        [EnumMember(Value = "TaskType")]
        TASK_TYPE,

        [EnumMember(Value = "TotalCapacity")]
        TOTAL_CAPACITY,

        [EnumMember(Value = "TotalFileTransferred")]
        TOTAL_FILE_TRANSFERRED,

        [EnumMember(Value = "TotalHits")]
        TOTAL_HITS,

        [EnumMember(Value = "TotalSnapshots")]
        TOTAL_SNAPSHOTS,

        [EnumMember(Value = "TransferredBytes")]
        TRANSFERRED_BYTES,

        [EnumMember(Value = "UsedCapacity")]
        USED_CAPACITY,

        [EnumMember(Value = "UserAuditStatus")]
        USER_AUDIT_STATUS,

        [EnumMember(Value = "UserAuditType")]
        USER_AUDIT_TYPE,

        [EnumMember(Value = "UserName")]
        USER_NAME,

        [EnumMember(Value = "WorkloadName")]
        WORKLOAD_NAME,

        [EnumMember(Value = "WorkloadType")]
        WORKLOAD_TYPE


    } // enum ReportTableColumnEnum

} // namespace RubrikSecurityCloud.Types