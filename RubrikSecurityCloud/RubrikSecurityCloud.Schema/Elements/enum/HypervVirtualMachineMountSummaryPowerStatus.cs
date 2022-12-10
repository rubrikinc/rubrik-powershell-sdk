// HypervVirtualMachineMountSummaryPowerStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:27.
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
    public enum HypervVirtualMachineMountSummaryPowerStatus
    {
        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERED_OFF")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERED_OFF,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERED_ON")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERED_ON,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERING_OFF")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERING_OFF,

        [EnumMember(Value = "HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERING_ON")]
        HYPERV_VIRTUAL_MACHINE_MOUNT_SUMMARY_POWER_STATUS_POWERING_ON


    } // enum HypervVirtualMachineMountSummaryPowerStatus

} // namespace Rubrik.SecurityCloud.Types