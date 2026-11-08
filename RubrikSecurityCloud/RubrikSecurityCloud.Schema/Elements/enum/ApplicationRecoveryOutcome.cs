// ApplicationRecoveryOutcome.cs
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
    public enum ApplicationRecoveryOutcome
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "RECOVERY_OUTCOME_FAILED")]
        RECOVERY_OUTCOME_FAILED,

        [EnumMember(Value = "RECOVERY_OUTCOME_PARTIALLY_SUCCEEDED")]
        RECOVERY_OUTCOME_PARTIALLY_SUCCEEDED,

        [EnumMember(Value = "RECOVERY_OUTCOME_SUCCEEDED")]
        RECOVERY_OUTCOME_SUCCEEDED,

        [EnumMember(Value = "RECOVERY_OUTCOME_UNSPECIFIED")]
        RECOVERY_OUTCOME_UNSPECIFIED


    } // enum ApplicationRecoveryOutcome

} // namespace RubrikSecurityCloud.Types