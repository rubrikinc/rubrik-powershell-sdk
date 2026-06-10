// QueryFusionComputeVirtualDisksFilterField.cs
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
    public enum QueryFusionComputeVirtualDisksFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FUSION_COMPUTE_VIRTUAL_DISK_DATASTORE_URN")]
        FUSION_COMPUTE_VIRTUAL_DISK_DATASTORE_URN,

        [EnumMember(Value = "FUSION_COMPUTE_VIRTUAL_DISK_NAME")]
        FUSION_COMPUTE_VIRTUAL_DISK_NAME,

        [EnumMember(Value = "FUSION_COMPUTE_VIRTUAL_DISK_VOLUME_UUID")]
        FUSION_COMPUTE_VIRTUAL_DISK_VOLUME_UUID,

        [EnumMember(Value = "QUERY_FUSION_COMPUTE_VIRTUAL_DISK_FILTER_UNSPECIFIED")]
        QUERY_FUSION_COMPUTE_VIRTUAL_DISK_FILTER_UNSPECIFIED


    } // enum QueryFusionComputeVirtualDisksFilterField

} // namespace RubrikSecurityCloud.Types