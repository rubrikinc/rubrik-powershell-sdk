// HostConnectivityStatusEnum.cs
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
    public enum HostConnectivityStatusEnum
    {
        [EnumMember(Value = "BADLY_CONFIGURED")]
        BADLY_CONFIGURED,

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

        [EnumMember(Value = "DELETION_FAILED")]
        DELETION_FAILED,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "PARTIALLY_CONNECTED")]
        PARTIALLY_CONNECTED,

        [EnumMember(Value = "REFRESHING")]
        REFRESHING,

        [EnumMember(Value = "REFRESH_FAILED")]
        REFRESH_FAILED,

        [EnumMember(Value = "REMOTE")]
        REMOTE,

        [EnumMember(Value = "REPLICATED_TARGET")]
        REPLICATED_TARGET,

        [EnumMember(Value = "SECONDARY_CLUSTER")]
        SECONDARY_CLUSTER,

        [EnumMember(Value = "UNKNOWN_CONNECTIVITY_STATUS")]
        UNKNOWN_CONNECTIVITY_STATUS


    } // enum HostConnectivityStatusEnum

} // namespace RubrikSecurityCloud.Types