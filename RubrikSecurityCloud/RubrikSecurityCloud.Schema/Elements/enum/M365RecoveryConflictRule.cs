// M365RecoveryConflictRule.cs
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
    public enum M365RecoveryConflictRule
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "M365_RECOVERY_CONFLICT_RULE_KEEP_EXISTING_DATA")]
        M365_RECOVERY_CONFLICT_RULE_KEEP_EXISTING_DATA,

        [EnumMember(Value = "M365_RECOVERY_CONFLICT_RULE_OVERWRITE")]
        M365_RECOVERY_CONFLICT_RULE_OVERWRITE,

        [EnumMember(Value = "M365_RECOVERY_CONFLICT_RULE_UNSPECIFIED")]
        M365_RECOVERY_CONFLICT_RULE_UNSPECIFIED


    } // enum M365RecoveryConflictRule

} // namespace RubrikSecurityCloud.Types