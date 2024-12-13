// NcdHypervisorType.cs
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
    public enum NcdHypervisorType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "HYPERV_HYPERVISOR_TYPE")]
        HYPERV_HYPERVISOR_TYPE,

        [EnumMember(Value = "KVM_HYPERVISOR_TYPE")]
        KVM_HYPERVISOR_TYPE,

        [EnumMember(Value = "NUTANIX_AHV_HYPERVISOR_TYPE")]
        NUTANIX_AHV_HYPERVISOR_TYPE,

        [EnumMember(Value = "VMWARE_HYPERVISOR_TYPE")]
        VMWARE_HYPERVISOR_TYPE


    } // enum NcdHypervisorType

} // namespace RubrikSecurityCloud.Types