// SnappableAggregationsEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:01.
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
    public enum SnappableAggregationsEnum
    {
        [EnumMember(Value = "ArchiveStorage")]
        ARCHIVE_STORAGE,

        [EnumMember(Value = "Count")]
        COUNT,

        [EnumMember(Value = "LAST_SNAPSHOT_LOGICAL_BYTES")]
        LAST_SNAPSHOT_LOGICAL_BYTES,

        [EnumMember(Value = "LogicalBytes")]
        LOGICAL_BYTES,

        [EnumMember(Value = "MissedSnapshots")]
        MISSED_SNAPSHOTS,

        [EnumMember(Value = "PhysicalBytes")]
        PHYSICAL_BYTES,

        [EnumMember(Value = "ReplicaStorage")]
        REPLICA_STORAGE,

        [EnumMember(Value = "TRANSFERRED_BYTES")]
        TRANSFERRED_BYTES,

        [EnumMember(Value = "TotalSnapshots")]
        TOTAL_SNAPSHOTS


    } // enum SnappableAggregationsEnum

} // namespace Rubrik.SecurityCloud.Types