// FileRecoveryFeasibility.cs
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
    public enum FileRecoveryFeasibility
    {
        [EnumMember(Value = "EXOCOMPUTE_NOT_CONFIGURED")]
        EXOCOMPUTE_NOT_CONFIGURED,

        [EnumMember(Value = "FEASIBLE")]
        FEASIBLE,

        [EnumMember(Value = "SNAPSHOT_EXPIRED")]
        SNAPSHOT_EXPIRED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UNSUPPORTED_HOSTED_REGION")]
        UNSUPPORTED_HOSTED_REGION


    } // enum FileRecoveryFeasibility

} // namespace RubrikSecurityCloud.Types