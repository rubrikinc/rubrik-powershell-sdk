// DayOfWeek.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:11.
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
    public enum DayOfWeek
    {
        [EnumMember(Value = "FRIDAY")]
        FRIDAY,

        [EnumMember(Value = "MONDAY")]
        MONDAY,

        [EnumMember(Value = "SATURDAY")]
        SATURDAY,

        [EnumMember(Value = "SUNDAY")]
        SUNDAY,

        [EnumMember(Value = "THURSDAY")]
        THURSDAY,

        [EnumMember(Value = "TUESDAY")]
        TUESDAY,

        [EnumMember(Value = "WEDNESDAY")]
        WEDNESDAY


    } // enum DayOfWeek

} // namespace Rubrik.SecurityCloud.Types