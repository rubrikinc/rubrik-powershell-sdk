// AwsNativeEc2InstanceSortFields.cs
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
    public enum AwsNativeEc2InstanceSortFields
    {
        [EnumMember(Value = "ASSIGNED_SLA_DOMAIN")]
        ASSIGNED_SLA_DOMAIN,

        [EnumMember(Value = "AWS_NATIVE_ACCOUNT_NAME")]
        AWS_NATIVE_ACCOUNT_NAME,

        [EnumMember(Value = "AWS_VPC_ID")]
        AWS_VPC_ID,

        [EnumMember(Value = "EC2_INSTANCE_ID")]
        EC2_INSTANCE_ID,

        [EnumMember(Value = "EC2_INSTANCE_NAME")]
        EC2_INSTANCE_NAME,

        [EnumMember(Value = "EC2_INSTANCE_TYPE")]
        EC2_INSTANCE_TYPE,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "SENSITIVITY_HITS")]
        SENSITIVITY_HITS,

        [EnumMember(Value = "SENSITIVITY_STATUS")]
        SENSITIVITY_STATUS


    } // enum AwsNativeEc2InstanceSortFields

} // namespace RubrikSecurityCloud.Types