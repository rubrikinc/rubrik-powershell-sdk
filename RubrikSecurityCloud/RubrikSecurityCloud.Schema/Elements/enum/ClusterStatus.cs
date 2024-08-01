// ClusterStatus.cs
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
    public enum ClusterStatus
    {
        [EnumMember(Value = "Connected")]
        CONNECTED,

        [EnumMember(Value = "Disconnected")]
        DISCONNECTED,

        [EnumMember(Value = "Initializing")]
        INITIALIZING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ClusterStatus

} // namespace RubrikSecurityCloud.Types