// NutanixVmMountStatus.cs
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
    public enum NutanixVmMountStatus
    {
        [EnumMember(Value = "NUTANIX_VM_MOUNT_STATUS_DELETING")]
        NUTANIX_VM_MOUNT_STATUS_DELETING,

        [EnumMember(Value = "NUTANIX_VM_MOUNT_STATUS_MIGRATING")]
        NUTANIX_VM_MOUNT_STATUS_MIGRATING,

        [EnumMember(Value = "NUTANIX_VM_MOUNT_STATUS_MOUNTING")]
        NUTANIX_VM_MOUNT_STATUS_MOUNTING,

        [EnumMember(Value = "NUTANIX_VM_MOUNT_STATUS_POWERED_OFF")]
        NUTANIX_VM_MOUNT_STATUS_POWERED_OFF,

        [EnumMember(Value = "NUTANIX_VM_MOUNT_STATUS_POWERED_ON")]
        NUTANIX_VM_MOUNT_STATUS_POWERED_ON,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum NutanixVmMountStatus

} // namespace RubrikSecurityCloud.Types