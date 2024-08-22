// SortByFieldEnum.cs
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
    public enum SortByFieldEnum
    {
        [EnumMember(Value = "ANALYZER_NAME")]
        ANALYZER_NAME,

        [EnumMember(Value = "ANOMALY_PROBABILITY")]
        ANOMALY_PROBABILITY,

        [EnumMember(Value = "ActivityStatus")]
        ACTIVITY_STATUS,

        [EnumMember(Value = "ActivityType")]
        ACTIVITY_TYPE,

        [EnumMember(Value = "AppBlueprintName")]
        APP_BLUEPRINT_NAME,

        [EnumMember(Value = "ArchivalComplianceStatus")]
        ARCHIVAL_COMPLIANCE_STATUS,

        [EnumMember(Value = "ArchivalSnapshotLag")]
        ARCHIVAL_SNAPSHOT_LAG,

        [EnumMember(Value = "ArchiveSnapshots")]
        ARCHIVE_SNAPSHOTS,

        [EnumMember(Value = "ArchiveStorage")]
        ARCHIVE_STORAGE,

        [EnumMember(Value = "AwaitingFirstFull")]
        AWAITING_FIRST_FULL,

        [EnumMember(Value = "BYTES_CREATED_COUNT")]
        BYTES_CREATED_COUNT,

        [EnumMember(Value = "BYTES_DELETED_COUNT")]
        BYTES_DELETED_COUNT,

        [EnumMember(Value = "BYTES_MODIFIED_COUNT")]
        BYTES_MODIFIED_COUNT,

        [EnumMember(Value = "BYTES_NET_CHANGED_COUNT")]
        BYTES_NET_CHANGED_COUNT,

        [EnumMember(Value = "CLUSTER")]
        CLUSTER,

        [EnumMember(Value = "CLUSTER_LOCATION")]
        CLUSTER_LOCATION,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "ClusterName")]
        CLUSTER_NAME,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "ComplianceStatus")]
        COMPLIANCE_STATUS,

        [EnumMember(Value = "DataReduction")]
        DATA_REDUCTION,

        [EnumMember(Value = "Date")]
        DATE,

        [EnumMember(Value = "ESTIMATED_RUNWAY")]
        ESTIMATED_RUNWAY,

        [EnumMember(Value = "EndTime")]
        END_TIME,

        [EnumMember(Value = "FILES_CREATED_COUNT")]
        FILES_CREATED_COUNT,

        [EnumMember(Value = "FILES_DELETED_COUNT")]
        FILES_DELETED_COUNT,

        [EnumMember(Value = "FILES_MODIFIED_COUNT")]
        FILES_MODIFIED_COUNT,

        [EnumMember(Value = "FILES_WITH_HITS")]
        FILES_WITH_HITS,

        [EnumMember(Value = "FILE_NAME")]
        FILE_NAME,

        [EnumMember(Value = "INSTALLED_VERSION")]
        INSTALLED_VERSION,

        [EnumMember(Value = "IS_ANOMALY")]
        IS_ANOMALY,

        [EnumMember(Value = "IS_ENCRYPTED")]
        IS_ENCRYPTED,

        [EnumMember(Value = "LOCATION")]
        LOCATION,

        [EnumMember(Value = "LastSnapshot")]
        LAST_SNAPSHOT,

        [EnumMember(Value = "LastUpdated")]
        LAST_UPDATED,

        [EnumMember(Value = "LatestArchivalSnapshot")]
        LATEST_ARCHIVAL_SNAPSHOT,

        [EnumMember(Value = "LatestReplicationSnapshot")]
        LATEST_REPLICATION_SNAPSHOT,

        [EnumMember(Value = "LocalOnDemandSnapshots")]
        LOCAL_ON_DEMAND_SNAPSHOTS,

        [EnumMember(Value = "LocalSLASnapshots")]
        LOCAL_SLA_SNAPSHOTS,

        [EnumMember(Value = "LocalSnapshots")]
        LOCAL_SNAPSHOTS,

        [EnumMember(Value = "LogicalBytes")]
        LOGICAL_BYTES,

        [EnumMember(Value = "LogicalDataReduction")]
        LOGICAL_DATA_REDUCTION,

        [EnumMember(Value = "MANAGED_ID")]
        MANAGED_ID,

        [EnumMember(Value = "MissedSnapshots")]
        MISSED_SNAPSHOTS,

        [EnumMember(Value = "NUM_HIGH_RISK_LOCATIONS")]
        NUM_HIGH_RISK_LOCATIONS,

        [EnumMember(Value = "NUM_OBJECTS")]
        NUM_OBJECTS,

        [EnumMember(Value = "NUM_VIOLATED_FILES")]
        NUM_VIOLATED_FILES,

        [EnumMember(Value = "NUM_VIOLATION")]
        NUM_VIOLATION,

        [EnumMember(Value = "Name")]
        NAME,

        [EnumMember(Value = "NumCanceled")]
        NUM_CANCELED,

        [EnumMember(Value = "NumExpected")]
        NUM_EXPECTED,

        [EnumMember(Value = "NumFailed")]
        NUM_FAILED,

        [EnumMember(Value = "NumSucceeded")]
        NUM_SUCCEEDED,

        [EnumMember(Value = "OBJECT_NAME")]
        OBJECT_NAME,

        [EnumMember(Value = "OBJECT_STATE")]
        OBJECT_STATE,

        [EnumMember(Value = "OBJECT_TYPE")]
        OBJECT_TYPE,

        [EnumMember(Value = "PATH")]
        PATH,

        [EnumMember(Value = "POLICY_NAME")]
        POLICY_NAME,

        [EnumMember(Value = "POLICY_STATUS")]
        POLICY_STATUS,

        [EnumMember(Value = "PREVIOUS_SNAPSHOT_DATE")]
        PREVIOUS_SNAPSHOT_DATE,

        [EnumMember(Value = "PREVIOUS_SNAPSHOT_ID")]
        PREVIOUS_SNAPSHOT_ID,

        [EnumMember(Value = "PULL_TIME")]
        PULL_TIME,

        [EnumMember(Value = "PhysicalBytes")]
        PHYSICAL_BYTES,

        [EnumMember(Value = "ProtectionStatus")]
        PROTECTION_STATUS,

        [EnumMember(Value = "RegisteredAt")]
        REGISTERED_AT,

        [EnumMember(Value = "ReplicaSnapshots")]
        REPLICA_SNAPSHOTS,

        [EnumMember(Value = "ReplicaStorage")]
        REPLICA_STORAGE,

        [EnumMember(Value = "ReplicationComplianceStatus")]
        REPLICATION_COMPLIANCE_STATUS,

        [EnumMember(Value = "ReplicationSnapshotLag")]
        REPLICATION_SNAPSHOT_LAG,

        [EnumMember(Value = "SEVERITY")]
        SEVERITY,

        [EnumMember(Value = "SIZE")]
        SIZE,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN,

        [EnumMember(Value = "SNAPSHOT_DATE")]
        SNAPSHOT_DATE,

        [EnumMember(Value = "SNAPSHOT_ID")]
        SNAPSHOT_ID,

        [EnumMember(Value = "SNAPSHOT_TIME")]
        SNAPSHOT_TIME,

        [EnumMember(Value = "SUSPICIOUS_FILES_COUNT")]
        SUSPICIOUS_FILES_COUNT,

        [EnumMember(Value = "SlaDomainName")]
        SLA_DOMAIN_NAME,

        [EnumMember(Value = "SourceSiteName")]
        SOURCE_SITE_NAME,

        [EnumMember(Value = "StartTime")]
        START_TIME,

        [EnumMember(Value = "TOTAL_HITS")]
        TOTAL_HITS,

        [EnumMember(Value = "TargetSiteName")]
        TARGET_SITE_NAME,

        [EnumMember(Value = "Time")]
        TIME,

        [EnumMember(Value = "TotalSnapshots")]
        TOTAL_SNAPSHOTS,

        [EnumMember(Value = "TransferredBytes")]
        TRANSFERRED_BYTES,

        [EnumMember(Value = "WORKLOAD_NAME")]
        WORKLOAD_NAME,

        [EnumMember(Value = "WORKLOAD_TYPE")]
        WORKLOAD_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SortByFieldEnum

} // namespace RubrikSecurityCloud.Types