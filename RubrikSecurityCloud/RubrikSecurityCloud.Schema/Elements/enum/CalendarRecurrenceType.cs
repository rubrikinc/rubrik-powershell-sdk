// CalendarRecurrenceType.cs
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
    public enum CalendarRecurrenceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "RECURRING")]
        RECURRING,

        [EnumMember(Value = "SINGLE")]
        SINGLE


    } // enum CalendarRecurrenceType

} // namespace RubrikSecurityCloud.Types