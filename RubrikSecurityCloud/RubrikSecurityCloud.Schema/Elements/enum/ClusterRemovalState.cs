// ClusterRemovalState.cs
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
    public enum ClusterRemovalState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

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

} // namespace RubrikSecurityCloud.Types