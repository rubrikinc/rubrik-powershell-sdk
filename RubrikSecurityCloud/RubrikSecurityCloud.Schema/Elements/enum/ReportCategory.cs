// ReportCategory.cs
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
    public enum ReportCategory
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AUDIT_AND_COMPLIANCE")]
        AUDIT_AND_COMPLIANCE,

        [EnumMember(Value = "CAPACITY_MANAGEMENT")]
        CAPACITY_MANAGEMENT,

        [EnumMember(Value = "HEALTH_AND_PERFORMANCE")]
        HEALTH_AND_PERFORMANCE,

        [EnumMember(Value = "OTHERS")]
        OTHERS,

        [EnumMember(Value = "REPORT_CATEGORY_UNSPECIFIED")]
        REPORT_CATEGORY_UNSPECIFIED,

        [EnumMember(Value = "USERS_AND_ORG_MANAGEMENT")]
        USERS_AND_ORG_MANAGEMENT


    } // enum ReportCategory

} // namespace RubrikSecurityCloud.Types