// ClusterSystemStatus.cs
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
    public enum ClusterSystemStatus
    {
        [EnumMember(Value = "FATAL")]
        FATAL,

        [EnumMember(Value = "OK")]
        OK,

        [EnumMember(Value = "WARNING")]
        WARNING


    } // enum ClusterSystemStatus

} // namespace Rubrik.SecurityCloud.Types