// RecoveryPlanType.cs
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
    public enum RecoveryPlanType
    {
        [EnumMember(Value = "CYBER_RECOVERY")]
        CYBER_RECOVERY,

        [EnumMember(Value = "DISASTER_RECOVERY")]
        DISASTER_RECOVERY,

        [EnumMember(Value = "IN_PLACE_RECOVERY")]
        IN_PLACE_RECOVERY,

        [EnumMember(Value = "UNKNOWN_BLUEPRINT_TYPE")]
        UNKNOWN_BLUEPRINT_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RecoveryPlanType

} // namespace RubrikSecurityCloud.Types