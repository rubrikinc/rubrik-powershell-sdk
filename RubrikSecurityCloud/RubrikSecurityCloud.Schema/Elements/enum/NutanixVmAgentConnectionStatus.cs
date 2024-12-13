// NutanixVmAgentConnectionStatus.cs
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
    public enum NutanixVmAgentConnectionStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "FIELD_UNSPECIFIED")]
        FIELD_UNSPECIFIED,

        [EnumMember(Value = "SECONDARY_CLUSTER")]
        SECONDARY_CLUSTER,

        [EnumMember(Value = "UNREGISTERED")]
        UNREGISTERED


    } // enum NutanixVmAgentConnectionStatus

} // namespace RubrikSecurityCloud.Types