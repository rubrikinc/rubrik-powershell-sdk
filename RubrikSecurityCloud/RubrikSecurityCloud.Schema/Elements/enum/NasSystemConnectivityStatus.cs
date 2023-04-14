// NasSystemConnectivityStatus.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum NasSystemConnectivityStatus
    {
        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "CONNECTING")]
        CONNECTING,

        [EnumMember(Value = "CONNECTOR_NOT_DEPLOYED")]
        CONNECTOR_NOT_DEPLOYED,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "DELETING")]
        DELETING,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "PARTIALLY_CONNECTED")]
        PARTIALLY_CONNECTED,

        [EnumMember(Value = "REFRESHING")]
        REFRESHING,

        [EnumMember(Value = "REPLICATION_TARGET")]
        REPLICATION_TARGET,

        [EnumMember(Value = "SECONDARY_CLUSTER")]
        SECONDARY_CLUSTER,

        [EnumMember(Value = "UNKNOWN_CONNECTIVITY_STATUS")]
        UNKNOWN_CONNECTIVITY_STATUS


    } // enum NasSystemConnectivityStatus

} // namespace Rubrik.SecurityCloud.Types