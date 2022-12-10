// AwsNativeEc2InstanceSortFields.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:10.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
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
        EFFECTIVE_SLA_DOMAIN


    } // enum AwsNativeEc2InstanceSortFields

} // namespace Rubrik.SecurityCloud.Types