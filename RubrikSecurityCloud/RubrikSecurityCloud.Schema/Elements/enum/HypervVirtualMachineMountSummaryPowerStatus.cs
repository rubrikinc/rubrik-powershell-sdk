// HypervVirtualMachineMountSummaryPowerStatus.cs
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
    public enum HypervVirtualMachineMountSummaryPowerStatus
    {
        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_MOUNTED")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_MOUNTED,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_MOUNTING")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_MOUNTING,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERED_OFF")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERED_OFF,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERED_ON")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERED_ON,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERING_OFF")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERING_OFF,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERING_ON")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERING_ON,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_UNMOUNTING")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_UNMOUNTING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum HypervVirtualMachineMountSummaryPowerStatus

} // namespace RubrikSecurityCloud.Types