// ServiceStatus.cs
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
    public enum ServiceStatus
    {
        [EnumMember(Value = "CONTINUE_PENDING")]
        CONTINUE_PENDING,

        [EnumMember(Value = "PAUSED")]
        PAUSED,

        [EnumMember(Value = "PAUSE_PENDING")]
        PAUSE_PENDING,

        [EnumMember(Value = "REFRESHING")]
        REFRESHING,

        [EnumMember(Value = "RUNNING")]
        RUNNING,

        [EnumMember(Value = "START_PENDING")]
        START_PENDING,

        [EnumMember(Value = "STOPPED")]
        STOPPED,

        [EnumMember(Value = "STOP_PENDING")]
        STOP_PENDING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ServiceStatus

} // namespace Rubrik.SecurityCloud.Types