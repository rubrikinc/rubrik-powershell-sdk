// SnapshotQueryFilterField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:02.
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
    public enum SnapshotQueryFilterField
    {
        [EnumMember(Value = "ARCHIVAL_LOCATION_IDS")]
        ARCHIVAL_LOCATION_IDS,

        [EnumMember(Value = "EBS_AWS_NATIVE_ACCOUNT_ID")]
        EBS_AWS_NATIVE_ACCOUNT_ID,

        [EnumMember(Value = "EC2_AWS_NATIVE_ACCOUNT_ID")]
        EC2_AWS_NATIVE_ACCOUNT_ID,

        [EnumMember(Value = "EXCLUDE_ANOMALOUS")]
        EXCLUDE_ANOMALOUS,

        [EnumMember(Value = "EXCLUDE_QUARANTINED")]
        EXCLUDE_QUARANTINED,

        [EnumMember(Value = "HAS_CLOUD_NATIVE_INDEX_FILES")]
        HAS_CLOUD_NATIVE_INDEX_FILES,

        [EnumMember(Value = "HAS_UNEXPIRED_ARCHIVED_SNAPSHOTS")]
        HAS_UNEXPIRED_ARCHIVED_SNAPSHOTS,

        [EnumMember(Value = "HAS_UNEXPIRED_REPLICAS")]
        HAS_UNEXPIRED_REPLICAS,

        [EnumMember(Value = "IMMUTABLE_LOCK_END_TIME_BEFORE")]
        IMMUTABLE_LOCK_END_TIME_BEFORE,

        [EnumMember(Value = "IS_APPFLOWS_QUERY_SNAPSHOT_DETAILS_NOT_NEEDED")]
        IS_APPFLOWS_QUERY_SNAPSHOT_DETAILS_NOT_NEEDED,

        [EnumMember(Value = "IS_ARCHIVAL_COPY")]
        IS_ARCHIVAL_COPY,

        [EnumMember(Value = "IS_ARCHIVED")]
        IS_ARCHIVED,

        [EnumMember(Value = "IS_DELETED_FROM_SOURCE")]
        IS_DELETED_FROM_SOURCE,

        [EnumMember(Value = "IS_DOWNLOADED")]
        IS_DOWNLOADED,

        [EnumMember(Value = "IS_GCED")]
        IS_GCED,

        [EnumMember(Value = "IS_INDEXED")]
        IS_INDEXED,

        [EnumMember(Value = "IS_LEGALLY_HELD")]
        IS_LEGALLY_HELD,

        [EnumMember(Value = "IS_NOT_GLOBALLY_EXPIRED")]
        IS_NOT_GLOBALLY_EXPIRED,

        [EnumMember(Value = "IS_ON_DEMAND")]
        IS_ON_DEMAND,

        [EnumMember(Value = "IS_REPLICA")]
        IS_REPLICA,

        [EnumMember(Value = "IS_REPLICATED")]
        IS_REPLICATED,

        [EnumMember(Value = "IS_SAP_HANA_INCREMENTAL_SNAPSHOT")]
        IS_SAP_HANA_INCREMENTAL_SNAPSHOT,

        [EnumMember(Value = "IS_SKIPPED_FOR_REPLICATION")]
        IS_SKIPPED_FOR_REPLICATION,

        [EnumMember(Value = "ON_DEMAND_SLA_ID")]
        ON_DEMAND_SLA_ID,

        [EnumMember(Value = "RDS_AWS_NATIVE_ACCOUNT_ID")]
        RDS_AWS_NATIVE_ACCOUNT_ID,

        [EnumMember(Value = "SLA_ID")]
        SLA_ID,

        [EnumMember(Value = "SNAPPABLE_TYPES")]
        SNAPPABLE_TYPES,

        [EnumMember(Value = "SNAPSHOT_CUSTOMIZATION")]
        SNAPSHOT_CUSTOMIZATION,

        [EnumMember(Value = "SNAPSHOT_STATUS")]
        SNAPSHOT_STATUS,

        [EnumMember(Value = "SNAPSHOT_TYPE")]
        SNAPSHOT_TYPE


    } // enum SnapshotQueryFilterField

} // namespace Rubrik.SecurityCloud.Types