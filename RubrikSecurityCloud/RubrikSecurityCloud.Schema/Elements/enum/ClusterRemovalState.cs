// ClusterRemovalState.cs
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
    public enum ClusterRemovalState
    {
        [EnumMember(Value = "DATA_DELETING")]
        DATA_DELETING,

        [EnumMember(Value = "DISCONNECTING")]
        DISCONNECTING,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "REGISTERED")]
        REGISTERED,

        [EnumMember(Value = "UNREGISTERED")]
        UNREGISTERED,

        [EnumMember(Value = "WAITING_FOR_DATA_DELETION")]
        WAITING_FOR_DATA_DELETION


    } // enum ClusterRemovalState

} // namespace Rubrik.SecurityCloud.Types