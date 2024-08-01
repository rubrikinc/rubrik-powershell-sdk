// NetworkAdapterType.cs
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
    public enum NetworkAdapterType
    {
        [EnumMember(Value = "E1000")]
        E1000,

        [EnumMember(Value = "E1000E")]
        E1000_E,

        [EnumMember(Value = "PCNET32")]
        PCNE_T32,

        [EnumMember(Value = "VMXNET")]
        VMXNET,

        [EnumMember(Value = "VMXNET2")]
        VMXNE_T2,

        [EnumMember(Value = "VMXNET3")]
        VMXNE_T3,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum NetworkAdapterType

} // namespace RubrikSecurityCloud.Types