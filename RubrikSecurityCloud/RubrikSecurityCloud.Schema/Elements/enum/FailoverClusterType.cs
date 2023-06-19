// FailoverClusterType.cs
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
    public enum FailoverClusterType
    {
        [EnumMember(Value = "FAILOVER_CLUSTER_TYPE_UNIX_LIKE")]
        FAILOVER_CLUSTER_TYPE_UNIX_LIKE,

        [EnumMember(Value = "FAILOVER_CLUSTER_TYPE_WINDOWS")]
        FAILOVER_CLUSTER_TYPE_WINDOWS


    } // enum FailoverClusterType

} // namespace RubrikSecurityCloud.Types