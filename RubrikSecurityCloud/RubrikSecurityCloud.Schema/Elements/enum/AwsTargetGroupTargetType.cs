// AwsTargetGroupTargetType.cs
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
    public enum AwsTargetGroupTargetType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_TG_TARGET_TYPE_ALB")]
        AWS_TG_TARGET_TYPE_ALB,

        [EnumMember(Value = "AWS_TG_TARGET_TYPE_INSTANCE")]
        AWS_TG_TARGET_TYPE_INSTANCE,

        [EnumMember(Value = "AWS_TG_TARGET_TYPE_IP")]
        AWS_TG_TARGET_TYPE_IP,

        [EnumMember(Value = "AWS_TG_TARGET_TYPE_LAMBDA")]
        AWS_TG_TARGET_TYPE_LAMBDA


    } // enum AwsTargetGroupTargetType

} // namespace RubrikSecurityCloud.Types