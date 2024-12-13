// FileCountType.cs
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
    public enum FileCountType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ANY")]
        ANY,

        [EnumMember(Value = "HITS")]
        HITS,

        [EnumMember(Value = "OPEN_ACCESS")]
        OPEN_ACCESS,

        [EnumMember(Value = "OPEN_ACCESS_HITS")]
        OPEN_ACCESS_HITS,

        [EnumMember(Value = "STALE")]
        STALE,

        [EnumMember(Value = "STALE_HITS")]
        STALE_HITS,

        [EnumMember(Value = "UNUSED_HITS")]
        UNUSED_HITS


    } // enum FileCountType

} // namespace RubrikSecurityCloud.Types