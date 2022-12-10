// ThreatHuntStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:39.
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
    public enum ThreatHuntStatus
    {
        [EnumMember(Value = "CANCELED")]
        CANCELED,

        [EnumMember(Value = "CANCELING")]
        CANCELING,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "PARTIALLY_SUCCEEDED")]
        PARTIALLY_SUCCEEDED,

        [EnumMember(Value = "STATUS_UNSPECIFIED")]
        STATUS_UNSPECIFIED,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED


    } // enum ThreatHuntStatus

} // namespace Rubrik.SecurityCloud.Types