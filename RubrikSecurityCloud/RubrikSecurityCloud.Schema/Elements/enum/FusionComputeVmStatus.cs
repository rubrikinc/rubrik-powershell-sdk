// FusionComputeVmStatus.cs
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
    public enum FusionComputeVmStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FUSION_COMPUTE_VM_STATUS_UNSPECIFIED")]
        FUSION_COMPUTE_VM_STATUS_UNSPECIFIED,

        [EnumMember(Value = "MOUNTING")]
        MOUNTING,

        [EnumMember(Value = "POWERED_OFF")]
        POWERED_OFF,

        [EnumMember(Value = "POWERED_ON")]
        POWERED_ON,

        [EnumMember(Value = "UNMOUNTING")]
        UNMOUNTING


    } // enum FusionComputeVmStatus

} // namespace RubrikSecurityCloud.Types