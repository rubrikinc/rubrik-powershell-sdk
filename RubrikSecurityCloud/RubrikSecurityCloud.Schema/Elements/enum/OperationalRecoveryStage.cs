// OperationalRecoveryStage.cs
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
    public enum OperationalRecoveryStage
    {
        [EnumMember(Value = "COMPLETE_OPERATIONAL_RECOVERY")]
        COMPLETE_OPERATIONAL_RECOVERY,

        [EnumMember(Value = "INITIAL_OPERATIONAL_RECOVERY")]
        INITIAL_OPERATIONAL_RECOVERY,

        [EnumMember(Value = "RECOVERY_STAGE_UNKNOWN")]
        RECOVERY_STAGE_UNKNOWN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum OperationalRecoveryStage

} // namespace RubrikSecurityCloud.Types