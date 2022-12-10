// FileCountType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:30.
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
    public enum FileCountType
    {
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
        STALE_HITS


    } // enum FileCountType

} // namespace Rubrik.SecurityCloud.Types