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
        [EnumMember(Value = "ACCESS_KEY")]
        ACCESS_KEY,

        [EnumMember(Value = "ARTIFACT_KEY_UNSPECIFIED")]
        ARTIFACT_KEY_UNSPECIFIED,

        [EnumMember(Value = "CROSSACCOUNT_ROLE_ARN")]
        CROSSACCOUNT_ROLE_ARN,

        [EnumMember(Value = "EXOCOMPUTE_EKS_MASTERNODE_INSTANCE_PROFILE")]
        EXOCOMPUTE_EKS_MASTERNODE_INSTANCE_PROFILE,

        [EnumMember(Value = "EXOCOMPUTE_EKS_MASTERNODE_ROLE_ARN")]
        EXOCOMPUTE_EKS_MASTERNODE_ROLE_ARN,

        [EnumMember(Value = "EXOCOMPUTE_EKS_WORKERNODE_INSTANCE_PROFILE")]
        EXOCOMPUTE_EKS_WORKERNODE_INSTANCE_PROFILE,

        [EnumMember(Value = "EXOCOMPUTE_EKS_WORKERNODE_ROLE_ARN")]
        EXOCOMPUTE_EKS_WORKERNODE_ROLE_ARN,

        [EnumMember(Value = "IAM_USER_ARN")]
        IAM_USER_ARN,

        [EnumMember(Value = "SECRET_KEY")]
        SECRET_KEY


    } // enum AwsCloudExternalArtifact

} // namespace RubrikSecurityCloud.Types