// SlaTimeUnit.cs
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
    public enum SlaTimeUnit
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SLA_TIME_UNIT_DAILY")]
        SLA_TIME_UNIT_DAILY,

        [EnumMember(Value = "SLA_TIME_UNIT_HOURLY")]
        SLA_TIME_UNIT_HOURLY,

        [EnumMember(Value = "SLA_TIME_UNIT_MINUTE")]
        SLA_TIME_UNIT_MINUTE,

        [EnumMember(Value = "SLA_TIME_UNIT_MONTHLY")]
        SLA_TIME_UNIT_MONTHLY,

        [EnumMember(Value = "SLA_TIME_UNIT_QUARTERLY")]
        SLA_TIME_UNIT_QUARTERLY,

        [EnumMember(Value = "SLA_TIME_UNIT_WEEKLY")]
        SLA_TIME_UNIT_WEEKLY,

        [EnumMember(Value = "SLA_TIME_UNIT_YEARLY")]
        SLA_TIME_UNIT_YEARLY


    } // enum SlaTimeUnit

} // namespace RubrikSecurityCloud.Types