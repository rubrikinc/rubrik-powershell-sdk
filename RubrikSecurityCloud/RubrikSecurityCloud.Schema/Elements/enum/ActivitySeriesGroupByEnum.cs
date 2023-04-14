// ActivitySeriesGroupByEnum.cs
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
    public enum ActivitySeriesGroupByEnum
    {
        [EnumMember(Value = "Cluster")]
        CLUSTER,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "Day")]
        DAY,

        [EnumMember(Value = "Hour")]
        HOUR,

        [EnumMember(Value = "LastActivityStatus")]
        LAST_ACTIVITY_STATUS,

        [EnumMember(Value = "LastActivityType")]
        LAST_ACTIVITY_TYPE,

        [EnumMember(Value = "Month")]
        MONTH,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "Quarter")]
        QUARTER,

        [EnumMember(Value = "Week")]
        WEEK,

        [EnumMember(Value = "Year")]
        YEAR


    } // enum ActivitySeriesGroupByEnum

} // namespace Rubrik.SecurityCloud.Types