// ReportFocusEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:37.
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
    public enum ReportFocusEnum
    {
        [EnumMember(Value = "Activity")]
        ACTIVITY,

        [EnumMember(Value = "Anomaly")]
        ANOMALY,

        [EnumMember(Value = "Audit")]
        AUDIT,

        [EnumMember(Value = "Capacity")]
        CAPACITY,

        [EnumMember(Value = "Compliance")]
        COMPLIANCE,

        [EnumMember(Value = "Failover")]
        FAILOVER,

        [EnumMember(Value = "Infrastructure")]
        INFRASTRUCTURE,

        [EnumMember(Value = "Protection")]
        PROTECTION,

        [EnumMember(Value = "ProtectionTaskDetail")]
        PROTECTION_TASK_DETAIL,

        [EnumMember(Value = "RecoveryTaskDetail")]
        RECOVERY_TASK_DETAIL,

        [EnumMember(Value = "Sonar")]
        SONAR,

        [EnumMember(Value = "SonarContent")]
        SONAR_CONTENT,

        [EnumMember(Value = "TaskSummary")]
        TASK_SUMMARY


    } // enum ReportFocusEnum

} // namespace Rubrik.SecurityCloud.Types