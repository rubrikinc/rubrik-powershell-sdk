// ClusterPauseStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    public enum ClusterPauseStatus
    {
        [EnumMember(Value = "NOT_PAUSED")]
        NOT_PAUSED,

        [EnumMember(Value = "PAUSED")]
        PAUSED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ClusterPauseStatus

} // namespace Rubrik.SecurityCloud.Types