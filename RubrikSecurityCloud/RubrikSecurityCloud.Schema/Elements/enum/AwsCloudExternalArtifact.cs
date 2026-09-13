// AwsCloudExternalArtifact.cs
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
    public enum AwsCloudExternalArtifact
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_KEY")]
        ACCESS_KEY,

        [EnumMember(Value = "ARTIFACT_KEY_UNSPECIFIED")]
        ARTIFACT_KEY_UNSPECIFIED,

        [EnumMember(Value = "AWS_KMS_KEY_SHARING_ROLE_ARN")]
        AWS_KMS_KEY_SHARING_ROLE_ARN,

        [EnumMember(Value = "CCES_BAAS_ROLE_ARN")]
        CCES_BAAS_ROLE_ARN,

        [EnumMember(Value = "CLOUDACCOUNTS_ROLE_ARN")]
        CLOUDACCOUNTS_ROLE_ARN,

        [EnumMember(Value = "CLOUD_COST_REPORT_ROLE_ARN")]
        CLOUD_COST_REPORT_ROLE_ARN,

        [EnumMember(Value = "CLOUD_DISCOVERY_ROLE_ARN")]
        CLOUD_DISCOVERY_ROLE_ARN,

        [EnumMember(Value = "CLOUD_NATIVE_ARCHIVAL_ROLE_ARN")]
        CLOUD_NATIVE_ARCHIVAL_ROLE_ARN,

        [EnumMember(Value = "CLOUD_NATIVE_CONFIG_PROTECTION_ROLE_ARN")]
        CLOUD_NATIVE_CONFIG_PROTECTION_ROLE_ARN,

        [EnumMember(Value = "CLOUD_NATIVE_DYNAMODB_PROTECTION_ROLE_ARN")]
        CLOUD_NATIVE_DYNAMODB_PROTECTION_ROLE_ARN,

        [EnumMember(Value = "CLOUD_NATIVE_PROTECTION_ROLE_ARN")]
        CLOUD_NATIVE_PROTECTION_ROLE_ARN,

        [EnumMember(Value = "CLOUD_NATIVE_S3_PROTECTION_ROLE_ARN")]
        CLOUD_NATIVE_S3_PROTECTION_ROLE_ARN,

        [EnumMember(Value = "CLOUD_NATIVE_UEM_KEY_MANAGEMENT_ROLE_ARN")]
        CLOUD_NATIVE_UEM_KEY_MANAGEMENT_ROLE_ARN,

        [EnumMember(Value = "CRITICAL_RESOURCE_PROTECTION_ROLE_ARN")]
        CRITICAL_RESOURCE_PROTECTION_ROLE_ARN,

        [EnumMember(Value = "CROSSACCOUNT_ROLE_ARN")]
        CROSSACCOUNT_ROLE_ARN,

        [EnumMember(Value = "DATA_CENTER_ROLE_BASED_ARCHIVAL_ROLE_ARN")]
        DATA_CENTER_ROLE_BASED_ARCHIVAL_ROLE_ARN,

        [EnumMember(Value = "EXOCOMPUTE_EKS_LAMBDA_ROLE_ARN")]
        EXOCOMPUTE_EKS_LAMBDA_ROLE_ARN,

        [EnumMember(Value = "EXOCOMPUTE_EKS_MASTERNODE_INSTANCE_PROFILE")]
        EXOCOMPUTE_EKS_MASTERNODE_INSTANCE_PROFILE,

        [EnumMember(Value = "EXOCOMPUTE_EKS_MASTERNODE_ROLE_ARN")]
        EXOCOMPUTE_EKS_MASTERNODE_ROLE_ARN,

        [EnumMember(Value = "EXOCOMPUTE_EKS_WORKERNODE_INSTANCE_PROFILE")]
        EXOCOMPUTE_EKS_WORKERNODE_INSTANCE_PROFILE,

        [EnumMember(Value = "EXOCOMPUTE_EKS_WORKERNODE_ROLE_ARN")]
        EXOCOMPUTE_EKS_WORKERNODE_ROLE_ARN,

        [EnumMember(Value = "EXOCOMPUTE_FLUENTD_ROLE_ARN")]
        EXOCOMPUTE_FLUENTD_ROLE_ARN,

        [EnumMember(Value = "EXOCOMPUTE_ROLE_ARN")]
        EXOCOMPUTE_ROLE_ARN,

        [EnumMember(Value = "GATEWAY_KMS_KEY_ARN")]
        GATEWAY_KMS_KEY_ARN,

        [EnumMember(Value = "IAM_USER_ARN")]
        IAM_USER_ARN,

        [EnumMember(Value = "KUBERNETES_PROTECTION_ROLE_ARN")]
        KUBERNETES_PROTECTION_ROLE_ARN,

        [EnumMember(Value = "RDS_PROTECTION_ROLE_ARN")]
        RDS_PROTECTION_ROLE_ARN,

        [EnumMember(Value = "ROLE_CHAINING_ROLE_ARN")]
        ROLE_CHAINING_ROLE_ARN,

        [EnumMember(Value = "SECRET_KEY")]
        SECRET_KEY,

        [EnumMember(Value = "SERVERS_AND_APPS_ROLE_ARN")]
        SERVERS_AND_APPS_ROLE_ARN,

        [EnumMember(Value = "STACK_ARN")]
        STACK_ARN,

        [EnumMember(Value = "STACK_NAME")]
        STACK_NAME


    } // enum AwsCloudExternalArtifact

} // namespace RubrikSecurityCloud.Types