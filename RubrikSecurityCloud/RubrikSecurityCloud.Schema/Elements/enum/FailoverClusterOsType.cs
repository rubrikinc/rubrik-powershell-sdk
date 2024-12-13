// FailoverClusterOsType.cs
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
    public enum FailoverClusterOsType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILOVER_CLUSTER_OS_TYPE_AIX")]
        FAILOVER_CLUSTER_OS_TYPE_AIX,

        [EnumMember(Value = "FAILOVER_CLUSTER_OS_TYPE_ANY")]
        FAILOVER_CLUSTER_OS_TYPE_ANY,

        [EnumMember(Value = "FAILOVER_CLUSTER_OS_TYPE_HPUX")]
        FAILOVER_CLUSTER_OS_TYPE_HPUX,

        [EnumMember(Value = "FAILOVER_CLUSTER_OS_TYPE_LINUX")]
        FAILOVER_CLUSTER_OS_TYPE_LINUX,

        [EnumMember(Value = "FAILOVER_CLUSTER_OS_TYPE_SUN_OS")]
        FAILOVER_CLUSTER_OS_TYPE_SUN_OS,

        [EnumMember(Value = "FAILOVER_CLUSTER_OS_TYPE_UNIX_LIKE")]
        FAILOVER_CLUSTER_OS_TYPE_UNIX_LIKE,

        [EnumMember(Value = "FAILOVER_CLUSTER_OS_TYPE_WINDOWS")]
        FAILOVER_CLUSTER_OS_TYPE_WINDOWS


    } // enum FailoverClusterOsType

} // namespace RubrikSecurityCloud.Types