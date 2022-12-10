// DataViewTypeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:59.
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
    public enum DataViewTypeEnum
    {
        [EnumMember(Value = "BACKUP_COMPLIANCE")]
        BACKUP_COMPLIANCE,

        [EnumMember(Value = "CDM_UPGRADES")]
        CDM_UPGRADES,

        [EnumMember(Value = "GLOBAL_OBJECT")]
        GLOBAL_OBJECT,

        [EnumMember(Value = "GLOBAL_OBJECT_SUMMARY_DAILY")]
        GLOBAL_OBJECT_SUMMARY_DAILY,

        [EnumMember(Value = "GLOBAL_OBJECT_SUMMARY_MONTHLY")]
        GLOBAL_OBJECT_SUMMARY_MONTHLY,

        [EnumMember(Value = "INDEXING")]
        INDEXING,

        [EnumMember(Value = "MONITORING_ALL")]
        MONITORING_ALL,

        [EnumMember(Value = "MONITORING_CANCELED")]
        MONITORING_CANCELED,

        [EnumMember(Value = "MONITORING_COMPLETED")]
        MONITORING_COMPLETED,

        [EnumMember(Value = "MONITORING_FAILED")]
        MONITORING_FAILED,

        [EnumMember(Value = "MONITORING_IN_PROGRESS")]
        MONITORING_IN_PROGRESS,

        [EnumMember(Value = "MONITORING_RETRYABLE_CANCELED")]
        MONITORING_RETRYABLE_CANCELED,

        [EnumMember(Value = "MONITORING_RETRYABLE_FAILED")]
        MONITORING_RETRYABLE_FAILED,

        [EnumMember(Value = "MONITORING_SCHEDULED")]
        MONITORING_SCHEDULED,

        [EnumMember(Value = "MONITORING_TASK_COUNT_TIME_SERIES")]
        MONITORING_TASK_COUNT_TIME_SERIES,

        [EnumMember(Value = "OBJECT_AUDIT_DETAIL")]
        OBJECT_AUDIT_DETAIL,

        [EnumMember(Value = "OBJECT_AUDIT_LIST")]
        OBJECT_AUDIT_LIST,

        [EnumMember(Value = "PROTECTION_TASK_DETAILS")]
        PROTECTION_TASK_DETAILS,

        [EnumMember(Value = "SLA_AUDIT_DETAIL")]
        SLA_AUDIT_DETAIL,

        [EnumMember(Value = "SLA_AUDIT_LIST")]
        SLA_AUDIT_LIST,

        [EnumMember(Value = "SLA_COMPLIANCE")]
        SLA_COMPLIANCE,

        [EnumMember(Value = "TASK_DETAILS")]
        TASK_DETAILS


    } // enum DataViewTypeEnum

} // namespace Rubrik.SecurityCloud.Types