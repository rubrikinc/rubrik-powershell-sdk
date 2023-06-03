// HypervVmAgentConnectionStatus.cs
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
    public enum HypervVmAgentConnectionStatus
    {
        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "SECONDARY_CLUSTER")]
        SECONDARY_CLUSTER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UNREGISTERED")]
        UNREGISTERED


    } // enum HypervVmAgentConnectionStatus

} // namespace Rubrik.SecurityCloud.Types