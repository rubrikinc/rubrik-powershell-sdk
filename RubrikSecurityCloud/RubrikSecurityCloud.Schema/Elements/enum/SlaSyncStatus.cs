// SlaSyncStatus.cs
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
    public enum SlaSyncStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "NOT_ATTEMPTED")]
        NOT_ATTEMPTED,

        [EnumMember(Value = "PENDING")]
        PENDING,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED


    } // enum SlaSyncStatus

} // namespace RubrikSecurityCloud.Types