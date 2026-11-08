// AwsLoadBalancerStatus.cs
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
    public enum AwsLoadBalancerStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_LB_STATUS_ACTIVE")]
        AWS_LB_STATUS_ACTIVE,

        [EnumMember(Value = "AWS_LB_STATUS_ACTIVE_IMPAIRED")]
        AWS_LB_STATUS_ACTIVE_IMPAIRED,

        [EnumMember(Value = "AWS_LB_STATUS_FAILED")]
        AWS_LB_STATUS_FAILED,

        [EnumMember(Value = "AWS_LB_STATUS_PROVISIONING")]
        AWS_LB_STATUS_PROVISIONING


    } // enum AwsLoadBalancerStatus

} // namespace RubrikSecurityCloud.Types