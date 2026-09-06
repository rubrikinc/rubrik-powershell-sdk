// M365AccessRecoveryState.cs
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
    public enum M365AccessRecoveryState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "M365_ACCESS_RECOVERY_STATE_DISABLED")]
        M365_ACCESS_RECOVERY_STATE_DISABLED,

        [EnumMember(Value = "M365_ACCESS_RECOVERY_STATE_ENABLED")]
        M365_ACCESS_RECOVERY_STATE_ENABLED,

        [EnumMember(Value = "M365_ACCESS_RECOVERY_STATE_UNSPECIFIED")]
        M365_ACCESS_RECOVERY_STATE_UNSPECIFIED


    } // enum M365AccessRecoveryState

} // namespace RubrikSecurityCloud.Types