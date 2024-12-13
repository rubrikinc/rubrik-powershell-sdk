// ClusterCreateValidations.cs
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
    public enum ClusterCreateValidations
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ALL_CHECKS")]
        ALL_CHECKS,

        [EnumMember(Value = "AWS_INSTANCE_PROFILE_CHECK")]
        AWS_INSTANCE_PROFILE_CHECK,

        [EnumMember(Value = "AWS_NETWORK_CONFIG_CHECK")]
        AWS_NETWORK_CONFIG_CHECK,

        [EnumMember(Value = "AZURE_AVAILABILITY_ZONE_CHECK")]
        AZURE_AVAILABILITY_ZONE_CHECK,

        [EnumMember(Value = "AZURE_MI_CHECK")]
        AZURE_MI_CHECK,

        [EnumMember(Value = "AZURE_QUOTA_CHECK")]
        AZURE_QUOTA_CHECK,

        [EnumMember(Value = "AZURE_VM_IMAGE_CHECK")]
        AZURE_VM_IMAGE_CHECK,

        [EnumMember(Value = "CLOUD_ACCOUNT_CHECK")]
        CLOUD_ACCOUNT_CHECK,

        [EnumMember(Value = "CLUSTER_NAME_CHECK")]
        CLUSTER_NAME_CHECK,

        [EnumMember(Value = "DNS_SERVERS_CHECK")]
        DNS_SERVERS_CHECK,

        [EnumMember(Value = "IMMUTABILITY_CHECK")]
        IMMUTABILITY_CHECK,

        [EnumMember(Value = "NODE_COUNT_CHECK")]
        NODE_COUNT_CHECK,

        [EnumMember(Value = "NO_CHECKS")]
        NO_CHECKS,

        [EnumMember(Value = "NTP_SERVERS_CHECK")]
        NTP_SERVERS_CHECK,

        [EnumMember(Value = "OBJECT_STORE_CHECK")]
        OBJECT_STORE_CHECK


    } // enum ClusterCreateValidations

} // namespace RubrikSecurityCloud.Types