// FileStateEnumType.cs
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
    public enum FileStateEnumType
    {
        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "INVALID")]
        INVALID,

        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "PENDING")]
        PENDING,

        [EnumMember(Value = "READY")]
        READY


    } // enum FileStateEnumType

} // namespace RubrikSecurityCloud.Types