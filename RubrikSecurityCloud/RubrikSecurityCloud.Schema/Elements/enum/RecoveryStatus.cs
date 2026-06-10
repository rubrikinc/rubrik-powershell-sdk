// RecoveryStatus.cs
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
    public enum RecoveryStatus
    {
        [EnumMember(Value = "CLEANUP_FAILED")]
        CLEANUP_FAILED,

        [EnumMember(Value = "CLEANUP_STARTED")]
        CLEANUP_STARTED,

        [EnumMember(Value = "CLEANUP_SUCCEEDED")]
        CLEANUP_SUCCEEDED,

        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        [EnumMember(Value = "DONE")]
        DONE,

        [EnumMember(Value = "LOCKED")]
        LOCKED,

        [EnumMember(Value = "ONGOING")]
        ONGOING,

        [EnumMember(Value = "PAUSED")]
        PAUSED,

        [EnumMember(Value = "QUEUED")]
        QUEUED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RecoveryStatus

} // namespace RubrikSecurityCloud.Types