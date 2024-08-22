// O365CalendarSearchObjectType.cs
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
    public enum O365CalendarSearchObjectType
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "CALENDAR")]
        CALENDAR,

        [EnumMember(Value = "EVENT")]
        EVENT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum O365CalendarSearchObjectType

} // namespace RubrikSecurityCloud.Types