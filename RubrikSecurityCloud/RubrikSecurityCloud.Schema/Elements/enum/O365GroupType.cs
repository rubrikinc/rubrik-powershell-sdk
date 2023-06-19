// O365GroupType.cs
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
    public enum O365GroupType
    {
        [EnumMember(Value = "AD_GROUP")]
        AD_GROUP,

        [EnumMember(Value = "CONFIGURED_GROUP")]
        CONFIGURED_GROUP,

        [EnumMember(Value = "UNTYPED_GROUP")]
        UNTYPED_GROUP


    } // enum O365GroupType

} // namespace RubrikSecurityCloud.Types