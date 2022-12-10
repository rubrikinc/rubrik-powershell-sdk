// HypervVirtualMachineDetailGuestOsType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:37.
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
    public enum HypervVirtualMachineDetailGuestOsType
    {
        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_DETAIL_GUEST_OS_TYPE_LINUX")]
        HYPERV_VIRTUAL_MACHINE_DETAIL_GUEST_OS_TYPE_LINUX,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_DETAIL_GUEST_OS_TYPE_UNKNOWN")]
        HYPERV_VIRTUAL_MACHINE_DETAIL_GUEST_OS_TYPE_UNKNOWN,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_DETAIL_GUEST_OS_TYPE_WINDOWS")]
        HYPERV_VIRTUAL_MACHINE_DETAIL_GUEST_OS_TYPE_WINDOWS


    } // enum HypervVirtualMachineDetailGuestOsType

} // namespace Rubrik.SecurityCloud.Types