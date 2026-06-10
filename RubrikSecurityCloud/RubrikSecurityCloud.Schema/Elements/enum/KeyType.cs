// KeyType.cs
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
    public enum KeyType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "KEY_TYPE_EC")]
        KEY_TYPE_EC,

        [EnumMember(Value = "KEY_TYPE_RSA")]
        KEY_TYPE_RSA,

        [EnumMember(Value = "KEY_TYPE_UNSPECIFIED")]
        KEY_TYPE_UNSPECIFIED


    } // enum KeyType

} // namespace RubrikSecurityCloud.Types