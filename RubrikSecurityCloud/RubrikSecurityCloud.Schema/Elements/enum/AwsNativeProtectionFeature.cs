// AwsNativeProtectionFeature.cs
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
    public enum AwsNativeProtectionFeature
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DYNAMODB")]
        DYNAMODB,

        [EnumMember(Value = "EC2")]
        EC2,

        [EnumMember(Value = "RDS")]
        RDS,

        [EnumMember(Value = "S3")]
        S3


    } // enum AwsNativeProtectionFeature

} // namespace RubrikSecurityCloud.Types