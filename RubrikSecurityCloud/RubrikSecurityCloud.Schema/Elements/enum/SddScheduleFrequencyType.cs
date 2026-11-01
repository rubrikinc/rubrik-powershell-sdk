// SddScheduleFrequencyType.cs
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
    public enum SddScheduleFrequencyType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DAILY")]
        DAILY,

        [EnumMember(Value = "FREQUENCY_TYPE_UNSPECIFIED")]
        FREQUENCY_TYPE_UNSPECIFIED,

        [EnumMember(Value = "HOURLY")]
        HOURLY,

        [EnumMember(Value = "MONTHLY")]
        MONTHLY,

        [EnumMember(Value = "QUARTERLY")]
        QUARTERLY,

        [EnumMember(Value = "WEEKLY")]
        WEEKLY,

        [EnumMember(Value = "YEARLY")]
        YEARLY


    } // enum SddScheduleFrequencyType

} // namespace RubrikSecurityCloud.Types