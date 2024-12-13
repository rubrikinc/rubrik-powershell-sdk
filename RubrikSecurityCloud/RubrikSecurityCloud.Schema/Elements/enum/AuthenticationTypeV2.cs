// AuthenticationTypeV2.cs
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
    public enum AuthenticationTypeV2
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AUTH_TYPE_UNSPECIFIED")]
        AUTH_TYPE_UNSPECIFIED,

        [EnumMember(Value = "BASIC")]
        BASIC,

        [EnumMember(Value = "BEARER")]
        BEARER,

        [EnumMember(Value = "CUSTOM_HEADER")]
        CUSTOM_HEADER,

        [EnumMember(Value = "URL")]
        URL


    } // enum AuthenticationTypeV2

} // namespace RubrikSecurityCloud.Types