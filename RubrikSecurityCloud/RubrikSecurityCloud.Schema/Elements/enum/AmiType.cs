// AmiType.cs
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
    public enum AmiType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CREATED_AT_RUNTIME")]
        CREATED_AT_RUNTIME,

        [EnumMember(Value = "EXISTING")]
        EXISTING,

        [EnumMember(Value = "PLATFORM_SPECIFIC_AMI")]
        PLATFORM_SPECIFIC_AMI,

        [EnumMember(Value = "USER_SPECIFIED")]
        USER_SPECIFIED


    } // enum AmiType

} // namespace RubrikSecurityCloud.Types