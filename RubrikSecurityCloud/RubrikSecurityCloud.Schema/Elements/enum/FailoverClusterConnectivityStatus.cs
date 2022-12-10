// FailoverClusterConnectivityStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:31.
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
    public enum FailoverClusterConnectivityStatus
    {
        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "PARTIALLY_CONNECTED")]
        PARTIALLY_CONNECTED,

        [EnumMember(Value = "REPLICATION_TARGET")]
        REPLICATION_TARGET,

        [EnumMember(Value = "UNKNOWN_CONNECTIVITY_STATUS")]
        UNKNOWN_CONNECTIVITY_STATUS


    } // enum FailoverClusterConnectivityStatus

} // namespace Rubrik.SecurityCloud.Types