// FailoverClusterConnectivityStatus.cs
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

} // namespace RubrikSecurityCloud.Types