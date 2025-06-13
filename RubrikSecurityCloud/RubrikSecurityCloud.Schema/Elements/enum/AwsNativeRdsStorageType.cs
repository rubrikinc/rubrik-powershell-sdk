// AwsNativeRdsStorageType.cs
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
    public enum AwsNativeRdsStorageType
    {
        [EnumMember(Value = "GP2")]
        GP2,

        [EnumMember(Value = "GP3")]
        GP3,

        [EnumMember(Value = "IO1")]
        IO1,

        [EnumMember(Value = "IO2")]
        IO2,

        [EnumMember(Value = "NOT_SPECIFIED")]
        NOT_SPECIFIED,

        [EnumMember(Value = "STANDARD")]
        STANDARD,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AwsNativeRdsStorageType

} // namespace RubrikSecurityCloud.Types