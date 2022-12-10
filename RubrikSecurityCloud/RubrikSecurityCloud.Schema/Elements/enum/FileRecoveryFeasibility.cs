// FileRecoveryFeasibility.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:19.
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

} // namespace Rubrik.SecurityCloud.Types