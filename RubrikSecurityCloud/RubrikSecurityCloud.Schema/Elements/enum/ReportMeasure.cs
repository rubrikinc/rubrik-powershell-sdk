// ReportMeasure.cs
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
    public enum ReportMeasure
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ALL_MEASURES")]
        ALL_MEASURES,

        [EnumMember(Value = "ARCHIVAL_COMPLIANCE_RATE")]
        ARCHIVAL_COMPLIANCE_RATE,

        [EnumMember(Value = "ARCHIVAL_SNAPSHOT_LAG_COUNT")]
        ARCHIVAL_SNAPSHOT_LAG_COUNT,

        [EnumMember(Value = "ARCHIVE_COUNT")]
        ARCHIVE_COUNT,

        [EnumMember(Value = "ARCHIVE_DATA_REDUCTION")]
        ARCHIVE_DATA_REDUCTION,

        [EnumMember(Value = "ARCHIVE_DEDUP_RATIO")]
        ARCHIVE_DEDUP_RATIO,

        [EnumMember(Value = "ARCHIVE_EVENT_COUNT")]
        ARCHIVE_EVENT_COUNT,

        [EnumMember(Value = "ARCHIVE_GROWTH")]
        ARCHIVE_GROWTH,

        [EnumMember(Value = "ARCHIVE_INGESTED_BYTES")]
        ARCHIVE_INGESTED_BYTES,

        [EnumMember(Value = "ARCHIVE_IN_COMPLIANCE_COUNT")]
        ARCHIVE_IN_COMPLIANCE_COUNT,

        [EnumMember(Value = "ARCHIVE_LOGICAL_BYTES")]
        ARCHIVE_LOGICAL_BYTES,

        [EnumMember(Value = "ARCHIVE_LOGICAL_DATA_REDUCTION")]
        ARCHIVE_LOGICAL_DATA_REDUCTION,

        [EnumMember(Value = "ARCHIVE_LOGICAL_DEDUP_RATIO")]
        ARCHIVE_LOGICAL_DEDUP_RATIO,

        [EnumMember(Value = "ARCHIVE_OUT_OF_COMPLIANCE_COUNT")]
        ARCHIVE_OUT_OF_COMPLIANCE_COUNT,

        [EnumMember(Value = "ARCHIVE_SNAPSHOT_COUNT")]
        ARCHIVE_SNAPSHOT_COUNT,

        [EnumMember(Value = "ARCHIVE_STORAGE")]
        ARCHIVE_STORAGE,

        [EnumMember(Value = "BACKUP_COUNT")]
        BACKUP_COUNT,

        [EnumMember(Value = "BACKUP_EVENT_COUNT")]
        BACKUP_EVENT_COUNT,

        [EnumMember(Value = "BACK_UP_COMPLIANCE_RATE")]
        BACK_UP_COMPLIANCE_RATE,

        [EnumMember(Value = "CANCELED_TASK_COUNT")]
        CANCELED_TASK_COUNT,

        [EnumMember(Value = "CLUSTER_COUNT")]
        CLUSTER_COUNT,

        [EnumMember(Value = "DATA_TRANSFERRED")]
        DATA_TRANSFERRED,

        [EnumMember(Value = "DATA_TRANSFERRED_OVER_WIRE")]
        DATA_TRANSFERRED_OVER_WIRE,

        [EnumMember(Value = "DISK_CAPACITY")]
        DISK_CAPACITY,

        [EnumMember(Value = "DISK_COUNT")]
        DISK_COUNT,

        [EnumMember(Value = "DISK_USED")]
        DISK_USED,

        [EnumMember(Value = "DONT_PROTECT_OBJECT_COUNT")]
        DONT_PROTECT_OBJECT_COUNT,

        [EnumMember(Value = "EVENT_COUNT")]
        EVENT_COUNT,

        [EnumMember(Value = "EXPECTED_TASK_COUNT")]
        EXPECTED_TASK_COUNT,

        [EnumMember(Value = "FAILED_TASK_COUNT")]
        FAILED_TASK_COUNT,

        [EnumMember(Value = "FOREST_RECOVERY_COUNT")]
        FOREST_RECOVERY_COUNT,

        [EnumMember(Value = "HASH_MATCHES_LIST")]
        HASH_MATCHES_LIST,

        [EnumMember(Value = "HASH_MATCH_COUNT")]
        HASH_MATCH_COUNT,

        [EnumMember(Value = "IN_COMPLIANCE_COUNT")]
        IN_COMPLIANCE_COUNT,

        [EnumMember(Value = "LAST_SNAPSHOT_LOGICAL_BYTES")]
        LAST_SNAPSHOT_LOGICAL_BYTES,

        [EnumMember(Value = "LOCAL_CDP_LOG_STORAGE")]
        LOCAL_CDP_LOG_STORAGE,

        [EnumMember(Value = "LOCAL_CDP_THROUGHPUT")]
        LOCAL_CDP_THROUGHPUT,

        [EnumMember(Value = "LOCAL_DATA_REDUCTION")]
        LOCAL_DATA_REDUCTION,

        [EnumMember(Value = "LOCAL_DEDUP_RATIO")]
        LOCAL_DEDUP_RATIO,

        [EnumMember(Value = "LOCAL_EFFECTIVE_STORAGE")]
        LOCAL_EFFECTIVE_STORAGE,

        [EnumMember(Value = "LOCAL_GROWTH")]
        LOCAL_GROWTH,

        [EnumMember(Value = "LOCAL_INDEXED_SNAPSHOT_COUNT")]
        LOCAL_INDEXED_SNAPSHOT_COUNT,

        [EnumMember(Value = "LOCAL_LOGICAL_DATA_REDUCTION")]
        LOCAL_LOGICAL_DATA_REDUCTION,

        [EnumMember(Value = "LOCAL_LOGICAL_DEDUP_RATIO")]
        LOCAL_LOGICAL_DEDUP_RATIO,

        [EnumMember(Value = "LOCAL_METERED_DATA")]
        LOCAL_METERED_DATA,

        [EnumMember(Value = "LOCAL_ON_DEMAND_SNAPSHOT_COUNT")]
        LOCAL_ON_DEMAND_SNAPSHOT_COUNT,

        [EnumMember(Value = "LOCAL_PENDING_INDEX_SNAPSHOT_COUNT")]
        LOCAL_PENDING_INDEX_SNAPSHOT_COUNT,

        [EnumMember(Value = "LOCAL_PROTECTED_DATA")]
        LOCAL_PROTECTED_DATA,

        [EnumMember(Value = "LOCAL_SLA_DOMAIN_SNAPSHOT_COUNT")]
        LOCAL_SLA_DOMAIN_SNAPSHOT_COUNT,

        [EnumMember(Value = "LOCAL_SNAPSHOT_COUNT")]
        LOCAL_SNAPSHOT_COUNT,

        [EnumMember(Value = "LOCAL_STORAGE")]
        LOCAL_STORAGE,

        [EnumMember(Value = "LOCAL_UNINDEXED_SNAPSHOT_COUNT")]
        LOCAL_UNINDEXED_SNAPSHOT_COUNT,

        [EnumMember(Value = "LOGICAL_BYTES")]
        LOGICAL_BYTES,

        [EnumMember(Value = "MATCHED_FILES")]
        MATCHED_FILES,

        [EnumMember(Value = "MEASURE_UNSPECIFIED")]
        MEASURE_UNSPECIFIED,

        [EnumMember(Value = "MIN_CREATED_AT")]
        MIN_CREATED_AT,

        [EnumMember(Value = "MISSED_REPLICATION_SNAPSHOT_COUNT")]
        MISSED_REPLICATION_SNAPSHOT_COUNT,

        [EnumMember(Value = "MISSED_SNAPSHOT_COUNT")]
        MISSED_SNAPSHOT_COUNT,

        [EnumMember(Value = "MISSED_TASK_COUNT")]
        MISSED_TASK_COUNT,

        [EnumMember(Value = "NO_SLA_DOMAIN_OBJECT_COUNT")]
        NO_SLA_DOMAIN_OBJECT_COUNT,

        [EnumMember(Value = "OBJECT_COUNT")]
        OBJECT_COUNT,

        [EnumMember(Value = "OBJECT_COUNT_BY_COMPLIANCE_STATUS")]
        OBJECT_COUNT_BY_COMPLIANCE_STATUS,

        [EnumMember(Value = "OBJECT_COUNT_BY_PROTECTION_STATUS")]
        OBJECT_COUNT_BY_PROTECTION_STATUS,

        [EnumMember(Value = "OUT_OF_COMPLIANCE_COUNT")]
        OUT_OF_COMPLIANCE_COUNT,

        [EnumMember(Value = "PHYSICAL_BYTES")]
        PHYSICAL_BYTES,

        [EnumMember(Value = "PROTECTED_OBJECT_COUNT")]
        PROTECTED_OBJECT_COUNT,

        [EnumMember(Value = "PROVISIONED_SIZE")]
        PROVISIONED_SIZE,

        [EnumMember(Value = "READABLE_SNAPSHOT_COUNT")]
        READABLE_SNAPSHOT_COUNT,

        [EnumMember(Value = "RECOVERY_COUNT")]
        RECOVERY_COUNT,

        [EnumMember(Value = "RECOVERY_EVENT_COUNT")]
        RECOVERY_EVENT_COUNT,

        [EnumMember(Value = "REPLICATION_COMPLIANCE_RATE")]
        REPLICATION_COMPLIANCE_RATE,

        [EnumMember(Value = "REPLICATION_COUNT")]
        REPLICATION_COUNT,

        [EnumMember(Value = "REPLICATION_DATA_LAG_COUNT")]
        REPLICATION_DATA_LAG_COUNT,

        [EnumMember(Value = "REPLICATION_EVENT_COUNT")]
        REPLICATION_EVENT_COUNT,

        [EnumMember(Value = "REPLICATION_IN_COMPLIANCE_COUNT")]
        REPLICATION_IN_COMPLIANCE_COUNT,

        [EnumMember(Value = "REPLICATION_OUT_OF_COMPLIANCE_COUNT")]
        REPLICATION_OUT_OF_COMPLIANCE_COUNT,

        [EnumMember(Value = "REPLICATION_SNAPSHOT_LAG_COUNT")]
        REPLICATION_SNAPSHOT_LAG_COUNT,

        [EnumMember(Value = "REPLICA_GROWTH")]
        REPLICA_GROWTH,

        [EnumMember(Value = "REPLICA_SNAPSHOT_COUNT")]
        REPLICA_SNAPSHOT_COUNT,

        [EnumMember(Value = "REPLICA_STORAGE")]
        REPLICA_STORAGE,

        [EnumMember(Value = "SENSITIVE_FILES")]
        SENSITIVE_FILES,

        [EnumMember(Value = "SENSITIVE_HITS")]
        SENSITIVE_HITS,

        [EnumMember(Value = "SOURCE_SIZE")]
        SOURCE_SIZE,

        [EnumMember(Value = "SUCCEEDED_TASK_COUNT")]
        SUCCEEDED_TASK_COUNT,

        [EnumMember(Value = "SUCCEEDED_WITH_WARNINGS_TASK_COUNT")]
        SUCCEEDED_WITH_WARNINGS_TASK_COUNT,

        [EnumMember(Value = "SUCCESS_RATE")]
        SUCCESS_RATE,

        [EnumMember(Value = "TARGET_SIZE")]
        TARGET_SIZE,

        [EnumMember(Value = "TASK_COUNT")]
        TASK_COUNT,

        [EnumMember(Value = "TASK_COUNT_BY_TASK_STATUS")]
        TASK_COUNT_BY_TASK_STATUS,

        [EnumMember(Value = "TASK_DURATION")]
        TASK_DURATION,

        [EnumMember(Value = "THREAT_FAMILIES_LIST")]
        THREAT_FAMILIES_LIST,

        [EnumMember(Value = "TOTAL_COMPLIANCE_RATE")]
        TOTAL_COMPLIANCE_RATE,

        [EnumMember(Value = "TOTAL_FILES_TRANSFERRED")]
        TOTAL_FILES_TRANSFERRED,

        [EnumMember(Value = "TOTAL_SNAPSHOT_COUNT")]
        TOTAL_SNAPSHOT_COUNT,

        [EnumMember(Value = "TRANSFERRED_BYTES")]
        TRANSFERRED_BYTES,

        [EnumMember(Value = "UNREADABLE_OBJECT_COUNT")]
        UNREADABLE_OBJECT_COUNT,

        [EnumMember(Value = "USED_BYTES")]
        USED_BYTES,

        [EnumMember(Value = "VIOLATIONS_COUNT")]
        VIOLATIONS_COUNT,

        [EnumMember(Value = "YARA_MATCHES_LIST")]
        YARA_MATCHES_LIST,

        [EnumMember(Value = "YARA_MATCH_COUNT")]
        YARA_MATCH_COUNT


    } // enum ReportMeasure

} // namespace RubrikSecurityCloud.Types