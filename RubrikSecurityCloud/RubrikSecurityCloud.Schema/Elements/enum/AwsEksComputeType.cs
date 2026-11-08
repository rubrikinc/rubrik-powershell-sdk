// AwsEksComputeType.cs
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
    public enum AwsEksComputeType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_EKS_COMPUTE_TYPE_BOTH")]
        AWS_EKS_COMPUTE_TYPE_BOTH,

        [EnumMember(Value = "AWS_EKS_COMPUTE_TYPE_FARGATE")]
        AWS_EKS_COMPUTE_TYPE_FARGATE,

        [EnumMember(Value = "AWS_EKS_COMPUTE_TYPE_MANAGED_NODE_GROUP")]
        AWS_EKS_COMPUTE_TYPE_MANAGED_NODE_GROUP,

        [EnumMember(Value = "AWS_EKS_COMPUTE_TYPE_SELF_MANAGED")]
        AWS_EKS_COMPUTE_TYPE_SELF_MANAGED


    } // enum AwsEksComputeType

} // namespace RubrikSecurityCloud.Types