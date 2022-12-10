// RetentionUnit.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:03.
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
    public enum RetentionUnit
    {
        [EnumMember(Value = "DAYS")]
        DAYS,

        [EnumMember(Value = "HOURS")]
        HOURS,

        [EnumMember(Value = "MINUTES")]
        MINUTES,

        [EnumMember(Value = "MONTHS")]
        MONTHS,

        [EnumMember(Value = "QUARTERS")]
        QUARTERS,

        [EnumMember(Value = "WEEKS")]
        WEEKS,

        [EnumMember(Value = "YEARS")]
        YEARS


    } // enum RetentionUnit

} // namespace Rubrik.SecurityCloud.Types