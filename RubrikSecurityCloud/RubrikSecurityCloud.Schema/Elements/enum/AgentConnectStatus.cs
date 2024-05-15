// AgentConnectStatus.cs
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
    public enum AgentConnectStatus
    {
        [EnumMember(Value = "AGENT_CONNECT_STATUS_CONNECTED")]
        AGENT_CONNECT_STATUS_CONNECTED,

        [EnumMember(Value = "AGENT_CONNECT_STATUS_DISCONNECTED")]
        AGENT_CONNECT_STATUS_DISCONNECTED,

        [EnumMember(Value = "AGENT_CONNECT_STATUS_SECONDARY_CLUSTER")]
        AGENT_CONNECT_STATUS_SECONDARY_CLUSTER,

        [EnumMember(Value = "AGENT_CONNECT_STATUS_UNREGISTERED")]
        AGENT_CONNECT_STATUS_UNREGISTERED


    } // enum AgentConnectStatus

} // namespace RubrikSecurityCloud.Types