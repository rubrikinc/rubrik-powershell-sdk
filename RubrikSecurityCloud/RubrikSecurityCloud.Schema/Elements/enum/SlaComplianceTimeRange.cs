// SlaComplianceTimeRange.cs
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
    public enum SlaComplianceTimeRange
    {
        [EnumMember(Value = "LAST_24_HOURS")]
        LAST_24_HOURS,

        [EnumMember(Value = "LAST_2_SNAPSHOTS")]
        LAST_2_SNAPSHOTS,

        [EnumMember(Value = "LAST_3_SNAPSHOTS")]
        LAST_3_SNAPSHOTS,

        [EnumMember(Value = "LAST_SNAPSHOT")]
        LAST_SNAPSHOT,

        [EnumMember(Value = "PAST_30_DAYS")]
        PAST_30_DAYS,

        [EnumMember(Value = "PAST_365_DAYS")]
        PAST_365_DAYS,

        [EnumMember(Value = "PAST_7_DAYS")]
        PAST_7_DAYS,

        [EnumMember(Value = "PAST_90_DAYS")]
        PAST_90_DAYS,

        [EnumMember(Value = "SINCE_PROTECTION")]
        SINCE_PROTECTION


    } // enum SlaComplianceTimeRange

} // namespace Rubrik.SecurityCloud.Types