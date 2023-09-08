// PolarisReportViewType.cs
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
    public enum PolarisReportViewType
    {
        [EnumMember(Value = "ANOMALY_REPORT")]
        ANOMALY_REPORT,

        [EnumMember(Value = "COMPLIANCE_REPORT")]
        COMPLIANCE_REPORT,

        [EnumMember(Value = "EVENTS_REPORT")]
        EVENTS_REPORT,

        [EnumMember(Value = "FAILOVER_REPORT")]
        FAILOVER_REPORT,

        [EnumMember(Value = "INDEXING_REPORT")]
        INDEXING_REPORT,

        [EnumMember(Value = "INFRASTRUCTURE_REPORT")]
        INFRASTRUCTURE_REPORT,

        [EnumMember(Value = "OBJECT_AUDIT_REPORT")]
        OBJECT_AUDIT_REPORT,

        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_REPORT")]
        OBJECT_CAPACITY_OVERTIME_REPORT,

        [EnumMember(Value = "OBJECT_CAPACITY_REPORT")]
        OBJECT_CAPACITY_REPORT,

        [EnumMember(Value = "PROTECTION_REPORT")]
        PROTECTION_REPORT,

        [EnumMember(Value = "PROTECTION_TASKS_DETAIL_REPORT")]
        PROTECTION_TASKS_DETAIL_REPORT,

        [EnumMember(Value = "QAUTH_OBJECTS_REPORT")]
        QAUTH_OBJECTS_REPORT,

        [EnumMember(Value = "QAUTH_ROLES_REPORT")]
        QAUTH_ROLES_REPORT,

        [EnumMember(Value = "RADAR_REPORT")]
        RADAR_REPORT,

        [EnumMember(Value = "RECOVERY_TASKS_DETAIL_REPORT")]
        RECOVERY_TASKS_DETAIL_REPORT,

        [EnumMember(Value = "REPORT_UNSPECIFIED")]
        REPORT_UNSPECIFIED,

        [EnumMember(Value = "SLA_AUDIT_REPORT")]
        SLA_AUDIT_REPORT,

        [EnumMember(Value = "SONAR_CONTENT")]
        SONAR_CONTENT,

        [EnumMember(Value = "SONAR_REPORT")]
        SONAR_REPORT,

        [EnumMember(Value = "TASK_SUMMARY_REPORT")]
        TASK_SUMMARY_REPORT,

        [EnumMember(Value = "THREAT_MONITORING_REPORT")]
        THREAT_MONITORING_REPORT


    } // enum PolarisReportViewType

} // namespace RubrikSecurityCloud.Types