// RansomwareResultGroupBy.cs
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
    public enum RansomwareResultGroupBy
    {
        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "MANAGED_ID")]
        MANAGED_ID,

        [EnumMember(Value = "SNAPSHOT_DAY")]
        SNAPSHOT_DAY,

        [EnumMember(Value = "SNAPSHOT_HOUR")]
        SNAPSHOT_HOUR,

        [EnumMember(Value = "SNAPSHOT_MONTH")]
        SNAPSHOT_MONTH,

        [EnumMember(Value = "SNAPSHOT_WEEK")]
        SNAPSHOT_WEEK,

        [EnumMember(Value = "SNAPSHOT_YEAR")]
        SNAPSHOT_YEAR


    } // enum RansomwareResultGroupBy

} // namespace RubrikSecurityCloud.Types