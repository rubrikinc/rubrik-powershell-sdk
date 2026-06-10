// ReportAttribute.cs
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
    public enum ReportAttribute
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVITY_TYPE")]
        ACTIVITY_TYPE,

        [EnumMember(Value = "ALL_ATTRIBUTES")]
        ALL_ATTRIBUTES,

        [EnumMember(Value = "ANALYZED_SNAPSHOT")]
        ANALYZED_SNAPSHOT,

        [EnumMember(Value = "ANOMALY_DETECTION_SCAN_OUTCOME")]
        ANOMALY_DETECTION_SCAN_OUTCOME,

        [EnumMember(Value = "ANOMALY_DETECTION_UNSCANNED_REASON")]
        ANOMALY_DETECTION_UNSCANNED_REASON,

        [EnumMember(Value = "ANOMALY_STATUS")]
        ANOMALY_STATUS,

        [EnumMember(Value = "ARCHIVAL_COMPLIANCE_STATUS")]
        ARCHIVAL_COMPLIANCE_STATUS,

        [EnumMember(Value = "ARCHIVE_TARGET")]
        ARCHIVE_TARGET,

        [EnumMember(Value = "ATTRIBUTE_UNSPECIFIED")]
        ATTRIBUTE_UNSPECIFIED,

        [EnumMember(Value = "AWAITING_FIRST_FULL")]
        AWAITING_FIRST_FULL,

        [EnumMember(Value = "CLUSTER")]
        CLUSTER,

        [EnumMember(Value = "CLUSTER_LOCATION")]
        CLUSTER_LOCATION,

        [EnumMember(Value = "CLUSTER_TYPE")]
        CLUSTER_TYPE,

        [EnumMember(Value = "COMPLIANCE_STATUS")]
        COMPLIANCE_STATUS,

        [EnumMember(Value = "CURRENT_REPLICATION_TASK_STATUS")]
        CURRENT_REPLICATION_TASK_STATUS,

        [EnumMember(Value = "DATA_SOURCE")]
        DATA_SOURCE,

        [EnumMember(Value = "DIRECT_ARCHIVE")]
        DIRECT_ARCHIVE,

        [EnumMember(Value = "END_TIME")]
        END_TIME,

        [EnumMember(Value = "FAILURE_REASON")]
        FAILURE_REASON,

        [EnumMember(Value = "FOREST_NAME")]
        FOREST_NAME,

        [EnumMember(Value = "FOREST_RECOVERY_STATUS")]
        FOREST_RECOVERY_STATUS,

        [EnumMember(Value = "IOC_TYPE")]
        IOC_TYPE,

        [EnumMember(Value = "LAST_SUCCESSFUL_BACKUP")]
        LAST_SUCCESSFUL_BACKUP,

        [EnumMember(Value = "LATEST_ARCHIVAL_SNAPSHOT")]
        LATEST_ARCHIVAL_SNAPSHOT,

        [EnumMember(Value = "LATEST_LOCAL_SNAPSHOT")]
        LATEST_LOCAL_SNAPSHOT,

        [EnumMember(Value = "LATEST_REPLICATION_SNAPSHOT")]
        LATEST_REPLICATION_SNAPSHOT,

        [EnumMember(Value = "LOCATION")]
        LOCATION,

        [EnumMember(Value = "NCD_POLICY")]
        NCD_POLICY,

        [EnumMember(Value = "NCD_SITE")]
        NCD_SITE,

        [EnumMember(Value = "NCD_SNAPSHOT_TYPE")]
        NCD_SNAPSHOT_TYPE,

        [EnumMember(Value = "NODE")]
        NODE,

        [EnumMember(Value = "NO_ATTRIBUTE")]
        NO_ATTRIBUTE,

        [EnumMember(Value = "OBJECT")]
        OBJECT,

        [EnumMember(Value = "OBJECT_STATE")]
        OBJECT_STATE,

        [EnumMember(Value = "OBJECT_TYPE")]
        OBJECT_TYPE,

        [EnumMember(Value = "ORG")]
        ORG,

        [EnumMember(Value = "PROTECTED_ON")]
        PROTECTED_ON,

        [EnumMember(Value = "PROTECTED_VOLUME")]
        PROTECTED_VOLUME,

        [EnumMember(Value = "PROTECTION_STATUS")]
        PROTECTION_STATUS,

        [EnumMember(Value = "RECOVERY_POINT")]
        RECOVERY_POINT,

        [EnumMember(Value = "RECOVERY_POINT_TYPE")]
        RECOVERY_POINT_TYPE,

        [EnumMember(Value = "REPLICATION_COMPLIANCE_STATUS")]
        REPLICATION_COMPLIANCE_STATUS,

        [EnumMember(Value = "REPLICATION_SOURCE")]
        REPLICATION_SOURCE,

        [EnumMember(Value = "REPLICATION_TARGET")]
        REPLICATION_TARGET,

        [EnumMember(Value = "RISK_CATEGORY")]
        RISK_CATEGORY,

        [EnumMember(Value = "RISK_SEVERITY")]
        RISK_SEVERITY,

        [EnumMember(Value = "SEVERITY")]
        SEVERITY,

        [EnumMember(Value = "SLA")]
        SLA,

        [EnumMember(Value = "SNAPSHOT_CONSISTENCY")]
        SNAPSHOT_CONSISTENCY,

        [EnumMember(Value = "SNAPSHOT_TYPE")]
        SNAPSHOT_TYPE,

        [EnumMember(Value = "SOURCE_PROTOCOL")]
        SOURCE_PROTOCOL,

        [EnumMember(Value = "START_TIME")]
        START_TIME,

        [EnumMember(Value = "STRIKE_STATUS")]
        STRIKE_STATUS,

        [EnumMember(Value = "TASK_STATUS")]
        TASK_STATUS,

        [EnumMember(Value = "TASK_TYPE")]
        TASK_TYPE,

        [EnumMember(Value = "THREAT_MONITORING_SCAN_STATUS")]
        THREAT_MONITORING_SCAN_STATUS,

        [EnumMember(Value = "THREAT_MONITORING_UNSCANNED_REASON")]
        THREAT_MONITORING_UNSCANNED_REASON,

        [EnumMember(Value = "THREAT_STATUS")]
        THREAT_STATUS,

        [EnumMember(Value = "TIME")]
        TIME,

        [EnumMember(Value = "TIME_RANGE")]
        TIME_RANGE,

        [EnumMember(Value = "USERNAME")]
        USERNAME,

        [EnumMember(Value = "WORKLOAD_TYPE")]
        WORKLOAD_TYPE


    } // enum ReportAttribute

} // namespace RubrikSecurityCloud.Types