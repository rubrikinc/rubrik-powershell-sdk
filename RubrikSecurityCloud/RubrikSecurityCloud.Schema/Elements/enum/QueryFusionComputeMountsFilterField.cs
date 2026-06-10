// QueryFusionComputeMountsFilterField.cs
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
    public enum QueryFusionComputeMountsFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "FUSION_COMPUTE_MOUNT_NAME")]
        FUSION_COMPUTE_MOUNT_NAME,

        [EnumMember(Value = "ORG_ID")]
        ORG_ID,

        [EnumMember(Value = "ORIGINAL_VM_ID")]
        ORIGINAL_VM_ID,

        [EnumMember(Value = "QUERY_FUSION_COMPUTE_MOUNT_FILTER_UNSPECIFIED")]
        QUERY_FUSION_COMPUTE_MOUNT_FILTER_UNSPECIFIED


    } // enum QueryFusionComputeMountsFilterField

} // namespace RubrikSecurityCloud.Types