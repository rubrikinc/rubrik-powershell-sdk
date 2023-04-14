// AwsNativeRdsType.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum AwsNativeRdsType
    {
        [EnumMember(Value = "AURORA")]
        AURORA,

        [EnumMember(Value = "REGULAR_RDS")]
        REGULAR_RDS,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum AwsNativeRdsType

} // namespace Rubrik.SecurityCloud.Types