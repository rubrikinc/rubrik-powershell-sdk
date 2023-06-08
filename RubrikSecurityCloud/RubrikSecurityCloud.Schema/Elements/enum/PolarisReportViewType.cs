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

namespace Rubrik.SecurityCloud.Types
{
    public enum PolarisReportViewType
    {
        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_REPORT")]
        OBJECT_CAPACITY_OVERTIME_REPORT,

        [EnumMember(Value = "PROTECTION_TASKS_DETAIL_REPORT")]
        PROTECTION_TASKS_DETAIL_REPORT,

        [EnumMember(Value = "RECOVERY_TASKS_DETAIL_REPORT")]
        RECOVERY_TASKS_DETAIL_REPORT,

        [EnumMember(Value = "REPORT_UNSPECIFIED")]
        REPORT_UNSPECIFIED


    } // enum PolarisReportViewType

} // namespace Rubrik.SecurityCloud.Types