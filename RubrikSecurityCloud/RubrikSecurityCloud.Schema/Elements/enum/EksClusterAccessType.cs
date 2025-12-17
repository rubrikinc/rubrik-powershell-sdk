// EksClusterAccessType.cs
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
    public enum EksClusterAccessType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EKS_CLUSTER_ACCESS_TYPE_PRIVATE")]
        EKS_CLUSTER_ACCESS_TYPE_PRIVATE,

        [EnumMember(Value = "EKS_CLUSTER_ACCESS_TYPE_PUBLIC")]
        EKS_CLUSTER_ACCESS_TYPE_PUBLIC,

        [EnumMember(Value = "EKS_CLUSTER_ACCESS_TYPE_UNSPECIFIED")]
        EKS_CLUSTER_ACCESS_TYPE_UNSPECIFIED


    } // enum EksClusterAccessType

} // namespace RubrikSecurityCloud.Types