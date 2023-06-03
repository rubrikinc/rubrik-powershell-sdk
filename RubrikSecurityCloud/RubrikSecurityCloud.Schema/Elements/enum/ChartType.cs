// ChartType.cs
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
    public enum ChartType
    {
        [EnumMember(Value = "AREA_CHART")]
        AREA_CHART,

        [EnumMember(Value = "COLUMN_CHART")]
        COLUMN_CHART,

        [EnumMember(Value = "DONUT_CHART")]
        DONUT_CHART


    } // enum ChartType

} // namespace Rubrik.SecurityCloud.Types