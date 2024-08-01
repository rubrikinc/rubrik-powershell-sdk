// FlagDataType.cs
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
    public enum FlagDataType
    {
        [EnumMember(Value = "BOOL")]
        BOOL,

        [EnumMember(Value = "FLOAT")]
        FLOAT,

        [EnumMember(Value = "INT")]
        INT,

        [EnumMember(Value = "STRING")]
        STRING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FlagDataType

} // namespace RubrikSecurityCloud.Types