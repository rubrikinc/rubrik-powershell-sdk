// GroupByFieldEnum.cs
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
    public enum GroupByFieldEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ANALYZER")]
        ANALYZER,

        [EnumMember(Value = "CLUSTER")]
        CLUSTER,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "ComplianceStatus")]
        COMPLIANCE_STATUS,

        [EnumMember(Value = "DAY")]
        DAY,

        [EnumMember(Value = "FILE")]
        FILE,

        [EnumMember(Value = "FailoverStatus")]
        FAILOVER_STATUS,

        [EnumMember(Value = "FailoverType")]
        FAILOVER_TYPE,

        [EnumMember(Value = "HOUR")]
        HOUR,

        [EnumMember(Value = "IS_ANOMALY")]
        IS_ANOMALY,

        [EnumMember(Value = "LastActivityStatus")]
        LAST_ACTIVITY_STATUS,

        [EnumMember(Value = "LastActivityType")]
        LAST_ACTIVITY_TYPE,

        [EnumMember(Value = "LastTestStatus")]
        LAST_TEST_STATUS,

        [EnumMember(Value = "MANAGED_ID")]
        MANAGED_ID,

        [EnumMember(Value = "MONTH")]
        MONTH,

        [EnumMember(Value = "OBJECT_NAME")]
        OBJECT_NAME,

        [EnumMember(Value = "Object")]
        OBJECT,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "POLICY")]
        POLICY,

        [EnumMember(Value = "POLICY_VIOLATIONS")]
        POLICY_VIOLATIONS,

        [EnumMember(Value = "ProtectionStatus")]
        PROTECTION_STATUS,

        [EnumMember(Value = "PullTimeWithOffset")]
        PULL_TIME_WITH_OFFSET,

        [EnumMember(Value = "Quarter")]
        QUARTER,

        [EnumMember(Value = "SEVERITY")]
        SEVERITY,

        [EnumMember(Value = "SLA_DOMAIN")]
        SLA_DOMAIN,

        [EnumMember(Value = "STATUS_POLICY")]
        STATUS_POLICY,

        [EnumMember(Value = "Source")]
        SOURCE,

        [EnumMember(Value = "Status")]
        STATUS,

        [EnumMember(Value = "TIME")]
        TIME,

        [EnumMember(Value = "TIME_ISSUES")]
        TIME_ISSUES,

        [EnumMember(Value = "TIME_VIOLATIONS")]
        TIME_VIOLATIONS,

        [EnumMember(Value = "TRANSFERRED_BYTES_OBJECT_TYPE")]
        TRANSFERRED_BYTES_OBJECT_TYPE,

        [EnumMember(Value = "TargetSite")]
        TARGET_SITE,

        [EnumMember(Value = "TaskDetailClusterType")]
        TASK_DETAIL_CLUSTER_TYPE,

        [EnumMember(Value = "TaskDetailObjectType")]
        TASK_DETAIL_OBJECT_TYPE,

        [EnumMember(Value = "Type")]
        TYPE,

        [EnumMember(Value = "UserAuditStatus")]
        USER_AUDIT_STATUS,

        [EnumMember(Value = "UserAuditType")]
        USER_AUDIT_TYPE,

        [EnumMember(Value = "WEEK")]
        WEEK,

        [EnumMember(Value = "YEAR")]
        YEAR


    } // enum GroupByFieldEnum

} // namespace RubrikSecurityCloud.Types