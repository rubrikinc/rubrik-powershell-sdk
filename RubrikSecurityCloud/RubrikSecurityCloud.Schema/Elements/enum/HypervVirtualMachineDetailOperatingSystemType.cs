// HypervVirtualMachineDetailOperatingSystemType.cs
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
    public enum HypervVirtualMachineDetailOperatingSystemType
    {
        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_DETAIL_OPERATING_SYSTEM_TYPE_LINUX")]
        HYPERV_VIRTUAL_MACHINE_DETAIL_OPERATING_SYSTEM_TYPE_LINUX,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_DETAIL_OPERATING_SYSTEM_TYPE_WINDOWS")]
        HYPERV_VIRTUAL_MACHINE_DETAIL_OPERATING_SYSTEM_TYPE_WINDOWS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum HypervVirtualMachineDetailOperatingSystemType

} // namespace RubrikSecurityCloud.Types