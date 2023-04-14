// TaskSummaryGroupByEnum.cs
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
    public enum TaskSummaryGroupByEnum
    {
        [EnumMember(Value = "Cluster")]
        CLUSTER,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "Day")]
        DAY,

        [EnumMember(Value = "Month")]
        MONTH,

        [EnumMember(Value = "Object")]
        OBJECT,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "Quarter")]
        QUARTER,

        [EnumMember(Value = "SlaDomain")]
        SLA_DOMAIN,

        [EnumMember(Value = "Week")]
        WEEK,

        [EnumMember(Value = "Year")]
        YEAR


    } // enum TaskSummaryGroupByEnum

} // namespace Rubrik.SecurityCloud.Types