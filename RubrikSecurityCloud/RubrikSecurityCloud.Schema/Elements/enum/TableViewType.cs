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
        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_ALL_TABLE")]
        OBJECT_CAPACITY_OVERTIME_ALL_TABLE,

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
        THREAT_MONITORING_LIST_TABLE


    } // enum TableViewType

} // namespace RubrikSecurityCloud.Types