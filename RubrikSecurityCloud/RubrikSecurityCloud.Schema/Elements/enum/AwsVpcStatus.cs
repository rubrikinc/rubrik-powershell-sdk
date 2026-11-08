// AwsVpcStatus.cs
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
    public enum AwsVpcStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_VPC_STATUS_AVAILABLE")]
        AWS_VPC_STATUS_AVAILABLE,

        [EnumMember(Value = "AWS_VPC_STATUS_PENDING")]
        AWS_VPC_STATUS_PENDING


    } // enum AwsVpcStatus

} // namespace RubrikSecurityCloud.Types