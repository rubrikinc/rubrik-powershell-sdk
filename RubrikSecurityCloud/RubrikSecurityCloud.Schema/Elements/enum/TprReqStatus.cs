// TprReqStatus.cs
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
    public enum TprReqStatus
    {
        [EnumMember(Value = "APPROVED")]
        APPROVED,

        [EnumMember(Value = "APPROVED_AND_SCHEDULED")]
        APPROVED_AND_SCHEDULED,

        [EnumMember(Value = "CANCELED")]
        CANCELED,

        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        [EnumMember(Value = "DENIED")]
        DENIED,

        [EnumMember(Value = "EXPIRED")]
        EXPIRED,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "PENDING")]
        PENDING,

        [EnumMember(Value = "STAGED")]
        STAGED


    } // enum TprReqStatus

} // namespace Rubrik.SecurityCloud.Types