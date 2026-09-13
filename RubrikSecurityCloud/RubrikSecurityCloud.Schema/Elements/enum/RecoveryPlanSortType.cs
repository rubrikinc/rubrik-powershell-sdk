// RecoveryPlanSortType.cs
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
    public enum RecoveryPlanSortType
    {
        [EnumMember(Value = "RECOVERY_PLAN_LAST_RECOVERY_OUTCOME")]
        RECOVERY_PLAN_LAST_RECOVERY_OUTCOME,

        [EnumMember(Value = "RECOVERY_PLAN_NAME")]
        RECOVERY_PLAN_NAME,

        [EnumMember(Value = "RECOVERY_PLAN_STATUS")]
        RECOVERY_PLAN_STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RecoveryPlanSortType

} // namespace RubrikSecurityCloud.Types