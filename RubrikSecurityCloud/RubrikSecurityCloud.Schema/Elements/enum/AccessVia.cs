// AccessVia.cs
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
    public enum AccessVia
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCESS_TYPE_UNSPECIFIED")]
        ACCESS_TYPE_UNSPECIFIED,

        [EnumMember(Value = "DIRECT")]
        DIRECT,

        [EnumMember(Value = "GROUP")]
        GROUP,

        [EnumMember(Value = "ROLE")]
        ROLE


    } // enum AccessVia

} // namespace RubrikSecurityCloud.Types