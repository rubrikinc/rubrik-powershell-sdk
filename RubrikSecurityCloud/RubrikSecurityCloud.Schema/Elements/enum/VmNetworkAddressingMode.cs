// VmNetworkAddressingMode.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:07.
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
    public enum VmNetworkAddressingMode
    {
        [EnumMember(Value = "VAPP_VM_IP_ADDRESSING_MODE_DHCP")]
        VAPP_VM_IP_ADDRESSING_MODE_DHCP,

        [EnumMember(Value = "VAPP_VM_IP_ADDRESSING_MODE_MANUAL")]
        VAPP_VM_IP_ADDRESSING_MODE_MANUAL,

        [EnumMember(Value = "VAPP_VM_IP_ADDRESSING_MODE_NONE")]
        VAPP_VM_IP_ADDRESSING_MODE_NONE,

        [EnumMember(Value = "VAPP_VM_IP_ADDRESSING_MODE_POOL")]
        VAPP_VM_IP_ADDRESSING_MODE_POOL


    } // enum VmNetworkAddressingMode

} // namespace Rubrik.SecurityCloud.Types