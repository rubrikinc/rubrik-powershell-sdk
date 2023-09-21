// ComplianceDuration.cs
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
    public enum ComplianceDuration
    {
        [EnumMember(Value = "COMPLIANCE_DURATION_UNSPECIFIED")]
        COMPLIANCE_DURATION_UNSPECIFIED,

        [EnumMember(Value = "LAST_12_MONTHS")]
        LAST_12_MONTHS,

        [EnumMember(Value = "LAST_24_HOURS")]
        LAST_24_HOURS,

        [EnumMember(Value = "LAST_30_DAYS")]
        LAST_30_DAYS,

        [EnumMember(Value = "LAST_7_DAYS")]
        LAST_7_DAYS,

        [EnumMember(Value = "LAST_90_DAYS")]
        LAST_90_DAYS,

        [EnumMember(Value = "START_OF_PROTECTION")]
        START_OF_PROTECTION


    } // enum ComplianceDuration

} // namespace RubrikSecurityCloud.Types