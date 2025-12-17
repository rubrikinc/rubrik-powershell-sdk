// ClusterRaidStatus.cs
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
    public enum ClusterRaidStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DEGRADED")]
        DEGRADED,

        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "OFFLINE")]
        OFFLINE,

        [EnumMember(Value = "OPTIMAL")]
        OPTIMAL,

        [EnumMember(Value = "READY_TO_REBUILD")]
        READY_TO_REBUILD,

        [EnumMember(Value = "REBUILDING")]
        REBUILDING


    } // enum ClusterRaidStatus

} // namespace RubrikSecurityCloud.Types