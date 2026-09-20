// RegistryValueType.cs
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
    public enum RegistryValueType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "VALUE_TYPE_REG_BINARY")]
        VALUE_TYPE_REG_BINARY,

        [EnumMember(Value = "VALUE_TYPE_REG_DWORD")]
        VALUE_TYPE_REG_DWORD,

        [EnumMember(Value = "VALUE_TYPE_REG_EXPAND_SZ")]
        VALUE_TYPE_REG_EXPAND_SZ,

        [EnumMember(Value = "VALUE_TYPE_REG_MULTI_SZ")]
        VALUE_TYPE_REG_MULTI_SZ,

        [EnumMember(Value = "VALUE_TYPE_REG_NONE")]
        VALUE_TYPE_REG_NONE,

        [EnumMember(Value = "VALUE_TYPE_REG_QWORD")]
        VALUE_TYPE_REG_QWORD,

        [EnumMember(Value = "VALUE_TYPE_REG_SZ")]
        VALUE_TYPE_REG_SZ


    } // enum RegistryValueType

} // namespace RubrikSecurityCloud.Types