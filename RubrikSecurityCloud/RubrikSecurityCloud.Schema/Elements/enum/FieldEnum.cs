// FieldEnum.cs
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
    public enum FieldEnum
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "HAS_UNEXPIRED_ARCHIVED_OR_SOURCE_SNAPSHOTS")]
        HAS_UNEXPIRED_ARCHIVED_OR_SOURCE_SNAPSHOTS,

        [EnumMember(Value = "HAS_UNEXPIRED_ARCHIVED_OR_UNGCED_SOURCE_SNAPSHOTS")]
        HAS_UNEXPIRED_ARCHIVED_OR_UNGCED_SOURCE_SNAPSHOTS,

        [EnumMember(Value = "HAS_UNEXPIRED_ARCHIVED_SNAPSHOTS")]
        HAS_UNEXPIRED_ARCHIVED_SNAPSHOTS,

        [EnumMember(Value = "IS_COMPLETE")]
        IS_COMPLETE,

        [EnumMember(Value = "IS_CORRUPTED")]
        IS_CORRUPTED,

        [EnumMember(Value = "IS_DELETED_FROM_SOURCE")]
        IS_DELETED_FROM_SOURCE,

        [EnumMember(Value = "IS_EXPIRED")]
        IS_EXPIRED,

        [EnumMember(Value = "IS_HINT_SET")]
        IS_HINT_SET,

        [EnumMember(Value = "IS_INDEXED")]
        IS_INDEXED,

        [EnumMember(Value = "IS_INDEX_MERGED")]
        IS_INDEX_MERGED,

        [EnumMember(Value = "IS_ON_DEMAND")]
        IS_ON_DEMAND,

        [EnumMember(Value = "IS_REPLICA")]
        IS_REPLICA,

        [EnumMember(Value = "IS_SKIPPED_FOR_REPLICATION")]
        IS_SKIPPED_FOR_REPLICATION,

        [EnumMember(Value = "SEQUENCE_NUMBER_GREATER_THAN")]
        SEQUENCE_NUMBER_GREATER_THAN,

        [EnumMember(Value = "SPECIFIC_SNAPSHOT_NOT_REQUIRED")]
        SPECIFIC_SNAPSHOT_NOT_REQUIRED,

        [EnumMember(Value = "TIME_RANGE_WITH_OFFSET")]
        TIME_RANGE_WITH_OFFSET,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FieldEnum

} // namespace RubrikSecurityCloud.Types