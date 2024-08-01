// HostRbsConnectionStatus.cs
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
    public enum HostRbsConnectionStatus
    {
        [EnumMember(Value = "HOST_RBS_CONNECTION_STATUS_CONNECTED")]
        HOST_RBS_CONNECTION_STATUS_CONNECTED,

        [EnumMember(Value = "HOST_RBS_CONNECTION_STATUS_CONNECTING")]
        HOST_RBS_CONNECTION_STATUS_CONNECTING,

        [EnumMember(Value = "HOST_RBS_CONNECTION_STATUS_CONNECTOR_NOT_DEPLOYED")]
        HOST_RBS_CONNECTION_STATUS_CONNECTOR_NOT_DEPLOYED,

        [EnumMember(Value = "HOST_RBS_CONNECTION_STATUS_DELETED")]
        HOST_RBS_CONNECTION_STATUS_DELETED,

        [EnumMember(Value = "HOST_RBS_CONNECTION_STATUS_DELETING")]
        HOST_RBS_CONNECTION_STATUS_DELETING,

        [EnumMember(Value = "HOST_RBS_CONNECTION_STATUS_DISCONNECTED")]
        HOST_RBS_CONNECTION_STATUS_DISCONNECTED,

        [EnumMember(Value = "HOST_RBS_CONNECTION_STATUS_PARTIALLY_CONNECTED")]
        HOST_RBS_CONNECTION_STATUS_PARTIALLY_CONNECTED,

        [EnumMember(Value = "HOST_RBS_CONNECTION_STATUS_REFRESHING")]
        HOST_RBS_CONNECTION_STATUS_REFRESHING,

        [EnumMember(Value = "HOST_RBS_CONNECTION_STATUS_REPLICATION_TARGET")]
        HOST_RBS_CONNECTION_STATUS_REPLICATION_TARGET,

        [EnumMember(Value = "HOST_RBS_CONNECTION_STATUS_SECONDARY_CLUSTER")]
        HOST_RBS_CONNECTION_STATUS_SECONDARY_CLUSTER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum HostRbsConnectionStatus

} // namespace RubrikSecurityCloud.Types