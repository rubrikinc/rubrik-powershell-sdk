// OnPremAdSupportedEncryptionTypes.cs
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
    public enum OnPremAdSupportedEncryptionTypes
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AES128_CTS_HMAC_SHA1_96")]
        AES128_CTS_HMAC_SHA1_96,

        [EnumMember(Value = "AES256_CTS_HMAC_SHA1_96")]
        AES256_CTS_HMAC_SHA1_96,

        [EnumMember(Value = "DES_CBC_CRC")]
        DES_CBC_CRC,

        [EnumMember(Value = "DES_CBC_MD5")]
        DES_CBC_MD5,

        [EnumMember(Value = "ENCRYPTION_TYPE_UNSPECIFIED")]
        ENCRYPTION_TYPE_UNSPECIFIED,

        [EnumMember(Value = "RC4_HMAC")]
        RC4_HMAC


    } // enum OnPremAdSupportedEncryptionTypes

} // namespace RubrikSecurityCloud.Types