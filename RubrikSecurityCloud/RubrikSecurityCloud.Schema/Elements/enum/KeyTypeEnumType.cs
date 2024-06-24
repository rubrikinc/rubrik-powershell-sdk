// KeyTypeEnumType.cs
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
    public enum KeyTypeEnumType
    {
        [EnumMember(Value = "KEY_TYPE_PLATFORM")]
        KEY_TYPE_PLATFORM,

        [EnumMember(Value = "KEY_TYPE_ROAMING")]
        KEY_TYPE_ROAMING,

        [EnumMember(Value = "KEY_TYPE_UNSPECIFIED")]
        KEY_TYPE_UNSPECIFIED


    } // enum KeyTypeEnumType

} // namespace RubrikSecurityCloud.Types