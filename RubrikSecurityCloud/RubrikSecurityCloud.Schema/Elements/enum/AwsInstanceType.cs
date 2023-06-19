// AwsInstanceType.cs
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
    public enum AwsInstanceType
    {
        [EnumMember(Value = "AWS_TYPE_UNSPECIFIED")]
        AWS_TYPE_UNSPECIFIED,

        [EnumMember(Value = "M5_4XLARGE")]
        M5_4XLARGE,

        [EnumMember(Value = "M6I_2XLARGE")]
        M6I_2XLARGE,

        [EnumMember(Value = "M6I_4XLARGE")]
        M6I_4XLARGE,

        [EnumMember(Value = "M6I_8XLARGE")]
        M6I_8XLARGE


    } // enum AwsInstanceType

} // namespace RubrikSecurityCloud.Types