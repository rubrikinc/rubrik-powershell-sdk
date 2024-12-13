// DeviceState.cs
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
    public enum DeviceState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DEGRADED")]
        DEGRADED,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "HEALTHY")]
        HEALTHY,

        [EnumMember(Value = "UNHEALTHY")]
        UNHEALTHY


    } // enum DeviceState

} // namespace RubrikSecurityCloud.Types