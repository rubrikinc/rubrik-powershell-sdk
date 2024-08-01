// InplaceCollisionRule.cs
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
    public enum InplaceCollisionRule
    {
        [EnumMember(Value = "APPEND")]
        APPEND,

        [EnumMember(Value = "INPLACE_COLLISION_RULE_UNKNOWN")]
        INPLACE_COLLISION_RULE_UNKNOWN,

        [EnumMember(Value = "OVERWRITE")]
        OVERWRITE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum InplaceCollisionRule

} // namespace RubrikSecurityCloud.Types