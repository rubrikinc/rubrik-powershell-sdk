// SapHanaEncryptionProvider.cs
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
    public enum SapHanaEncryptionProvider
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "COMMON_CRYPTO")]
        COMMON_CRYPTO,

        [EnumMember(Value = "EMPTY_VALUE")]
        EMPTY_VALUE,

        [EnumMember(Value = "OPENSSL")]
        OPENSSL,

        [EnumMember(Value = "SAP_CRYPTO")]
        SAP_CRYPTO


    } // enum SapHanaEncryptionProvider

} // namespace RubrikSecurityCloud.Types