// CopyScheduleFrequency.cs
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
    public enum CopyScheduleFrequency
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "COPY_SCHEDULE_FREQUENCY_DAILY")]
        COPY_SCHEDULE_FREQUENCY_DAILY,

        [EnumMember(Value = "COPY_SCHEDULE_FREQUENCY_HOURLY")]
        COPY_SCHEDULE_FREQUENCY_HOURLY,

        [EnumMember(Value = "COPY_SCHEDULE_FREQUENCY_MONTHLY")]
        COPY_SCHEDULE_FREQUENCY_MONTHLY,

        [EnumMember(Value = "COPY_SCHEDULE_FREQUENCY_UNSPECIFIED")]
        COPY_SCHEDULE_FREQUENCY_UNSPECIFIED,

        [EnumMember(Value = "COPY_SCHEDULE_FREQUENCY_WEEKLY")]
        COPY_SCHEDULE_FREQUENCY_WEEKLY


    } // enum CopyScheduleFrequency

} // namespace RubrikSecurityCloud.Types