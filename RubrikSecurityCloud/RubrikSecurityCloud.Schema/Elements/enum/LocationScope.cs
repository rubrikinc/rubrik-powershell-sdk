// LocationScope.cs
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
    public enum LocationScope
    {
        [EnumMember(Value = "GLOBAL")]
        GLOBAL,

        [EnumMember(Value = "LOCAL")]
        LOCAL,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum LocationScope

} // namespace RubrikSecurityCloud.Types