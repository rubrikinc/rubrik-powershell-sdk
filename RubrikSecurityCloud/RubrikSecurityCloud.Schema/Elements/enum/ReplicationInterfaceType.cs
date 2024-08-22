// ReplicationInterfaceType.cs
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
    public enum ReplicationInterfaceType
    {
        [EnumMember(Value = "DATA")]
        DATA,

        [EnumMember(Value = "INTERFACE_TYPE_UNSPECIFIED")]
        INTERFACE_TYPE_UNSPECIFIED,

        [EnumMember(Value = "MANAGEMENT")]
        MANAGEMENT,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ReplicationInterfaceType

} // namespace RubrikSecurityCloud.Types