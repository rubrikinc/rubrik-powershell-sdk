// AwsNativeEbsVolumeType.cs
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
    public enum AwsNativeEbsVolumeType
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

        [EnumMember(Value = "SC1")]
        SC1,

        [EnumMember(Value = "ST1")]
        ST1,

        [EnumMember(Value = "STANDARD")]
        STANDARD,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AwsNativeEbsVolumeType

} // namespace Rubrik.SecurityCloud.Types