// TimeUnitEnum.cs
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
    public enum TimeUnitEnum
    {
        [EnumMember(Value = "Day")]
        DAY,

        [EnumMember(Value = "Hour")]
        HOUR,

        [EnumMember(Value = "Month")]
        MONTH,

        [EnumMember(Value = "Quarter")]
        QUARTER,

        [EnumMember(Value = "Week")]
        WEEK,

        [EnumMember(Value = "Year")]
        YEAR


    } // enum TimeUnitEnum

} // namespace Rubrik.SecurityCloud.Types