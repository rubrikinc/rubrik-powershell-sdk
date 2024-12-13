// InfrastructureTableColumnEnum.cs
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
    public enum InfrastructureTableColumnEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ClusterName")]
        CLUSTER_NAME,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "EncryptionEnabled")]
        ENCRYPTION_ENABLED,

        [EnumMember(Value = "Location")]
        LOCATION,

        [EnumMember(Value = "TotalCapacity")]
        TOTAL_CAPACITY,

        [EnumMember(Value = "UsedCapacity")]
        USED_CAPACITY


    } // enum InfrastructureTableColumnEnum

} // namespace RubrikSecurityCloud.Types