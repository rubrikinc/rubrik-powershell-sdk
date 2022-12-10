// FlagDataType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:14.
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

} // namespace Rubrik.SecurityCloud.Types