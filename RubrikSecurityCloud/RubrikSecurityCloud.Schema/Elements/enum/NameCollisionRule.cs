// NameCollisionRule.cs
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
    public enum NameCollisionRule
    {
        [EnumMember(Value = "APPEND")]
        APPEND,

        [EnumMember(Value = "OVERWRITE")]
        OVERWRITE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum NameCollisionRule

} // namespace RubrikSecurityCloud.Types