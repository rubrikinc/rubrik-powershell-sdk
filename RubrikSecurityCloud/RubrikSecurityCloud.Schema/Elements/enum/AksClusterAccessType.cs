// AksClusterAccessType.cs
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
    public enum AksClusterAccessType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AKS_CLUSTER_ACCESS_TYPE_PRIVATE")]
        AKS_CLUSTER_ACCESS_TYPE_PRIVATE,

        [EnumMember(Value = "AKS_CLUSTER_ACCESS_TYPE_PUBLIC")]
        AKS_CLUSTER_ACCESS_TYPE_PUBLIC,

        [EnumMember(Value = "AKS_CLUSTER_ACCESS_TYPE_UNSPECIFIED")]
        AKS_CLUSTER_ACCESS_TYPE_UNSPECIFIED


    } // enum AksClusterAccessType

} // namespace RubrikSecurityCloud.Types