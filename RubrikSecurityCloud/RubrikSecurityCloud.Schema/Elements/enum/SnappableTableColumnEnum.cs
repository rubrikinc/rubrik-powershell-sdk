// SnappableTableColumnEnum.cs
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
    public enum SnappableTableColumnEnum
    {
        [EnumMember(Value = "ArchiveSnapshots")]
        ARCHIVE_SNAPSHOTS,

        [EnumMember(Value = "ArchiveStorage")]
        ARCHIVE_STORAGE,

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

        [EnumMember(Value = "LocalSnapshots")]
        LOCAL_SNAPSHOTS,

        [EnumMember(Value = "Location")]
        LOCATION,

        [EnumMember(Value = "LogicalByte")]
        LOGICAL_BYTE,

        [EnumMember(Value = "MissedSnapshots")]
        MISSED_SNAPSHOTS,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "PhysicalBytes")]
        PHYSICAL_BYTES,

        [EnumMember(Value = "ReplicaSnapshots")]
        REPLICA_SNAPSHOTS,

        [EnumMember(Value = "ReplicaStorage")]
        REPLICA_STORAGE,

        [EnumMember(Value = "SlaDomain")]
        SLA_DOMAIN,

        [EnumMember(Value = "SnappableName")]
        SNAPPABLE_NAME,

        [EnumMember(Value = "TotalSnapshots")]
        TOTAL_SNAPSHOTS,

        [EnumMember(Value = "TransferredBytes")]
        TRANSFERRED_BYTES


    } // enum SnappableTableColumnEnum

} // namespace Rubrik.SecurityCloud.Types