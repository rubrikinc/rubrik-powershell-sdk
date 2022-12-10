// SapHanaEncryptionProvider.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:00.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum SapHanaEncryptionProvider
    {
        [EnumMember(Value = "COMMON_CRYPTO")]
        COMMON_CRYPTO,

        [EnumMember(Value = "EMPTY_VALUE")]
        EMPTY_VALUE,

        [EnumMember(Value = "OPENSSL")]
        OPENSSL,

        [EnumMember(Value = "SAP_CRYPTO")]
        SAP_CRYPTO


    } // enum SapHanaEncryptionProvider

} // namespace Rubrik.SecurityCloud.Types