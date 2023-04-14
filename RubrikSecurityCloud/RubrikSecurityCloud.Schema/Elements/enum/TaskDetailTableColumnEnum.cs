// TaskDetailTableColumnEnum.cs
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
    public enum TaskDetailTableColumnEnum
    {
        [EnumMember(Value = "ArchivalTarget")]
        ARCHIVAL_TARGET,

        [EnumMember(Value = "ClusterLocation")]
        CLUSTER_LOCATION,

        [EnumMember(Value = "DataTransferred")]
        DATA_TRANSFERRED,

        [EnumMember(Value = "DirectArchive")]
        DIRECT_ARCHIVE,

        [EnumMember(Value = "EndTime")]
        END_TIME,

        [EnumMember(Value = "FailureReason")]
        FAILURE_REASON,

        [EnumMember(Value = "Location")]
        LOCATION,

        [EnumMember(Value = "LogicalBytes")]
        LOGICAL_BYTES,

        [EnumMember(Value = "ObjectName")]
        OBJECT_NAME,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "PhysicalBytes")]
        PHYSICAL_BYTES,

        [EnumMember(Value = "ProtectedVolume")]
        PROTECTED_VOLUME,

        [EnumMember(Value = "RecoveryPoint")]
        RECOVERY_POINT,

        [EnumMember(Value = "RecoveryPointType")]
        RECOVERY_POINT_TYPE,

        [EnumMember(Value = "ReplicationSource")]
        REPLICATION_SOURCE,

        [EnumMember(Value = "ReplicationTarget")]
        REPLICATION_TARGET,

        [EnumMember(Value = "SlaDomainName")]
        SLA_DOMAIN_NAME,

        [EnumMember(Value = "SnapshotConsistency")]
        SNAPSHOT_CONSISTENCY,

        [EnumMember(Value = "StartTime")]
        START_TIME,

        [EnumMember(Value = "Status")]
        STATUS,

        [EnumMember(Value = "TaskType")]
        TASK_TYPE,

        [EnumMember(Value = "TotalFileTransferred")]
        TOTAL_FILE_TRANSFERRED,

        [EnumMember(Value = "UserName")]
        USER_NAME


    } // enum TaskDetailTableColumnEnum

} // namespace Rubrik.SecurityCloud.Types