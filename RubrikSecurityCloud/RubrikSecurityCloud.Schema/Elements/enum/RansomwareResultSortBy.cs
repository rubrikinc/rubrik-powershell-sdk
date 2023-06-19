// RansomwareResultSortBy.cs
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
    public enum RansomwareResultSortBy
    {
        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "ENCRYPTION_PROBABILITY")]
        ENCRYPTION_PROBABILITY,

        [EnumMember(Value = "IS_ENCRYPTED")]
        IS_ENCRYPTED,

        [EnumMember(Value = "MANAGED_ID")]
        MANAGED_ID,

        [EnumMember(Value = "SNAPSHOT_DATE")]
        SNAPSHOT_DATE,

        [EnumMember(Value = "SNAPSHOT_ID")]
        SNAPSHOT_ID,

        [EnumMember(Value = "WORKLOAD_ID")]
        WORKLOAD_ID


    } // enum RansomwareResultSortBy

} // namespace RubrikSecurityCloud.Types