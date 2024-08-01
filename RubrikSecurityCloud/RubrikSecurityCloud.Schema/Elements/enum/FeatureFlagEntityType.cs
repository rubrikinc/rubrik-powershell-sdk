// FeatureFlagEntityType.cs
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
    public enum FeatureFlagEntityType
    {
        [EnumMember(Value = "ACCOUNT")]
        ACCOUNT,

        [EnumMember(Value = "RANDOM")]
        RANDOM,

        [EnumMember(Value = "SESSION")]
        SESSION,

        [EnumMember(Value = "USER")]
        USER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum FeatureFlagEntityType

} // namespace RubrikSecurityCloud.Types