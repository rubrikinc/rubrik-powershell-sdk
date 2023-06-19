// HypervHostStatusType.cs
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
    public enum HypervHostStatusType
    {
        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "CONNECTING")]
        CONNECTING,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "DELETING")]
        DELETING,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "PARTIALLYCONNECTED")]
        PARTIALLYCONNECTED,

        [EnumMember(Value = "REFRESHING")]
        REFRESHING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum HypervHostStatusType

} // namespace RubrikSecurityCloud.Types