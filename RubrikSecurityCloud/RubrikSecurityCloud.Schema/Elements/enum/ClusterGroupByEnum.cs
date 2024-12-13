// ClusterGroupByEnum.cs
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
    public enum ClusterGroupByEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "Day")]
        DAY,

        [EnumMember(Value = "Hour")]
        HOUR,

        [EnumMember(Value = "Month")]
        MONTH,

        [EnumMember(Value = "Quarter")]
        QUARTER,

        [EnumMember(Value = "Type")]
        TYPE,

        [EnumMember(Value = "Week")]
        WEEK,

        [EnumMember(Value = "Year")]
        YEAR


    } // enum ClusterGroupByEnum

} // namespace RubrikSecurityCloud.Types