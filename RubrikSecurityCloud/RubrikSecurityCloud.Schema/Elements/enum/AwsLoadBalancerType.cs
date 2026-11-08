// AwsLoadBalancerType.cs
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
    public enum AwsLoadBalancerType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_LB_TYPE_APPLICATION")]
        AWS_LB_TYPE_APPLICATION,

        [EnumMember(Value = "AWS_LB_TYPE_GATEWAY")]
        AWS_LB_TYPE_GATEWAY,

        [EnumMember(Value = "AWS_LB_TYPE_NETWORK")]
        AWS_LB_TYPE_NETWORK


    } // enum AwsLoadBalancerType

} // namespace RubrikSecurityCloud.Types