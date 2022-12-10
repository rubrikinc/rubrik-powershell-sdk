// AwsNativeProtectionFeature.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:08.
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
    public enum AwsNativeProtectionFeature
    {
        [EnumMember(Value = "EC2")]
        EC2,

        [EnumMember(Value = "RDS")]
        RDS,

        [EnumMember(Value = "S3")]
        S3


    } // enum AwsNativeProtectionFeature

} // namespace Rubrik.SecurityCloud.Types