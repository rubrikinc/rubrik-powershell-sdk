// ReclaimableClusterStatsSortBy.cs
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
    public enum ReclaimableClusterStatsSortBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AVAILABLE_SPACE_PERCENT")]
        AVAILABLE_SPACE_PERCENT,

        [EnumMember(Value = "CLUSTER_NAME")]
        CLUSTER_NAME,

        [EnumMember(Value = "RECLAIMABLE_CLUSTER_STATS_SORT_UNSPECIFIED")]
        RECLAIMABLE_CLUSTER_STATS_SORT_UNSPECIFIED


    } // enum ReclaimableClusterStatsSortBy

} // namespace RubrikSecurityCloud.Types