// FilesetOsType.cs
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
    public enum FilesetOsType
    {
        [EnumMember(Value = "LINUX")]
        LINUX,

        [EnumMember(Value = "NO_OS_TYPE")]
        NO_OS_TYPE,

        [EnumMember(Value = "UNIX_LIKE")]
        UNIX_LIKE,

        [EnumMember(Value = "WINDOWS")]
        WINDOWS


    } // enum FilesetOsType

} // namespace RubrikSecurityCloud.Types