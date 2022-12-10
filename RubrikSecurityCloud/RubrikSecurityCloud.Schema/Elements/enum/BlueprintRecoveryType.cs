// BlueprintRecoveryType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:39.
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
    public enum BlueprintRecoveryType
    {
        [EnumMember(Value = "CYBER_RECOVERY")]
        CYBER_RECOVERY,

        [EnumMember(Value = "DISASTER_RECOVERY")]
        DISASTER_RECOVERY,

        [EnumMember(Value = "IN_PLACE_RECOVERY")]
        IN_PLACE_RECOVERY,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum BlueprintRecoveryType

} // namespace Rubrik.SecurityCloud.Types