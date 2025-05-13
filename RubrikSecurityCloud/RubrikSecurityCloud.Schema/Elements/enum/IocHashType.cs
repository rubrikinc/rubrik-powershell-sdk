// IocHashType.cs
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
    public enum IocHashType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MD5")]
        MD5,

        [EnumMember(Value = "SHA1")]
        SH_A1,

        [EnumMember(Value = "SHA256")]
        SH_A256,

        [EnumMember(Value = "UNKNOWN_HASH_TYPE")]
        UNKNOWN_HASH_TYPE


    } // enum IocHashType

} // namespace RubrikSecurityCloud.Types