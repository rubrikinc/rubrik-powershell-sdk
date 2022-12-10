// FilesetOsType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:32.
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

} // namespace Rubrik.SecurityCloud.Types