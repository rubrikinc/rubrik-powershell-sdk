// OraclePdbOpenMode.cs
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
        UNKNOWN_OPEN_MODE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum OraclePdbOpenMode

} // namespace RubrikSecurityCloud.Types