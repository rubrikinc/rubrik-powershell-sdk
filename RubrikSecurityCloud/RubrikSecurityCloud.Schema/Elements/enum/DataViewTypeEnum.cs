// DataViewTypeEnum.cs
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
    public enum DataViewTypeEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVITY_SERIES")]
        ACTIVITY_SERIES,

        [EnumMember(Value = "ANOMALIES")]
        ANOMALIES,

        [EnumMember(Value = "AUDIT_LIST")]
        AUDIT_LIST,

        [EnumMember(Value = "BACKUP_COMPLIANCE")]
        BACKUP_COMPLIANCE,

        [EnumMember(Value = "BACKUP_STRIKES")]
        BACKUP_STRIKES,

        [EnumMember(Value = "CDM_UPGRADES")]
        CDM_UPGRADES,

        [EnumMember(Value = "CLUSTERS")]
        CLUSTERS,

        [EnumMember(Value = "DATAGOV_TIMELINE")]
        DATAGOV_TIMELINE,

        [EnumMember(Value = "EVENT_SERIES")]
        EVENT_SERIES,

        [EnumMember(Value = "GLOBAL_OBJECT")]
        GLOBAL_OBJECT,

        [EnumMember(Value = "GLOBAL_OBJECT_SUMMARY_DAILY")]
        GLOBAL_OBJECT_SUMMARY_DAILY,

        [EnumMember(Value = "GLOBAL_OBJECT_SUMMARY_MONTHLY")]
        GLOBAL_OBJECT_SUMMARY_MONTHLY,

        [EnumMember(Value = "IDENTITY_RISKS")]
        IDENTITY_RISKS,

        [EnumMember(Value = "INDEXING")]
        INDEXING,

        [EnumMember(Value = "LATEST_GLOBAL_OBJECTS")]
        LATEST_GLOBAL_OBJECTS,

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

        [EnumMember(Value = "NF_ANOMALIES")]
        NF_ANOMALIES,

        [EnumMember(Value = "OBJECT_AUDIT_DETAIL")]
        OBJECT_AUDIT_DETAIL,

        [EnumMember(Value = "OBJECT_AUDIT_LIST")]
        OBJECT_AUDIT_LIST,

        [EnumMember(Value = "OBJECT_BACKUP_TASK_SUMMARY")]
        OBJECT_BACKUP_TASK_SUMMARY,

        [EnumMember(Value = "OBJECT_PROTECTION_AUDIT_DETAIL")]
        OBJECT_PROTECTION_AUDIT_DETAIL,

        [EnumMember(Value = "OBJECT_PROTECTION_AUDIT_LIST")]
        OBJECT_PROTECTION_AUDIT_LIST,

        [EnumMember(Value = "OBJECT_PROTECTION_AUDIT_LIST_EXPORT")]
        OBJECT_PROTECTION_AUDIT_LIST_EXPORT,

        [EnumMember(Value = "PHYSICAL_HOSTS")]
        PHYSICAL_HOSTS,

        [EnumMember(Value = "PROTECTION_TASK_DETAILS")]
        PROTECTION_TASK_DETAILS,

        [EnumMember(Value = "QAUTH_OBJECTS")]
        QAUTH_OBJECTS,

        [EnumMember(Value = "QAUTH_ROLES")]
        QAUTH_ROLES,

        [EnumMember(Value = "ROLE_LIST")]
        ROLE_LIST,

        [EnumMember(Value = "SERVICE_ACCOUNT")]
        SERVICE_ACCOUNT,

        [EnumMember(Value = "SLA_AUDIT_DETAIL")]
        SLA_AUDIT_DETAIL,

        [EnumMember(Value = "SLA_AUDIT_DETAIL_NG")]
        SLA_AUDIT_DETAIL_NG,

        [EnumMember(Value = "SLA_AUDIT_LIST")]
        SLA_AUDIT_LIST,

        [EnumMember(Value = "SLA_AUDIT_LIST_NG")]
        SLA_AUDIT_LIST_NG,

        [EnumMember(Value = "SLA_COMPLIANCE")]
        SLA_COMPLIANCE,

        [EnumMember(Value = "SSO_GROUP")]
        SSO_GROUP,

        [EnumMember(Value = "TASK_DETAILS")]
        TASK_DETAILS,

        [EnumMember(Value = "THREAT_MONITORING_LIST")]
        THREAT_MONITORING_LIST,

        [EnumMember(Value = "THREAT_MONITORING_SNAPSHOT_RESULTS")]
        THREAT_MONITORING_SNAPSHOT_RESULTS,

        [EnumMember(Value = "USERS")]
        USERS


    } // enum DataViewTypeEnum

} // namespace RubrikSecurityCloud.Types