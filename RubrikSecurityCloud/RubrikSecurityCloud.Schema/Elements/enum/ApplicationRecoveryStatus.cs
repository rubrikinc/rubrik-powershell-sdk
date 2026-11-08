// ApplicationRecoveryStatus.cs
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
    public enum ApplicationRecoveryStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "RECOVERY_STATUS_CLEANUP_FAILED")]
        RECOVERY_STATUS_CLEANUP_FAILED,

        [EnumMember(Value = "RECOVERY_STATUS_CLEANUP_STARTED")]
        RECOVERY_STATUS_CLEANUP_STARTED,

        [EnumMember(Value = "RECOVERY_STATUS_CLEANUP_SUCCEEDED")]
        RECOVERY_STATUS_CLEANUP_SUCCEEDED,

        [EnumMember(Value = "RECOVERY_STATUS_COMPLETED")]
        RECOVERY_STATUS_COMPLETED,

        [EnumMember(Value = "RECOVERY_STATUS_DONE")]
        RECOVERY_STATUS_DONE,

        [EnumMember(Value = "RECOVERY_STATUS_INIT")]
        RECOVERY_STATUS_INIT,

        [EnumMember(Value = "RECOVERY_STATUS_LOCKED")]
        RECOVERY_STATUS_LOCKED,

        [EnumMember(Value = "RECOVERY_STATUS_ONGOING")]
        RECOVERY_STATUS_ONGOING,

        [EnumMember(Value = "RECOVERY_STATUS_PAUSED")]
        RECOVERY_STATUS_PAUSED,

        [EnumMember(Value = "RECOVERY_STATUS_QUEUED")]
        RECOVERY_STATUS_QUEUED,

        [EnumMember(Value = "RECOVERY_STATUS_UNSPECIFIED")]
        RECOVERY_STATUS_UNSPECIFIED


    } // enum ApplicationRecoveryStatus

} // namespace RubrikSecurityCloud.Types