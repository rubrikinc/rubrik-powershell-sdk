// FailoverClusterAppConnectionStatus.cs
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
    public enum FailoverClusterAppConnectionStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILOVER_CLUSTER_APP_CONNECTION_STATUS_CONNECTED")]
        FAILOVER_CLUSTER_APP_CONNECTION_STATUS_CONNECTED,

        [EnumMember(Value = "FAILOVER_CLUSTER_APP_CONNECTION_STATUS_DISCONNECTED")]
        FAILOVER_CLUSTER_APP_CONNECTION_STATUS_DISCONNECTED,

        [EnumMember(Value = "FAILOVER_CLUSTER_APP_CONNECTION_STATUS_REPLICATION_TARGET")]
        FAILOVER_CLUSTER_APP_CONNECTION_STATUS_REPLICATION_TARGET


    } // enum FailoverClusterAppConnectionStatus

} // namespace RubrikSecurityCloud.Types