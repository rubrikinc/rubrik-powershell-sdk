// AwsCloudType.cs
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
    public enum AwsCloudType
    {
        [EnumMember(Value = "C2S")]
        C2_S,

        [EnumMember(Value = "CHINA")]
        CHINA,

        [EnumMember(Value = "GOV")]
        GOV,

        [EnumMember(Value = "SC2S")]
        SC2_S,

        [EnumMember(Value = "STANDARD")]
        STANDARD


    } // enum AwsCloudType

} // namespace Rubrik.SecurityCloud.Types