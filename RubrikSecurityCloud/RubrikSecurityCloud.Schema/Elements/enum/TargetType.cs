// TargetType.cs
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
    public enum TargetType
    {
        [EnumMember(Value = "AWS")]
        AWS,

        [EnumMember(Value = "AZURE")]
        AZURE,

        [EnumMember(Value = "GLACIER")]
        GLACIER,

        [EnumMember(Value = "GOOGLE")]
        GOOGLE,

        [EnumMember(Value = "NFS")]
        NFS,

        [EnumMember(Value = "RCS_AZURE")]
        RCS_AZURE,

        [EnumMember(Value = "S3_COMPATIBLE")]
        S3_COMPATIBLE,

        [EnumMember(Value = "TAPE")]
        TAPE


    } // enum TargetType

} // namespace RubrikSecurityCloud.Types