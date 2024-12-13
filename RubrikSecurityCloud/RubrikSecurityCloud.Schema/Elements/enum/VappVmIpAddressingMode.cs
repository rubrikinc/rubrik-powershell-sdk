// VappVmIpAddressingMode.cs
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
    public enum VappVmIpAddressingMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "VAPP_VM_IP_ADDRESSING_MODE_DHCP")]
        VAPP_VM_IP_ADDRESSING_MODE_DHCP,

        [EnumMember(Value = "VAPP_VM_IP_ADDRESSING_MODE_MANUAL")]
        VAPP_VM_IP_ADDRESSING_MODE_MANUAL,

        [EnumMember(Value = "VAPP_VM_IP_ADDRESSING_MODE_NONE")]
        VAPP_VM_IP_ADDRESSING_MODE_NONE,

        [EnumMember(Value = "VAPP_VM_IP_ADDRESSING_MODE_POOL")]
        VAPP_VM_IP_ADDRESSING_MODE_POOL


    } // enum VappVmIpAddressingMode

} // namespace RubrikSecurityCloud.Types