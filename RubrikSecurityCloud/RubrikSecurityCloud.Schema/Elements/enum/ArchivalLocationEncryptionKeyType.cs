// ArchivalLocationEncryptionKeyType.cs
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
    public enum ArchivalLocationEncryptionKeyType
    {
        [EnumMember(Value = "AZURE_KEY_VAULT_KEY_TYPE")]
        AZURE_KEY_VAULT_KEY_TYPE,

        [EnumMember(Value = "RSA_KEY_TYPE")]
        RSA_KEY_TYPE,

        [EnumMember(Value = "STATIC_AWS_KMS_TYPE")]
        STATIC_AWS_KMS_TYPE,

        [EnumMember(Value = "STATIC_NO_ENCRYPTION_TYPE")]
        STATIC_NO_ENCRYPTION_TYPE,

        [EnumMember(Value = "STATIC_PASSWORD_TYPE")]
        STATIC_PASSWORD_TYPE,

        [EnumMember(Value = "STATIC_RSA_KEY_TYPE")]
        STATIC_RSA_KEY_TYPE,

        [EnumMember(Value = "UNKNOWN_KEY_TYPE")]
        UNKNOWN_KEY_TYPE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ArchivalLocationEncryptionKeyType

} // namespace RubrikSecurityCloud.Types