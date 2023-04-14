// MountState.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum MountState
    {
        [EnumMember(Value = "CHANGING_TO_READ_ONLY")]
        CHANGING_TO_READ_ONLY,

        [EnumMember(Value = "CHANGING_TO_WRITABLE")]
        CHANGING_TO_WRITABLE,

        [EnumMember(Value = "INVALID")]
        INVALID,

        [EnumMember(Value = "READ_ONLY")]
        READ_ONLY,

        [EnumMember(Value = "WRITABLE")]
        WRITABLE


    } // enum MountState

} // namespace Rubrik.SecurityCloud.Types