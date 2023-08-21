// PastDurationEnum.cs
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
    public enum PastDurationEnum
    {
        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "PAST_12_MONTHS")]
        PAST_12_MONTHS,

        [EnumMember(Value = "PAST_24_HOURS")]
        PAST_24_HOURS,

        [EnumMember(Value = "PAST_30_DAYS")]
        PAST_30_DAYS,

        [EnumMember(Value = "PAST_3_DAYS")]
        PAST_3_DAYS,

        [EnumMember(Value = "PAST_7_DAYS")]
        PAST_7_DAYS,

        [EnumMember(Value = "PAST_90_DAYS")]
        PAST_90_DAYS,

        [EnumMember(Value = "START_OF_PROTECTION")]
        START_OF_PROTECTION


    } // enum PastDurationEnum

} // namespace RubrikSecurityCloud.Types