// ReportTemplate.cs
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
    public enum ReportTemplate
    {
        [EnumMember(Value = "CAPACITY_OVER_TIME")]
        CAPACITY_OVER_TIME,

        [EnumMember(Value = "OBJECT_INDEXING_SUMMARY")]
        OBJECT_INDEXING_SUMMARY,

        [EnumMember(Value = "OBJECT_PROTECTION_SUMMARY")]
        OBJECT_PROTECTION_SUMMARY,

        [EnumMember(Value = "OBJECT_TASK_SUMMARY")]
        OBJECT_TASK_SUMMARY,

        [EnumMember(Value = "PROTECTION_TASKS_DETAILS")]
        PROTECTION_TASKS_DETAILS,

        [EnumMember(Value = "PROTECTION_TASKS_SUMMARY")]
        PROTECTION_TASKS_SUMMARY,

        [EnumMember(Value = "RECOVERY_TASKS_DETAILS")]
        RECOVERY_TASKS_DETAILS,

        [EnumMember(Value = "SLA_COMPLIANCE_SUMMARY")]
        SLA_COMPLIANCE_SUMMARY,

        [EnumMember(Value = "SYSTEM_CAPACITY")]
        SYSTEM_CAPACITY,

        [EnumMember(Value = "TEMPLATE_UNSPECIFIED")]
        TEMPLATE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ReportTemplate

} // namespace RubrikSecurityCloud.Types