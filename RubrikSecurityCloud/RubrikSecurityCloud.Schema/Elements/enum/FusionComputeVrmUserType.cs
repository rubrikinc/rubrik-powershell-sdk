// FusionComputeVrmUserType.cs
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
    public enum FusionComputeVrmUserType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FUSION_COMPUTE_VRM_USER_TYPE_DOMAIN_USER")]
        FUSION_COMPUTE_VRM_USER_TYPE_DOMAIN_USER,

        [EnumMember(Value = "FUSION_COMPUTE_VRM_USER_TYPE_INTERCONNECTION_USER")]
        FUSION_COMPUTE_VRM_USER_TYPE_INTERCONNECTION_USER,

        [EnumMember(Value = "FUSION_COMPUTE_VRM_USER_TYPE_LOCAL_USER")]
        FUSION_COMPUTE_VRM_USER_TYPE_LOCAL_USER


    } // enum FusionComputeVrmUserType

} // namespace RubrikSecurityCloud.Types