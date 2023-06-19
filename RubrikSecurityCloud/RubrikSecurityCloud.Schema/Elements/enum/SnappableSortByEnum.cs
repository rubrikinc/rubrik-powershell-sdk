// SnappableSortByEnum.cs
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
    public enum SnappableSortByEnum
    {
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

        [EnumMember(Value = "Cluster")]
        CLUSTER,

        [EnumMember(Value = "ClusterName")]
        CLUSTER_NAME,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "ComplianceStatus")]
        COMPLIANCE_STATUS,

        [EnumMember(Value = "DataReduction")]
        DATA_REDUCTION,

        [EnumMember(Value = "LastSnapshot")]
        LAST_SNAPSHOT,

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

        [EnumMember(Value = "Location")]
        LOCATION,

        [EnumMember(Value = "LogicalBytes")]
        LOGICAL_BYTES,

        [EnumMember(Value = "LogicalDataReduction")]
        LOGICAL_DATA_REDUCTION,

        [EnumMember(Value = "MissedSnapshots")]
        MISSED_SNAPSHOTS,

        [EnumMember(Value = "Name")]
        NAME,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "PULL_TIME")]
        PULL_TIME,

        [EnumMember(Value = "PhysicalBytes")]
        PHYSICAL_BYTES,

        [EnumMember(Value = "ProtectionStatus")]
        PROTECTION_STATUS,

        [EnumMember(Value = "ReplicaSnapshots")]
        REPLICA_SNAPSHOTS,

        [EnumMember(Value = "ReplicaStorage")]
        REPLICA_STORAGE,

        [EnumMember(Value = "ReplicationComplianceStatus")]
        REPLICATION_COMPLIANCE_STATUS,

        [EnumMember(Value = "ReplicationSnapshotLag")]
        REPLICATION_SNAPSHOT_LAG,

        [EnumMember(Value = "SlaDomainName")]
        SLA_DOMAIN_NAME,

        [EnumMember(Value = "TotalSnapshots")]
        TOTAL_SNAPSHOTS,

        [EnumMember(Value = "TransferredBytes")]
        TRANSFERRED_BYTES


    } // enum SnappableSortByEnum

} // namespace RubrikSecurityCloud.Types