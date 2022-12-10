// FailoverClusterConnectionStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:24.
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
    public enum FailoverClusterConnectionStatus
    {
        [EnumMember(Value = "FAILOVER_CLUSTER_CONNECTION_STATUS_CONNECTED")]
        FAILOVER_CLUSTER_CONNECTION_STATUS_CONNECTED,

        [EnumMember(Value = "FAILOVER_CLUSTER_CONNECTION_STATUS_DISCONNECTED")]
        FAILOVER_CLUSTER_CONNECTION_STATUS_DISCONNECTED,

        [EnumMember(Value = "FAILOVER_CLUSTER_CONNECTION_STATUS_PARTIALLY_CONNECTED")]
        FAILOVER_CLUSTER_CONNECTION_STATUS_PARTIALLY_CONNECTED,

        [EnumMember(Value = "FAILOVER_CLUSTER_CONNECTION_STATUS_REPLICATION_TARGET")]
        FAILOVER_CLUSTER_CONNECTION_STATUS_REPLICATION_TARGET


    } // enum FailoverClusterConnectionStatus

} // namespace Rubrik.SecurityCloud.Types