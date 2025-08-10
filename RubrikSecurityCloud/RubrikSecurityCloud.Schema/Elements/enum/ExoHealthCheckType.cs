// ExoHealthCheckType.cs
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
    public enum ExoHealthCheckType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACR_CONNECTIVITY")]
        ACR_CONNECTIVITY,

        [EnumMember(Value = "ARCHIVAL_LOCATION_CONNECTIVITY_OPTIONAL")]
        ARCHIVAL_LOCATION_CONNECTIVITY_OPTIONAL,

        [EnumMember(Value = "AUTOSCALER_CONNECTIVITY")]
        AUTOSCALER_CONNECTIVITY,

        [EnumMember(Value = "AZURE_PLATFORM_IP_CONNECTIVITY")]
        AZURE_PLATFORM_IP_CONNECTIVITY,

        [EnumMember(Value = "CHECK_TYPE_UNSPECIFIED")]
        CHECK_TYPE_UNSPECIFIED,

        [EnumMember(Value = "CLOUDSLAB_CONNECTIVITY_OPTIONAL")]
        CLOUDSLAB_CONNECTIVITY_OPTIONAL,

        [EnumMember(Value = "EC2_CONNECTIVITY")]
        EC2_CONNECTIVITY,

        [EnumMember(Value = "ECR_CONNECTIVITY")]
        ECR_CONNECTIVITY,

        [EnumMember(Value = "EKS_CONNECTIVITY")]
        EKS_CONNECTIVITY,

        [EnumMember(Value = "GCP_CONNECTIVITY")]
        GCP_CONNECTIVITY,

        [EnumMember(Value = "GCS_CONNECTIVITY_OPTIONAL")]
        GCS_CONNECTIVITY_OPTIONAL,

        [EnumMember(Value = "HOST_CONNECTIVITY")]
        HOST_CONNECTIVITY,

        [EnumMember(Value = "KMS_CONNECTIVITY")]
        KMS_CONNECTIVITY,

        [EnumMember(Value = "RSC_IP_CONNECTIVITY")]
        RSC_IP_CONNECTIVITY,

        [EnumMember(Value = "STS_CONNECTIVITY")]
        STS_CONNECTIVITY


    } // enum ExoHealthCheckType

} // namespace RubrikSecurityCloud.Types