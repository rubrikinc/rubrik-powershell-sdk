// SlaSyncStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:13.
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
    public enum SlaSyncStatus
    {
        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "NOT_ATTEMPTED")]
        NOT_ATTEMPTED,

        [EnumMember(Value = "PENDING")]
        PENDING,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED


    } // enum SlaSyncStatus

} // namespace Rubrik.SecurityCloud.Types