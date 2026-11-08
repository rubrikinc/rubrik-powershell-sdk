// AwsEcsCapacityProviderType.cs
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
    public enum AwsEcsCapacityProviderType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_ECS_CAPACITY_PROVIDER_TYPE_EC2_AUTO_SCALING")]
        AWS_ECS_CAPACITY_PROVIDER_TYPE_EC2_AUTO_SCALING,

        [EnumMember(Value = "AWS_ECS_CAPACITY_PROVIDER_TYPE_FARGATE")]
        AWS_ECS_CAPACITY_PROVIDER_TYPE_FARGATE,

        [EnumMember(Value = "AWS_ECS_CAPACITY_PROVIDER_TYPE_FARGATE_SPOT")]
        AWS_ECS_CAPACITY_PROVIDER_TYPE_FARGATE_SPOT,

        [EnumMember(Value = "AWS_ECS_CAPACITY_PROVIDER_TYPE_SELF_MANAGED")]
        AWS_ECS_CAPACITY_PROVIDER_TYPE_SELF_MANAGED


    } // enum AwsEcsCapacityProviderType

} // namespace RubrikSecurityCloud.Types