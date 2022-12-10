// OraclePdbOpenMode.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:56.
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
    public enum OraclePdbOpenMode
    {
        [EnumMember(Value = "MIGRATE")]
        MIGRATE,

        [EnumMember(Value = "MOUNTED")]
        MOUNTED,

        [EnumMember(Value = "READ_ONLY")]
        READ_ONLY,

        [EnumMember(Value = "READ_WRITE")]
        READ_WRITE,

        [EnumMember(Value = "UNKNOWN_OPEN_MODE")]
        UNKNOWN_OPEN_MODE


    } // enum OraclePdbOpenMode

} // namespace Rubrik.SecurityCloud.Types