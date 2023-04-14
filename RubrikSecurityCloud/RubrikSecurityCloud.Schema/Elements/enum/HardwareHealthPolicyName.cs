// HardwareHealthPolicyName.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum HardwareHealthPolicyName
    {
        [EnumMember(Value = "CHASSIS_CHECKER")]
        CHASSIS_CHECKER,

        [EnumMember(Value = "DIMM_CHECKER")]
        DIMM_CHECKER,

        [EnumMember(Value = "DISK_CHECKER")]
        DISK_CHECKER,

        [EnumMember(Value = "HARDWARE_HEALTH_UPDATER")]
        HARDWARE_HEALTH_UPDATER,

        [EnumMember(Value = "NETWORK_INTERFACE_CHECKER_PRIMARY")]
        NETWORK_INTERFACE_CHECKER_PRIMARY,

        [EnumMember(Value = "NETWORK_INTERFACE_CHECKER_SECONDARY")]
        NETWORK_INTERFACE_CHECKER_SECONDARY,

        [EnumMember(Value = "NODE_CHECKER")]
        NODE_CHECKER,

        [EnumMember(Value = "P_S_U_CHECKER")]
        P_S_U_CHECKER


    } // enum HardwareHealthPolicyName

} // namespace Rubrik.SecurityCloud.Types