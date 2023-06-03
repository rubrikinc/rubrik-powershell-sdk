// ChartViewType.cs
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
    public enum ChartViewType
    {
        [EnumMember(Value = "CHART_UNSPECIFIED")]
        CHART_UNSPECIFIED,

        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_LOCAL_DATA_STORE_CHART")]
        OBJECT_CAPACITY_OVERTIME_LOCAL_DATA_STORE_CHART,

        [EnumMember(Value = "OBJECT_CAPACITY_OVERTIME_PROTECTED_OBJECTS_COUNT_CHART")]
        OBJECT_CAPACITY_OVERTIME_PROTECTED_OBJECTS_COUNT_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_ALL_CHART")]
        PROTECTION_TASKS_ALL_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_CLUSTER_CHART")]
        PROTECTION_TASKS_CLUSTER_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_CLUSTER_TYPE_CHART")]
        PROTECTION_TASKS_CLUSTER_TYPE_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_OBJECT_TYPE_CHART")]
        PROTECTION_TASKS_OBJECT_TYPE_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_STATUS_CHART")]
        PROTECTION_TASKS_STATUS_CHART,

        [EnumMember(Value = "PROTECTION_TASKS_TIME_CHART")]
        PROTECTION_TASKS_TIME_CHART


    } // enum ChartViewType

} // namespace Rubrik.SecurityCloud.Types