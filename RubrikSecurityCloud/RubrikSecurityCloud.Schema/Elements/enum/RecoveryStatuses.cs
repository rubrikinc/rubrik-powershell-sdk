// RecoveryStatuses.cs
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
    public enum RecoveryStatuses
    {
        [EnumMember(Value = "CLEANED_UP")]
        CLEANED_UP,

        [EnumMember(Value = "FAILURE")]
        FAILURE,

        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "PAUSED")]
        PAUSED,

        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RecoveryStatuses

} // namespace Rubrik.SecurityCloud.Types