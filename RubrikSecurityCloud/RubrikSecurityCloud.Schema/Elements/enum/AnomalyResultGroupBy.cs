// AnomalyResultGroupBy.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:07.
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
    public enum AnomalyResultGroupBy
    {
        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "DAY")]
        DAY,

        [EnumMember(Value = "HOUR")]
        HOUR,

        [EnumMember(Value = "IS_ANOMALY")]
        IS_ANOMALY,

        [EnumMember(Value = "MANAGED_ID")]
        MANAGED_ID,

        [EnumMember(Value = "MONTH")]
        MONTH,

        [EnumMember(Value = "SEVERITY")]
        SEVERITY,

        [EnumMember(Value = "WEEK")]
        WEEK,

        [EnumMember(Value = "YEAR")]
        YEAR


    } // enum AnomalyResultGroupBy

} // namespace Rubrik.SecurityCloud.Types