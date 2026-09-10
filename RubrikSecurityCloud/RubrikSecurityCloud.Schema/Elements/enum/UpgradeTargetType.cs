// UpgradeTargetType.cs
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
    public enum UpgradeTargetType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UPGRADE_TARGET_TYPE_APPLIANCE")]
        UPGRADE_TARGET_TYPE_APPLIANCE,

        [EnumMember(Value = "UPGRADE_TARGET_TYPE_CLUSTER")]
        UPGRADE_TARGET_TYPE_CLUSTER,

        [EnumMember(Value = "UPGRADE_TARGET_TYPE_UNSPECIFIED")]
        UPGRADE_TARGET_TYPE_UNSPECIFIED


    } // enum UpgradeTargetType

} // namespace RubrikSecurityCloud.Types