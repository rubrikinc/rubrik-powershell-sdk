// TableViewType.cs
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
    public enum TableViewType
    {
        [EnumMember(Value = "ACTIVITY_SERIES_ALL_TABLE")]
        ACTIVITY_SERIES_ALL_TABLE,

        [EnumMember(Value = "AUDIT_ALL_TABLE")]
        AUDIT_ALL_TABLE,

        [EnumMember(Value = "COMPLIANCE_ALL_TABLE")]
        COMPLIANCE_ALL_TABLE,

        [EnumMember(Value = "COMPLIANCE_BY_CLUSTER_TABLE")]
        COMPLIANCE_BY_CLUSTER_TABLE,

        [EnumMember(Value = "COMPLIANCE_BY_CLUSTER_TYPE_TABLE")]
        COMPLIANCE_BY_CLUSTER_TYPE_TABLE,

        [EnumMember(Value = "COMPLIANCE_BY_OBJECT_TYPE_TABLE")]
        COMPLIANCE_BY_OBJECT_TYPE_TABLE,

        [EnumMember(Value = "INDEXING_REPORT_ALL_TABLE")]
        INDEXING_REPORT_ALL_TABLE,

        [EnumMember(Value = "INDEXING_REPORT_BY_LOCATION_TABLE")]
        INDEXING_REPORT_BY_LOCATION_TABLE,

        [EnumMember(Value = "INDEXING_REPORT_BY_OBJECT_TYPE_TABLE")]
        INDEXING_REPORT_BY_OBJECT_TYPE_TABLE,

        [EnumMember(Value = "INDEXING_REPORT_BY_SLA_TABLE")]
        INDEXING_REPORT_BY_SLA_TABLE,

        [EnumMember(Value = "INFRASTRUCTURE_ALL_TABLE")]
        INFRASTRUCTURE_ALL_TABLE,

        [EnumMember(Value = "OBJECT_AUDIT_DETAIL_TABLE")]
        OBJECT_AUDIT_DETAIL_TABLE,

        [EnumMember(Value = "OBJECT_AUDIT_LIST_EXPORT_TABLE")]
        OBJECT_AUDIT_LIST_EXPORT_TABLE,

        [EnumMember(Value = "OBJECT_AUDIT_LIST_TABLE")]
        OBJECT_AUDIT_LIST_TABLE,

        [EnumMember(Value = "OBJECT_BACKUP_TASK_SUMMARY_ALL_TABLE")]
        OBJECT_BACKUP_TASK_SUMMARY_ALL_TABLE,

        [EnumMember(Value = "OBJECT_CAPACITY_ALL_TABLE")]
        OBJECT_CAPACITY_ALL_TABLE,

        [EnumMember(Value = "OBJECT_CAPACITY_BY_CLUSTER_TABLE")]
        OBJECT_CAPACITY_BY_CLUSTER_TABLE,

        [EnumMember(Value = "OBJECT_CAPACITY_BY_CLUSTER_TYPE_TABLE")]
        OBJECT_CAPACITY_BY_CLUSTER_TYPE_TABLE,

        [EnumMember(Value = "OBJECT_CAPACITY_BY_OBJECT_TYPE_TABLE")]
        OBJECT_CAPACITY_BY_OBJECT_TYPE_TABLE,

        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_ALL_TABLE")]
        OBJECT_CAPACITY_OVERTIME_ALL_TABLE,

        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_BY_CLUSTER_TABLE")]
        OBJECT_CAPACITY_OVERTIME_BY_CLUSTER_TABLE,

        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_BY_TIME_TABLE")]
        OBJECT_CAPACITY_OVERTIME_BY_TIME_TABLE,

        [EnumMember(Value = "PROTECTION_ALL_TABLE")]
        PROTECTION_ALL_TABLE,

        [EnumMember(Value = "PROTECTION_BY_CLUSTER_TABLE")]
        PROTECTION_BY_CLUSTER_TABLE,

        [EnumMember(Value = "PROTECTION_BY_CLUSTER_TYPE_TABLE")]
        PROTECTION_BY_CLUSTER_TYPE_TABLE,

        [EnumMember(Value = "PROTECTION_BY_OBJECT_TYPE_TABLE")]
        PROTECTION_BY_OBJECT_TYPE_TABLE,

        [EnumMember(Value = "PROTECTION_BY_TIME_TABLE")]
        PROTECTION_BY_TIME_TABLE,

        [EnumMember(Value = "PROTECTION_TASKS_DETAIL_BY_CLUSTER_TABLE")]
        PROTECTION_TASKS_DETAIL_BY_CLUSTER_TABLE,

        [EnumMember(Value = "PROTECTION_TASKS_DETAIL_BY_CLUSTER_TYPE_TABLE")]
        PROTECTION_TASKS_DETAIL_BY_CLUSTER_TYPE_TABLE,

        [EnumMember(Value = "PROTECTION_TASKS_DETAIL_BY_OBJECT_TYPE_TABLE")]
        PROTECTION_TASKS_DETAIL_BY_OBJECT_TYPE_TABLE,

        [EnumMember(Value = "PROTECTION_TASKS_DETAIL_BY_TIME_TABLE")]
        PROTECTION_TASKS_DETAIL_BY_TIME_TABLE,

        [EnumMember(Value = "PROTECTION_TASKS_DETAIL_TABLE")]
        PROTECTION_TASKS_DETAIL_TABLE,

        [EnumMember(Value = "QAUTH_OBJECTS_ALL_TABLE")]
        QAUTH_OBJECTS_ALL_TABLE,

        [EnumMember(Value = "QAUTH_ROLES_ALL_TABLE")]
        QAUTH_ROLES_ALL_TABLE,

        [EnumMember(Value = "READABLE_SNAPSHOTS_TABLE")]
        READABLE_SNAPSHOTS_TABLE,

        [EnumMember(Value = "RECOVERY_TASKS_DETAIL_BY_CLUSTER_TABLE")]
        RECOVERY_TASKS_DETAIL_BY_CLUSTER_TABLE,

        [EnumMember(Value = "RECOVERY_TASKS_DETAIL_BY_CLUSTER_TYPE_TABLE")]
        RECOVERY_TASKS_DETAIL_BY_CLUSTER_TYPE_TABLE,

        [EnumMember(Value = "RECOVERY_TASKS_DETAIL_BY_OBJECT_TYPE_TABLE")]
        RECOVERY_TASKS_DETAIL_BY_OBJECT_TYPE_TABLE,

        [EnumMember(Value = "RECOVERY_TASKS_DETAIL_BY_TIME_TABLE")]
        RECOVERY_TASKS_DETAIL_BY_TIME_TABLE,

        [EnumMember(Value = "RECOVERY_TASKS_DETAIL_TABLE")]
        RECOVERY_TASKS_DETAIL_TABLE,

        [EnumMember(Value = "SLA_AUDIT_DETAIL_TABLE")]
        SLA_AUDIT_DETAIL_TABLE,

        [EnumMember(Value = "SLA_AUDIT_LIST_TABLE")]
        SLA_AUDIT_LIST_TABLE,

        [EnumMember(Value = "TABLE_UNSPECIFIED")]
        TABLE_UNSPECIFIED,

        [EnumMember(Value = "THREAT_MONITORING_LIST_TABLE")]
        THREAT_MONITORING_LIST_TABLE,

        [EnumMember(Value = "UNREADABLE_OBJECTS_TABLE")]
        UNREADABLE_OBJECTS_TABLE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TableViewType

} // namespace RubrikSecurityCloud.Types