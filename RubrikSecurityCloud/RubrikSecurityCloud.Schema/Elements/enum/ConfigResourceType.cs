// ConfigResourceType.cs
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
    public enum ConfigResourceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_ADDRESS")]
        AWS_ADDRESS,

        [EnumMember(Value = "AWS_AUTOSCALING_GROUP")]
        AWS_AUTOSCALING_GROUP,

        [EnumMember(Value = "AWS_EC2_INSTANCE_CONNECT_ENDPOINT")]
        AWS_EC2_INSTANCE_CONNECT_ENDPOINT,

        [EnumMember(Value = "AWS_EC2_INSTANCE_PROFILE")]
        AWS_EC2_INSTANCE_PROFILE,

        [EnumMember(Value = "AWS_ECR")]
        AWS_ECR,

        [EnumMember(Value = "AWS_ECS_CLUSTER")]
        AWS_ECS_CLUSTER,

        [EnumMember(Value = "AWS_ECS_TASK_DEFINITION")]
        AWS_ECS_TASK_DEFINITION,

        [EnumMember(Value = "AWS_EKS")]
        AWS_EKS,

        [EnumMember(Value = "AWS_ELASTICACHE")]
        AWS_ELASTICACHE,

        [EnumMember(Value = "AWS_ELASTICACHE_PARAMETER_GROUP")]
        AWS_ELASTICACHE_PARAMETER_GROUP,

        [EnumMember(Value = "AWS_ELASTICACHE_SUBNET_GROUP")]
        AWS_ELASTICACHE_SUBNET_GROUP,

        [EnumMember(Value = "AWS_ELASTICACHE_USER")]
        AWS_ELASTICACHE_USER,

        [EnumMember(Value = "AWS_ELASTICACHE_USER_GROUP")]
        AWS_ELASTICACHE_USER_GROUP,

        [EnumMember(Value = "AWS_HOSTED_ZONE")]
        AWS_HOSTED_ZONE,

        [EnumMember(Value = "AWS_IAM_POLICY")]
        AWS_IAM_POLICY,

        [EnumMember(Value = "AWS_IAM_ROLE")]
        AWS_IAM_ROLE,

        [EnumMember(Value = "AWS_KMS_ALIAS")]
        AWS_KMS_ALIAS,

        [EnumMember(Value = "AWS_KMS_KEY")]
        AWS_KMS_KEY,

        [EnumMember(Value = "AWS_LAMBDA")]
        AWS_LAMBDA,

        [EnumMember(Value = "AWS_LAUNCH_TEMPLATE")]
        AWS_LAUNCH_TEMPLATE,

        [EnumMember(Value = "AWS_LAUNCH_TEMPLATE_VERSION")]
        AWS_LAUNCH_TEMPLATE_VERSION,

        [EnumMember(Value = "AWS_LOAD_BALANCER")]
        AWS_LOAD_BALANCER,

        [EnumMember(Value = "AWS_PREFIX_LIST")]
        AWS_PREFIX_LIST,

        [EnumMember(Value = "AWS_RDS_OPTION_GROUP")]
        AWS_RDS_OPTION_GROUP,

        [EnumMember(Value = "AWS_RDS_PARAMETER_GROUP")]
        AWS_RDS_PARAMETER_GROUP,

        [EnumMember(Value = "AWS_RDS_SUBNET_GROUP")]
        AWS_RDS_SUBNET_GROUP,

        [EnumMember(Value = "AWS_S3_ACCESS_POINT")]
        AWS_S3_ACCESS_POINT,

        [EnumMember(Value = "AWS_SECRET")]
        AWS_SECRET,

        [EnumMember(Value = "AWS_SECURITY_GROUP")]
        AWS_SECURITY_GROUP,

        [EnumMember(Value = "AWS_SUBNET")]
        AWS_SUBNET,

        [EnumMember(Value = "AWS_TARGET_GROUP")]
        AWS_TARGET_GROUP,

        [EnumMember(Value = "AWS_VPC")]
        AWS_VPC,

        [EnumMember(Value = "AWS_VPC_ENDPOINT")]
        AWS_VPC_ENDPOINT,

        [EnumMember(Value = "AWS_VPC_ENDPOINT_SERVICE")]
        AWS_VPC_ENDPOINT_SERVICE,

        [EnumMember(Value = "AWS_VPC_ROUTE_SERVER")]
        AWS_VPC_ROUTE_SERVER,

        [EnumMember(Value = "INTERNAL_ACM_CERTIFICATES")]
        INTERNAL_ACM_CERTIFICATES,

        [EnumMember(Value = "INTERNAL_CONNECTIONS")]
        INTERNAL_CONNECTIONS,

        [EnumMember(Value = "INTERNAL_EC2")]
        INTERNAL_EC2,

        [EnumMember(Value = "INTERNAL_LAMBDA_LAYER")]
        INTERNAL_LAMBDA_LAYER,

        [EnumMember(Value = "INTERNAL_POST_HOOK")]
        INTERNAL_POST_HOOK,

        [EnumMember(Value = "INTERNAL_PRE_HOOK")]
        INTERNAL_PRE_HOOK,

        [EnumMember(Value = "INTERNAL_RDS")]
        INTERNAL_RDS,

        [EnumMember(Value = "INTERNAL_RDS_CONNECTIVITY")]
        INTERNAL_RDS_CONNECTIVITY,

        [EnumMember(Value = "INTERNAL_RECONCILE")]
        INTERNAL_RECONCILE,

        [EnumMember(Value = "INTERNAL_S3")]
        INTERNAL_S3,

        [EnumMember(Value = "INTERNAL_S3_DESTINATION")]
        INTERNAL_S3_DESTINATION,

        [EnumMember(Value = "INTERNAL_WORKLOAD_GROUPING")]
        INTERNAL_WORKLOAD_GROUPING


    } // enum ConfigResourceType

} // namespace RubrikSecurityCloud.Types