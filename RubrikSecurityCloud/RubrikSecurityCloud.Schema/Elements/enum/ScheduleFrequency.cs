// ScheduleFrequency.cs
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
    public enum ScheduleFrequency
    {
        [EnumMember(Value = "MONTHLY")]
        MONTHLY,

        [EnumMember(Value = "NEVER")]
        NEVER,

        [EnumMember(Value = "QUARTERLY")]
        QUARTERLY,

        [EnumMember(Value = "WEEKLY")]
        WEEKLY


    } // enum ScheduleFrequency

} // namespace RubrikSecurityCloud.Types